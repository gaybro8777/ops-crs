SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT (EXISTS (SELECT 1 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'dbo' 
                 AND  TABLE_NAME = 'LegacyOpsIds'))
BEGIN

CREATE TABLE [dbo].[LegacyOpsIds](
	[Id] [bigint] NOT NULL,
	[InChIKey] [char](27) NOT NULL
) ON [PRIMARY]

END

SET ANSI_PADDING OFF
GO
