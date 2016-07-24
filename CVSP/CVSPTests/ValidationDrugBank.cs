﻿//using System;
//using System.Diagnostics;
//using System.Text;
//using System.Data;
//using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//using MoleculeObjects;
//using com.ggasoftware.indigo;
//using RSC.CVSP.Compounds;
//using RSC.CVSP;

//namespace CVSPTests
//{
//	[TestClass]
//	public class ValidationDrugBank
//	{
//		[TestMethod]
//		public void test_DrugBank()
//		{
//			string sdf = @"[NO NAME]
//  Mrv0541 04221219462D          
//Created with ChemWriter - http://chemwriter.com
// 91 96  0  0  1  0            999 V2000
//   12.8548   -2.6382    0.0000 O   0  0  0  0  0  0  0  0  0  0  0  0
//   13.9726   -2.5226    0.0000 O   0  0  0  0  0  0  0  0  0  0  0  0
//   10.1766   -3.9327    0.0000 O   0  0  0  0  0  0  0  0  0  0  0  0
//   11.2019   -0.7961    0.0000 O   0  0  0  0  0  0  0  0  0  0  0  0
//    8.7800   -1.3064    0.0000 O   0  0  0  0  0  0  0  0  0  0  0  0
//   16.8589   -3.2421    0.0000 O   0  0  0  0  0  0  0  0  0  0  0  0
//   10.3562    1.2163    0.0000 O   0  0  0  0  0  0  0  0  0  0  0  0
//    3.2702    4.8341    0.0000 O   0  0  0  0  0  0  0  0  0  0  0  0
//    2.3500    8.2734    0.0000 O   0  0  0  0  0  0  0  0  0  0  0  0
//    3.8213    4.2201    0.0000 O   0  0  0  0  0  0  0  0  0  0  0  0
//    5.2178    1.5938    0.0000 O   0  0  0  0  0  0  0  0  0  0  0  0
//    7.8960    2.8883    0.0000 O   0  0  0  0  0  0  0  0  0  0  0  0
//    7.1271    0.5358    0.0000 O   0  0  0  0  0  0  0  0  0  0  0  0
//   12.4834    3.1249    0.0000 O   0  0  0  0  0  0  0  0  0  0  0  0
//   13.1495   -4.0364    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//   11.2402   -2.9784    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//   15.2089   -3.2393    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//   10.1383   -1.7503    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//   15.6226   -2.5255    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//   12.3806   -6.3890    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//    9.2926    0.2619    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//    3.1485    7.0391    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//    4.3338    5.7884    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//   16.8613   -1.8132    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//    8.1907    1.4900    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//    5.1795    3.7761    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//    6.2814    2.5480    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//   11.3170   -7.3433    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//   12.6753   -7.7873    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//    3.8596    0.7098    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//    6.7335    6.3823    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//    5.9507    7.4636    0.0000 N   0  0  0  0  0  0  0  0  0  0  0  0
//   13.9701   -3.9516    0.0000 C   0  0  1  0  0  0  0  0  0  0  0  0
//   14.3043   -4.7058    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   13.6903   -5.2569    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   12.9766   -4.8431    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   12.5984   -3.4224    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   11.7912   -3.5925    0.0000 C   0  0  2  0  0  0  0  0  0  0  0  0
//   14.3838   -3.2378    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   11.5349   -4.3767    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   12.0859   -4.9907    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    9.8819   -2.5345    0.0000 C   0  0  2  0  0  0  0  0  0  0  0  0
//   10.4330   -3.1486    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    9.0747   -2.7046    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    8.8184   -3.4889    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   11.8295   -5.7750    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    8.0112   -3.6590    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    9.3694   -4.1029    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    9.5873   -1.1363    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    9.8436   -0.3521    0.0000 C   0  0  1  0  0  0  0  0  0  0  0  0
//   10.6509   -0.1820    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   16.4476   -2.5269    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    2.9756    6.2324    0.0000 C   0  0  1  0  0  0  0  0  0  0  0  0
//   12.0091   -0.6259    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    8.9979    1.6602    0.0000 C   0  0  2  0  0  0  0  0  0  0  0  0
//    9.5489    1.0461    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   12.1242   -7.1732    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    2.1549    6.1475    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    4.8848    5.1744    0.0000 C   0  0  1  0  0  0  0  0  0  0  0  0
//    4.9232    2.9920    0.0000 C   0  0  1  0  0  0  0  0  0  0  0  0
//    1.8207    6.9019    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    9.2542    2.4444    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    4.1159    2.8219    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    3.5266    5.6183    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    2.4348    7.4528    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    5.6921    5.3445    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    6.8324    1.9340    0.0000 C   0  0  2  0  0  0  0  0  0  0  0  0
//    4.6285    4.3902    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   12.1793   -1.4332    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   12.8164   -0.4557    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   11.8389    0.1814    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    3.8596    2.0376    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    5.4742    2.3779    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    7.6397    2.1041    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   10.0615    2.6145    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    3.0790    1.7862    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    5.9484    6.1287    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    4.3411    1.3737    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    3.0790    0.9612    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    6.5761    1.1498    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    2.3645    2.1987    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   10.3178    3.3987    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   10.6125    2.0005    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    2.3645    0.5487    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    5.4646    6.7970    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    1.6500    1.7862    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    1.6500    0.9612    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   11.1251    3.5688    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   11.4198    2.1706    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//    6.7349    7.2073    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//   11.6761    2.9548    0.0000 C   0  0  0  0  0  0  0  0  0  0  0  0
//  1 37  2  0  0  0  0
//  2 39  2  0  0  0  0
//  3 43  2  0  0  0  0
//  4 51  1  0  0  0  0
//  4 54  1  0  0  0  0
//  5 49  2  0  0  0  0
//  6 52  2  0  0  0  0
//  7 56  2  0  0  0  0
//  8 64  2  0  0  0  0
//  9 65  2  0  0  0  0
// 10 68  2  0  0  0  0
// 11 73  2  0  0  0  0
// 12 74  2  0  0  0  0
// 13 80  1  0  0  0  0
// 14 91  1  0  0  0  0
// 15 33  1  0  0  0  0
// 15 36  1  0  0  0  0
// 15 37  1  0  0  0  0
// 38 16  1  6  0  0  0
// 16 43  1  0  0  0  0
// 17 19  1  0  0  0  0
// 17 39  1  0  0  0  0
// 42 18  1  6  0  0  0
// 18 49  1  0  0  0  0
// 19 52  1  0  0  0  0
// 20 46  1  0  0  0  0
// 20 57  2  0  0  0  0
// 50 21  1  6  0  0  0
// 21 56  1  0  0  0  0
// 22 53  1  0  0  0  0
// 22 65  1  0  0  0  0
// 59 23  1  1  0  0  0
// 23 64  1  0  0  0  0
// 24 52  1  0  0  0  0
// 55 25  1  1  0  0  0
// 25 74  1  0  0  0  0
// 60 26  1  6  0  0  0
// 26 68  1  0  0  0  0
// 67 27  1  6  0  0  0
// 27 73  1  0  0  0  0
// 28 57  1  0  0  0  0
// 29 57  1  0  0  0  0
// 30 78  1  0  0  0  0
// 30 79  1  0  0  0  0
// 31 77  1  0  0  0  0
// 31 90  1  0  0  0  0
// 32 85  1  0  0  0  0
// 32 90  2  0  0  0  0
// 33 34  1  0  0  0  0
// 33 39  1  6  0  0  0
// 34 35  1  0  0  0  0
// 35 36  1  0  0  0  0
// 37 38  1  0  0  0  0
// 38 40  1  0  0  0  0
// 40 41  1  0  0  0  0
// 41 46  1  0  0  0  0
// 42 43  1  0  0  0  0
// 42 44  1  0  0  0  0
// 44 45  1  0  0  0  0
// 45 47  1  0  0  0  0
// 45 48  1  0  0  0  0
// 49 50  1  0  0  0  0
// 50 51  1  0  0  0  0
// 53 58  1  0  0  0  0
// 53 64  1  6  0  0  0
// 54 69  1  0  0  0  0
// 54 70  1  0  0  0  0
// 54 71  1  0  0  0  0
// 55 56  1  0  0  0  0
// 55 62  1  0  0  0  0
// 58 61  1  0  0  0  0
// 59 66  1  0  0  0  0
// 59 68  1  0  0  0  0
// 60 63  1  0  0  0  0
// 60 73  1  0  0  0  0
// 61 65  1  0  0  0  0
// 62 75  1  0  0  0  0
// 63 72  1  0  0  0  0
// 66 77  1  0  0  0  0
// 67 74  1  0  0  0  0
// 67 80  1  0  0  0  0
// 72 76  1  0  0  0  0
// 72 78  2  0  0  0  0
// 75 82  2  0  0  0  0
// 75 83  1  0  0  0  0
// 76 79  1  0  0  0  0
// 76 81  2  0  0  0  0
// 77 85  2  0  0  0  0
// 79 84  2  0  0  0  0
// 81 86  1  0  0  0  0
// 82 88  1  0  0  0  0
// 83 89  2  0  0  0  0
// 84 87  1  0  0  0  0
// 86 87  2  0  0  0  0
// 88 91  2  0  0  0  0
// 89 91  1  0  0  0  0
//M  END
//> <DRUGBANK_ID>
//DB00014
//
//> <IUPAC_NAME>
//(2S)-1-[(2S)-2-[(2S)-2-[(2R)-3-(tert-butoxy)-2-[(2S)-2-[(2S)-3-hydroxy-2-[(2S)-2-[(2S)-3-(1H-imidazol-5-yl)-2-{[(2S)-5-oxopyrrolidin-2-yl]formamido}propanamido]-3-(1H-indol-3-yl)propanamido]propanamido]-3-(4-hydroxyphenyl)propanamido]propanamido]-4-methylpentanamido]-5-[(diaminomethylidene)amino]pentanoyl]-N-(carbamoylamino)pyrrolidine-2-carboxamide
//
//> <INCHI_IDENTIFIER>
//InChI=1S/C59H84N18O14/c1-31(2)22-40(49(82)68-39(12-8-20-64-57(60)61)56(89)77-21-9-13-46(77)55(88)75-76-58(62)90)69-54(87)45(29-91-59(3,4)5)74-50(83)41(23-32-14-16-35(79)17-15-32)70-53(86)44(28-78)73-51(84)42(24-33-26-65-37-11-7-6-10-36(33)37)71-52(85)43(25-34-27-63-30-66-34)72-48(81)38-18-19-47(80)67-38/h6-7,10-11,14-17,26-27,30-31,38-46,65,78-79H,8-9,12-13,18-25,28-29H2,1-5H3,(H,63,66)(H,67,80)(H,68,82)(H,69,87)(H,70,86)(H,71,85)(H,72,81)(H,73,84)(H,74,83)(H,75,88)(H4,60,61,64)(H3,62,76,90)/t38-,39-,40-,41-,42-,43-,44-,45+,46-/m0/s1
//
//
//> <SMILES>
//CC(C)C[C@H](NC(=O)[C@@H](COC(C)(C)C)NC(=O)[C@H](CC1=CC=C(O)C=C1)NC(=O)[C@H](CO)NC(=O)[C@H](CC1=CNC2=CC=CC=C12)NC(=O)[C@H](CC1=CN=CN1)NC(=O)[C@@H]1CCC(=O)N1)C(=O)N[C@@H](CCCN=C(N)N)C(=O)N1CCC[C@H]1C(=O)NNC(N)=O
//
//$$$$
//";
//			Dictionary<string, SDTagOptions> sdTags = new Dictionary<string, SDTagOptions>();
//			sdTags.Add("DRUGBANK_ID", SDTagOptions.DEPOSITOR_SUBSTANCE_REGID);
//			sdTags.Add("INCHI_IDENTIFIER", SDTagOptions.DEPOSITOR_SUBSTANCE_INCHI);
//			sdTags.Add("SMILES", SDTagOptions.DEPOSITOR_SUBSTANCE_SMILES);
//			sdTags.Add("IUPAC_NAME", SDTagOptions.DEPOSITOR_SUBSTANCE_SYNONYM);

			
//			//ChemSpider.CVSP.ObjectModel.Logger logger = ChemSpider.CVSP.ObjectModel.Logger.CreateTraceSources(null, null, null);
//			SubstanceRecord substance = new SubstanceRecord(sdf,1,null);
//			substance.Initialize(sdTags, true, true, false, false, true,true,Resources.Vendor.Indigo);

//			Assert.IsTrue(substance.ValidationIssues.Count() == 1);

//		}

//	}
//}