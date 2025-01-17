﻿using com.ggasoftware.indigo;
using RSC.Properties;
using System.Collections.Generic;

namespace RSC.CVSP.Compounds.Operations
{
	public class CalculateMolecularFormula : OperationBase
	{
		public override void ProcessRecord(Record record, IDictionary<string, object> options = null)
		{
			var indigo = GetIndigo();

			IndigoObject obj = indigo.loadMolecule(record.Standardized);

			record.AddProperty(
				PropertyName.MOLECULAR_FORMULA,
				obj.grossFormula(),
				OriginValueType.Calculated,
				PropertyManager.Current.GetIndigoProvenanceId()
			);
		}

		public override IEnumerable<OperationInfo> GetOperations()
		{
			return new List<OperationInfo>() {
				new OperationInfo() {
					Id = "MFCalculation",
					Name = "Molecular Formula Calculation",
					Description = "Calculate molecular formula"
				}
			};
		}
	}
}
