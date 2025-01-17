﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using RSC.Collections;
using RSC.Datasources;
using RSC.Properties;
using System.Threading;

namespace RSC.Compounds.DataExport
{
	/// <summary>
	/// Export file for Properties.
	/// Used for generating Rdf files, containing Properties.
	/// </summary>
	public class PropertiesDataExportFile : DataSourceDataExportFile
	{
		private static readonly int chunkSize = 500;

		/// <summary>
		/// Call the base constructor.
		/// </summary>
		public PropertiesDataExportFile(IDataSourceExport exp)
			: base(exp)
		{
			FileName = String.Format("PROPERTIES_{0}{1}.ttl", ( exp as IDataSourceExport ).DsnLabel, exp.ExportDate.ToString("yyyyMMdd"));
		}

		/// <summary>
		/// Only works for an Open PHACTS export.
		/// </summary>
		/// <param name="revision"></param>
		/// <param name="compoundRecordsProperties"></param>
		/// <param name="compoundsChunk"></param>
		/// <param name="propertyDefinitions"></param>
		/// <returns></returns>
		public IEnumerable<string> ExportRevisionLines(Revision revision,
			IDictionary<ExternalId, IEnumerable<Property>> compoundRecordsProperties,
			IEnumerable<Compound> compoundsChunk,
			IEnumerable<PropertyDefinition> propertyDefinitions)
		{
			if ( revision.Id == null )
				throw new Exception("null revision id");
			var externalId = new ExternalId { DomainId = 1, ObjectId = revision.Id };
			//Get the OpsId.
			ExternalReference opsIdentifier = compoundsChunk.FirstOrDefault(c => c.Id == revision.CompoundId)
				.ExternalReferences
				.FirstOrDefault(e => e.Type.UriSpace == Constants.OPSUriSpace);
			if ( compoundRecordsProperties.ContainsKey(externalId) && opsIdentifier != null ) {
				//Retrieve the turtle properties using those Properties generated by ChemSpider.
				var props = CompoundPropertyLines(opsIdentifier.ToOpsId(),
					compoundRecordsProperties[externalId]
					.Where(p => p.ProvenanceId == PropertyManager.Current.GetChemSpiderProvenanceId()), propertyDefinitions);

				//Write the turtle properties to file and increment record count.
				foreach ( var prop in props ) {
					yield return prop;
					RecordCount++;
				}
			}
		}

		/// <summary>
		/// Convention is this: if nodeStart is :OPS0,
		/// :OPS0ct is the connection table
		/// :OPS0ct.execution is the execution of ACD/Labs
		/// :OPS0prop is the property
		/// </summary>
		/// <param name="compoundId">The compound id</param>
		/// <returns>List of triples for the compound</returns>
		public static List<string> PropertyProvenanceLines(string compoundId)
		{
			return new List<string>
			{
				string.Format(":{0}ct rdf:type cheminf:CHEMINF_000055 .", compoundId),
				string.Format(":{0}ct {3} {1}:{2}{0} .", compoundId, Turtle.RDF_URI_PREFIX.ToLower(),
					Turtle.RDF_URI_PREFIX, Turtle.obo_isabout),
				string.Format(":{0}execution rdf:type cheminf:CHEMINF_000354 .", compoundId),
				string.Format(":{0}execution obo:OBI_0000293 :{0}ct .", compoundId)
			};
			// the connection table is_about the molecule
			// execution has specified input the connection table
		}

		/// <summary>
		/// Gets a list of numerical properties using qudt.
		/// </summary>
		/// <param name="opsId">The ops id.</param>
		/// <param name="properties">List of the properties.</param>
		/// <param name="propertyDefinitions">List of the property definitions.</param>
		/// <returns>List of numerical properties.</returns>
		public static List<string> CompoundPropertyLines(string opsId, IEnumerable<Property> properties, IEnumerable<PropertyDefinition> propertyDefinitions)
		{
			var result = new List<string>();
			var c = 0;

			result.AddRange(PropertyProvenance(opsId));
			//Iterate properties that are not error properties and not null.
			foreach ( var property in properties.Where(p => !string.IsNullOrEmpty(p.Value.ToString())
														&& Turtle.CheminfPropertyMappings.Any(m => m.PropertyName == p.Name)) ) {
				result.AddRange(property.ToTurtle(opsId, c, UnitStyle.QUDT, propertyDefinitions));
				c++;
			}
			return result;
		}

