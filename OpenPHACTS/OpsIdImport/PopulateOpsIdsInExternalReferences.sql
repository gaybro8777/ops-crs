--**************************************************************************************************************************
-- Author: Jon Steele
-- Date:   1/9/2015
--**************************************************************************************************************************
-- Description:
-- Script to be run after generating OpenPhacts depositions which will populate the ExternalReferences table with either the
-- old OpsId or a new minted OpsId. This script expects there to be a table in RSCCompounds - LegacyOpsIds (Containing Id 
-- and Non-Standard InchiKey).
--**************************************************************************************************************************

USE RSCCompounds2
GO

--Update the OpsIds using the old LEGACY_CSIDS table.
DECLARE @externalReferenceTypeId int
SELECT @externalReferenceTypeId = Id 
	FROM ExternalReferenceTypes 
		WHERE UriSpace = 'http://ops.rsc.org/'

--Insert the OpsIds into ExternalId table where the InChIKeys match the old compounds.
INSERT INTO ExternalReferences
SELECT c.Id as CompoundId, @externalReferenceTypeId as ExternalReferenceTypeId, CONVERT(NVARCHAR(MAX), old.Id) as Value
	FROM Compounds c
		JOIN Inchis i on i.Id = c.NonStandardInChIId
		JOIN LegacyOpsIds old ON old.InChIKey = i.InChIKey --NOTE: Change to the appropriate database.
	WHERE NOT EXISTS (SELECT 1 FROM ExternalReferences e 
						WHERE e.CompoundId = c.Id AND e.ExternalReferenceTypeId = @externalReferenceTypeId)

--Next assign the other ids which are not in the old system to an id outside the range of the old ids.
DECLARE @max_old_id int
DECLARE @max_new_id int
DECLARE @max_id int

SELECT @max_old_id = MAX(Id)+1 FROM LegacyOpsIds
SELECT @max_new_id = MAX(Value)+1 
	FROM ExternalReferences
		WHERE ExternalReferenceTypeId = @externalReferenceTypeId --Check this works with nvarchar(max).

if(@max_old_id > @max_new_id)
	SET @max_id = @max_old_id
else
	SET @max_id = @max_new_id

DECLARE c1 CURSOR FOR
	SELECT c.Id FROM
		compounds c
		WHERE NOT EXISTS (SELECT 1 FROM ExternalReferences e 
							WHERE e.CompoundId = c.Id AND e.ExternalReferenceTypeId = @externalReferenceTypeId)

--Assign the Compounds an OpsId that do not have one yet assigned.
OPEN c1
		DECLARE @res INT
		SET @res = 0
		WHILE @res = 0
			BEGIN
				DECLARE @compoundId uniqueidentifier
				
				--Fetch the next CompoundId.
				FETCH c1 INTO @compoundId
				IF @@fetch_status <> 0
					BREAK

				--Update the empty OpsId to a number outside the current range.
				INSERT INTO ExternalReferences (CompoundId, ExternalReferenceTypeId, Value)
					VALUES (@compoundId, @externalReferenceTypeId, CONVERT(NVARCHAR(MAX), @max_id))

				SET @max_id = @max_id + 1;
			END
CLOSE c1
DEALLOCATE c1