		/// <summary>
		/// Convention is this: if nodeStart is :OPS0,
		/// :OPS0ct is the connection table
		/// :OPS0ct.execution is the execution of ACD/Labs
		/// :OPS0prop is the property
		/// </summary>
		/// <param name="compoundId">The compound id</param>
		/// <returns>List of triples for the compound</returns>
		public static List<string> PropertyProvenance(string compoundId)
		{
			return new List<string>
			{
				string.Format(":{0}ct rdf:type cheminf:CHEMINF_000055 .", compoundId),
				string.Format(":{0}ct {3} {1}:{2}{0} .", compoundId, Turtle.RDF_URI_PREFIX.ToLower(), Turtle.RDF_URI_PREFIX, Turtle.obo_isabout),
				string.Format(":{0}execution rdf:type cheminf:CHEMINF_000354 .", compoundId),
				string.Format(":{0}execution obo:OBI_0000293 :{0}ct .", compoundId)
			};
			// the connection table is_about the molecule
			// execution has specified input the connection table
		}

		//Add the comments at the end of the prefixes.
		public static List<string> CommentLines = new List<string>()
		{
			"#",
			"# " + Turtle.obo_isabout + " means is_about",
			"# cheminf:CHEMINF_000055 is a connection table,",
			"# cheminf:CHEMINF_000354 is an execution of the ACD/Labs software",
			"# " + Turtle.obo_hasspecifiedinput + " and " + Turtle.obo_hasspecifiedoutput + " specify input and output",
			"#"
		};

		/// <summary>
		/// Exports Rdf Synonyms the full export.
		/// </summary>
		public override void Export(IDataExport exp, Encoding encoding)
		{
			base.Export(exp, encoding);

			// Write the properties.
			using ( TextWriter ttl = new StreamWriter(FileFullPath, false, encoding) )
			using ( TextWriter w = TextWriter.Synchronized(ttl) ) {
				//Get the synonyms file uri.
				var propertiesUri = string.Format("{0}/{1}/{2}", exp.DownloadUrl.TrimEnd('/'), exp.ExportDirectory, FileName);

				foreach ( var p in PrefixLines(propertiesUri, TurtlePrefixSets.Properties) )
					w.WriteLine(p);

				//Add the predicate to describe which dataset this is in.
				var datasetObject = string.Format("{0}-{1}", Turtle.DATASET_LABEL.ToLower(), ( exp as IDataSourceExport ).DsnLabel.ToLower()); //E.g. :chemspider-chebi
				w.WriteLine(Turtle.VoidInDatasetLine(( exp as IDataSourceExport ).DataSource.Name, datasetObject, propertiesUri, exp.DownloadUrl, exp.ExportDate));

				//Output the properties comments.
				foreach ( var l in CommentLines )
					w.WriteLine(l);

				var propertyDefinitions = exp.PropertiesStore.PropertyDefinitionsList();

				// here are the properties
				exp.CompoundsStore
					.GetDataSourceRevisionIds(( exp as IDataSourceExport ).DataSource.Guid)
					.ToChunks(chunkSize)
					.AsParallel()
					.ForAll(revIds => {
						//Get the revisions as Properties are stored against revisions.
						var revisions = exp.CompoundsStore.GetRevisions(revIds, new[] { "Id", "CompoundId" });

						//Get the CompoundIds from the Revisions
						var compounds = exp.CompoundsStore.GetCompounds(revisions.Select(r => r.CompoundId), new[] { "ExternalReferences", "Id" });

						//Get the dictionary of Compound Ids and Properties for the chunk.
						var compoundRecordsProperties = exp.PropertiesStore
							.GetRecordsProperties(revisions.Select(r => new ExternalId { DomainId = 1, ObjectId = r.Id }), null);

						if ( compoundRecordsProperties == null )
							throw new Exception("null compound records properties");

						foreach ( var revision in revisions ) {
							if ( revision.Id == null )
								throw new Exception("null revision id");
							var externalId = new ExternalId { DomainId = 1, ObjectId = revision.Id };
							
							ExternalReference opsIdentifier = compounds
								.FirstOrDefault(c => c.Id == revision.CompoundId)
								.ExternalReferences
								.FirstOrDefault(e => e.Type.UriSpace == Constants.OPSUriSpace);

							if ( compoundRecordsProperties.ContainsKey(externalId) && opsIdentifier != null ) {
								//Retrieve the turtle properties using those Properties generated by ChemSpider.
								var props = CompoundPropertyLines(opsIdentifier.ToOpsId(),
									compoundRecordsProperties[externalId]
									.Where(p => p.ProvenanceId == PropertyManager.Current.GetChemSpiderProvenanceId()), propertyDefinitions);

								foreach ( var prop in props ) {
									w.WriteLine(prop);
									Interlocked.Increment(ref recordCount);
								}
							}
						}

						Console.Out.Write(".");
					});
			}
		}
	}
}
