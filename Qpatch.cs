using System;
using System.Collections.Generic;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using QModManager.API.ModLoading;
using SMLHelper.V2.Crafting;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Utility;
using UnityEngine;

namespace MoreIngotsBz.craftable
{
    // Token: 0x02000002 RID: 2
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
	public class PluginInfo : BaseUnityPlugin
	{ 
        public const String PLUGIN_GUID = "Bz.MoreIngots";
        public const String PLUGIN_NAME = "MoreIngotsBZ";
        public const String PLUGIN_VERSION = "1.2.0";
    

		public void Start()
		{
			TechType techType = TechTypeHandler.AddTechType("MIGold", "Gold Ingot", "Au. Compressed gold. Added by the MoreIngots mod", PluginInfo.GetSprite("MIGold"));
			RecipeData recipeData = new RecipeData();
			TechType techType2 = TechTypeHandler.AddTechType("MIDiamond", "Compressed Diamond", "C. Compressed diamond. Added by the MoreIngots mod", PluginInfo.GetSprite("MIDiamond"));
			RecipeData recipeData2 = new RecipeData();
			TechType techType3 = TechTypeHandler.AddTechType("MILithium", "Lithium Ingot", "Li. Compressed lithium. Added by the MoreIngots mod", PluginInfo.GetSprite("MILithum"));
			RecipeData recipeData3 = new RecipeData();
			TechType techType4 = TechTypeHandler.AddTechType("MICopper", "Copper Ingot", "Cu. Compressed copper. Added by the MoreIngots mod", PluginInfo.GetSprite("MICopper"));
			RecipeData recipeData4 = new RecipeData();
			TechType techType5 = TechTypeHandler.AddTechType("MILead", "Lead Ingot", "Pb. Compressed lead. Added by the MoreIngots mod", PluginInfo.GetSprite("MILead"));
			RecipeData recipeData5 = new RecipeData();
			TechType techType6 = TechTypeHandler.AddTechType("MISilver", "Silver Ingot", "Ag. Compressed silver. Added by the MoreIngots mod", PluginInfo.GetSprite("MISilver"));
			RecipeData recipeData6 = new RecipeData();
			TechType techType7 = TechTypeHandler.AddTechType("MIMagnetite", "Compressed Magnetite", "Fe3O4. Compressed magnetite. Added by the MoreIngots mod", PluginInfo.GetSprite("MIMagnetite"));
			RecipeData recipeData7 = new RecipeData();
			TechType techType8 = TechTypeHandler.AddTechType("MINickel", "Nickel Ingot", "Ni. Compressed nickel. Added by the MoreIngots mod", PluginInfo.GetSprite("MINickel"));
			RecipeData recipeData8 = new RecipeData();
			TechType techType9 = TechTypeHandler.AddTechType("MIKyanite", "Compressed Kyanite", "Al2SiO5. Compressed kyanite. Added by the MoreIngots mod", PluginInfo.GetSprite("MIKyanite"));
			RecipeData recipeData9 = new RecipeData();
			TechType techType10 = TechTypeHandler.AddTechType("MIRuby", "Compressed Ruby", "Al2O3. Compressed ruby. Added by the MoreIngots mod", PluginInfo.GetSprite("MIRuby"));
			RecipeData recipeData10 = new RecipeData();
			TechType techType11 = TechTypeHandler.AddTechType("MIUraninite", "Compressed Uraninite", "U3O8. Compressed uraninite. Added by the MoreIngots mod", PluginInfo.GetSprite("MIUrninite"));
			RecipeData recipeData11 = new RecipeData();
			TechType techType12 = TechTypeHandler.AddTechType("MIIon", "Ion Ingot ", "I48. Compressed Ion Cubes. Added by the MoreIngots mod", PluginInfo.GetSprite("MIIon"));
			RecipeData recipeData12 = new RecipeData();
			TechType techType13 = TechTypeHandler.AddTechType("MIQuartz", "Compressed Quartz", "SiO4. Compressed quartz. Added by the MoreIngots mod", PluginInfo.GetSprite("MIQuartz"));
			RecipeData recipeData13 = new RecipeData();
			TechType techType14 = TechTypeHandler.AddTechType("MISalt", "Salt Lick", "NaCl. Salt. Added by the MoreIngots mod. (Suggested by Oddwood)", PluginInfo.GetSprite("MISalt"));
			RecipeData recipeData14 = new RecipeData();
			TechType techType15 = TechTypeHandler.AddTechType("MISulphur", "Compressed Sulphur", "S. Compressed Sulphur. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISulphur"));
			RecipeData recipeData15 = new RecipeData();
			TechType techType16 = TechTypeHandler.AddTechType("MICrash", "Compressed Crashpowder", "S. Compressed Crashpowder. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MICrash"));
			RecipeData recipeData16 = new RecipeData();
			TechType techType17 = TechTypeHandler.AddTechType("MIComputerchip", "Packed Computer Chip", "S. Packeded Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIComputerchip"));
			RecipeData recipeData17 = new RecipeData();
			TechType techType18 = TechTypeHandler.AddTechType("MICopperwire", "Packed Copperwire", "S. Packed Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MICopperwire"));
			RecipeData recipeData18 = new RecipeData();
			TechType techType19 = TechTypeHandler.AddTechType("MIWirekit", "Packed Wire Kit", "S. Packed Wire Kit. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIWirekit"));
			RecipeData recipeData19 = new RecipeData();
			TechType techType20 = TechTypeHandler.AddTechType("MIAdvwirekit", "Packed Advanced Wiring Kit", "S. Packed Advanced Wiring Kit. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIAdvwirekit"));
			RecipeData recipeData20 = new RecipeData();
			TechType techType21 = TechTypeHandler.AddTechType("MISGold", "Gold Ingot Stacked ", "Au. Compressed gold. Added by the MoreIngots mod", PluginInfo.GetSprite("MISGold"));
			RecipeData recipeData21 = new RecipeData();
			TechType techType22 = TechTypeHandler.AddTechType("MISDiamond", "Compressed Diamond Stacked", "C. Compressed diamond. Added by the MoreIngots mod", PluginInfo.GetSprite("MISDiamond"));
			RecipeData recipeData22 = new RecipeData();
			TechType techType23 = TechTypeHandler.AddTechType("MISLithium", "Lithium Ingot Stacked", "Li. Compressed lithium. Added by the MoreIngots mod", PluginInfo.GetSprite("MISLithium"));
			RecipeData recipeData23 = new RecipeData();
			TechType techType24 = TechTypeHandler.AddTechType("MISCopper", "Copper Ingot Stacked", "Cu. Compressed copper. Added by the MoreIngots mod", PluginInfo.GetSprite("MISCopper"));
			RecipeData recipeData24 = new RecipeData();
			TechType techType25 = TechTypeHandler.AddTechType("MISLead", "Lead Ingot Stacked", "Pb. Compressed lead. Added by the MoreIngots mod", PluginInfo.GetSprite("MISLead"));
			RecipeData recipeData25 = new RecipeData();
			TechType techType26 = TechTypeHandler.AddTechType("MISSilver", "Silver Ingot Stacked", "Ag. Compressed silver. Added by the MoreIngots mod", PluginInfo.GetSprite("MISSilver"));
			RecipeData recipeData26 = new RecipeData();
			TechType techType27 = TechTypeHandler.AddTechType("MISMagnetite", "Compressed Magnetite Stacked", "Fe3O4. Compressed magnetite. Added by the MoreIngots mod", PluginInfo.GetSprite("MISMagnetite"));
			RecipeData recipeData27 = new RecipeData();
			TechType techType28 = TechTypeHandler.AddTechType("MISNickel", "Nickel Ingot Stacked", "Ni. Compressed nickel. Added by the MoreIngots mod", PluginInfo.GetSprite("MISNickel"));
			RecipeData recipeData28 = new RecipeData();
			TechType techType29 = TechTypeHandler.AddTechType("MISKyanite", "Compressed Kyanite Stacked", "Al2SiO5. Compressed kyanite. Added by the MoreIngots mod", PluginInfo.GetSprite("MISKyanite"));
			RecipeData recipeData29 = new RecipeData();
			TechType techType30 = TechTypeHandler.AddTechType("MISRuby", "Compressed Ruby Stacked", "Al2O3. Compressed ruby. Added by the MoreIngots mod", PluginInfo.GetSprite("MISRuby"));
			RecipeData recipeData30 = new RecipeData();
			TechType techType31 = TechTypeHandler.AddTechType("MISUraninite", "Compressed Uraninite Stacked", "U3O8. Compressed uraninite. Added by the MoreIngots mod", PluginInfo.GetSprite("MISUraninite"));
			RecipeData recipeData31 = new RecipeData();
			TechType techType32 = TechTypeHandler.AddTechType("MISIon", "Ion Ingot Stacked ", "I48. Compressed Ion Cubes. Added by the MoreIngots mod", PluginInfo.GetSprite("MISIon"));
			RecipeData recipeData32 = new RecipeData();
			TechType techType33 = TechTypeHandler.AddTechType("MISQuartz", "Compressed Quartz Stacked", "SiO4. Compressed quartz. Added by the MoreIngots mod", PluginInfo.GetSprite("MISQuartz"));
			RecipeData recipeData33 = new RecipeData();
			TechType techType34 = TechTypeHandler.AddTechType("MISSalt", "Salt Lick Stacked", "NaCl. Salt. Added by the MoreIngots mod. (Suggested by Oddwood)", PluginInfo.GetSprite("MISSalt"));
			RecipeData recipeData34 = new RecipeData();
			TechType techType35 = TechTypeHandler.AddTechType("MISSulphur", "Compressed Sulphur Stacked", "S. Compressed Sulphur. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISSulphur"));
			RecipeData recipeData35 = new RecipeData();
			TechType techType36 = TechTypeHandler.AddTechType("MISCrash", "Compressed Crashpowder Stacked", "S. Compressed Crashpowder. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISCrash"));
			RecipeData recipeData36 = new RecipeData();
			TechType techType37 = TechTypeHandler.AddTechType("MISTitanim", "Stacked Titanium Ingots", "SAu. Stacked Titanium ingots . Added by the MoreIngotsplus mod. (Suggested by Cookie)", PluginInfo.GetSprite("MISTitanium"));
			RecipeData recipeData37 = new RecipeData();
			TechType techType38 = TechTypeHandler.AddTechType("MISComputerchip", "Stacked Computer Chip", "S. Stacked Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISComputerchip"));
			RecipeData recipeData38 = new RecipeData();
			TechType techType39 = TechTypeHandler.AddTechType("MISCopperwire", "stacked Copperwire", "S. Stacked Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISCopperwire"));
			RecipeData recipeData39 = new RecipeData();
			TechType techType40 = TechTypeHandler.AddTechType("MISWirekit", "Stacked Wire Kit", "S. Stacked Wire Kit. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISWirekit"));
			RecipeData recipeData40 = new RecipeData();
			TechType techType41 = TechTypeHandler.AddTechType("MISAdvwirekit", "Stacked Advanced Wiring Kit", "S. Stacked Advanced Wiring Kit. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISAdvwirekit"));
			RecipeData recipeData41 = new RecipeData();
			TechType techType42 = TechTypeHandler.AddTechType("PIGold", "Unpacked Gold Ingot", "Au. Compressed gold. Added by the MoreIngots mod", PluginInfo.GetSprite("PIGold"));
			RecipeData recipeData42 = new RecipeData();
			TechType techType43 = TechTypeHandler.AddTechType("PIDiamond", "Unpacked Compressed Diamond", "C. Compressed diamond. Added by the MoreIngots mod", PluginInfo.GetSprite("PIDiamond"));
			RecipeData recipeData43 = new RecipeData();
			TechType techType44 = TechTypeHandler.AddTechType("PILithium", "Unpacked Lithium Ingot", "Li. Compressed lithium. Added by the MoreIngots mod", PluginInfo.GetSprite("PILithium"));
			RecipeData recipeData44 = new RecipeData();
			TechType techType45 = TechTypeHandler.AddTechType("PICopper", "Unpacked Copper Ingot", "Cu. Compressed copper. Added by the MoreIngots mod", PluginInfo.GetSprite("PICopper"));
			RecipeData recipeData45 = new RecipeData();
			TechType techType46 = TechTypeHandler.AddTechType("PILead", "Unpacked Lead Ingot", "Pb. Compressed lead. Added by the MoreIngots mod", PluginInfo.GetSprite("PILead"));
			RecipeData recipeData46 = new RecipeData();
			TechType techType47 = TechTypeHandler.AddTechType("PISilver", "Unpacked Silver Ingot", "Ag. Compressed silver. Added by the MoreIngots mod", PluginInfo.GetSprite("PISilver"));
			RecipeData recipeData47 = new RecipeData();
			TechType techType48 = TechTypeHandler.AddTechType("PIMagnetite", "Unpacked Compressed Magnetite", "Fe3O4. Compressed magnetite. Added by the MoreIngots mod", PluginInfo.GetSprite("PIMagnetite"));
			RecipeData recipeData48 = new RecipeData();
			TechType techType49 = TechTypeHandler.AddTechType("PINickel", "Unpacked Nickel Ingot", "Ni. Compressed nickel. Added by the MoreIngots mod", PluginInfo.GetSprite("PINickel"));
			RecipeData recipeData49 = new RecipeData();
			TechType techType50 = TechTypeHandler.AddTechType("PIKyanite", "Unpacked Compressed Kyanite", "Al2SiO5. Compressed kyanite. Added by the MoreIngots mod", PluginInfo.GetSprite("PIKyanite"));
			RecipeData recipeData50 = new RecipeData();
			TechType techType51 = TechTypeHandler.AddTechType("PIRuby", "Unpacked Compressed Ruby", "Al2O3. Compressed ruby. Added by the MoreIngots mod", PluginInfo.GetSprite("PIRuby"));
			RecipeData recipeData51 = new RecipeData();
			TechType techType52 = TechTypeHandler.AddTechType("PIUraninite", "Unpacked Compressed Uraninite", "U3O8. Compressed uraninite. Added by the MoreIngots mod", PluginInfo.GetSprite("PIUrninite"));
			RecipeData recipeData52 = new RecipeData();
			TechType techType53 = TechTypeHandler.AddTechType("PIIon", "Unpacked Ion Ingot ", "I48. Compressed Ion Cubes. Added by the MoreIngots mod", PluginInfo.GetSprite("PIIon"));
			RecipeData recipeData53 = new RecipeData();
			TechType techType54 = TechTypeHandler.AddTechType("PIQuartz", "Unpacked Compressed Quartz", "SiO4. Compressed quartz. Added by the MoreIngots mod", PluginInfo.GetSprite("PIQuartz"));
			RecipeData recipeData54 = new RecipeData();
			TechType techType55 = TechTypeHandler.AddTechType("PISalt", "Unpacked Salt Lick", "NaCl. Salt. Added by the MoreIngots mod. (Suggested by Oddwood)", PluginInfo.GetSprite("PISalt"));
			RecipeData recipeData55 = new RecipeData();
			TechType techType56 = TechTypeHandler.AddTechType("PISulphur", "Unpacked Compressed Sulphur", "S. Compressed Sulphur. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PISulphur"));
			RecipeData recipeData56 = new RecipeData();
			TechType techType57 = TechTypeHandler.AddTechType("PICrash", "Unpacked Compressed Crashpowder", "S. Compressed Crashpowder. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PICrash"));
			RecipeData recipeData57 = new RecipeData();
			TechType techType58 = TechTypeHandler.AddTechType("PITitanim", "Unstacked Titanium Ingot", "SAu. Unstacked Titanium Ingot. Added by the MoreIngotsplus mod. (Suggested by Cookie)", PluginInfo.GetSprite("PITitanium"));
			RecipeData recipeData58 = new RecipeData();
			TechType techType59 = TechTypeHandler.AddTechType("PIComputerchip", "Unpacked Computer Chip", "S. Unpackeded Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIComputerchip"));
			RecipeData recipeData59 = new RecipeData();
			TechType techType60 = TechTypeHandler.AddTechType("PICopperwire", "Unpacked Copperwire", "S. Unpacked Copperwire Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PICopperwire"));
			RecipeData recipeData60 = new RecipeData();
			TechType techType61 = TechTypeHandler.AddTechType("PIWirekit", "Unpacked Wire Kit", "S. Unpacked Wire Kit. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIWirekit"));
			RecipeData recipeData61 = new RecipeData();
			TechType techType62 = TechTypeHandler.AddTechType("PIAdvwirekit", "Unpacked Advanced Wiring Kit", "S. Unpacked Advanced Wiring Kit. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIAdvwirekit"));
			RecipeData recipeData62 = new RecipeData();
			TechType techType63 = TechTypeHandler.AddTechType("PISGold", "Unstacked Gold Ingot", "Au. Compressed gold. Added by the MoreIngots mod", PluginInfo.GetSprite("MIGold"));
			RecipeData recipeData63 = new RecipeData();
			TechType techType64 = TechTypeHandler.AddTechType("PISDiamond", "Unstacked Compressed Diamond", "C. Compressed diamond. Added by the MoreIngots mod", PluginInfo.GetSprite("MIDiamond"));
			RecipeData recipeData64 = new RecipeData();
			TechType techType65 = TechTypeHandler.AddTechType("PISLithium", "Unstacked Lithium Ingot", "Li. Compressed lithium. Added by the MoreIngots mod", PluginInfo.GetSprite("MILithum"));
			RecipeData recipeData65 = new RecipeData();
			TechType techType66 = TechTypeHandler.AddTechType("PISCopper", "Unstacked Copper Ingot", "Cu. Compressed copper. Added by the MoreIngots mod", PluginInfo.GetSprite("MICopper"));
			RecipeData recipeData66 = new RecipeData();
			TechType techType67 = TechTypeHandler.AddTechType("PISLead", "Unstacked Lead Ingot", "Pb. Compressed lead. Added by the MoreIngots mod", PluginInfo.GetSprite("MILead"));
			RecipeData recipeData67 = new RecipeData();
			TechType techType68 = TechTypeHandler.AddTechType("PISSilver", "Unstacked Silver Ingot", "Ag. Compressed silver. Added by the MoreIngots mod", PluginInfo.GetSprite("MISilver"));
			RecipeData recipeData68 = new RecipeData();
			TechType techType69 = TechTypeHandler.AddTechType("PISMagnetite", "Unstacked Compressed Magnetite", "Fe3O4. Compressed magnetite. Added by the MoreIngots mod", PluginInfo.GetSprite("MIMagnetite"));
			RecipeData recipeData69 = new RecipeData();
			TechType techType70 = TechTypeHandler.AddTechType("PISNickel", "Unstacked Nickel Ingot", "Ni. Compressed nickel. Added by the MoreIngots mod", PluginInfo.GetSprite("MINickel"));
			RecipeData recipeData70 = new RecipeData();
			TechType techType71 = TechTypeHandler.AddTechType("PISKyanite", "Unstacked Compressed Kyanite", "Al2SiO5. Compressed kyanite. Added by the MoreIngots mod", PluginInfo.GetSprite("MIKyanite"));
			RecipeData recipeData71 = new RecipeData();
			TechType techType72 = TechTypeHandler.AddTechType("PISRuby", "Unstacked Compressed Ruby", "Al2O3. Compressed ruby. Added by the MoreIngots mod", PluginInfo.GetSprite("MIRuby"));
			RecipeData recipeData72 = new RecipeData();
			TechType techType73 = TechTypeHandler.AddTechType("PISUraninite", "Unstacked Compressed Uraninite", "U3O8. Compressed uraninite. Added by the MoreIngots mod", PluginInfo.GetSprite("MIUrninite"));
			RecipeData recipeData73 = new RecipeData();
			TechType techType74 = TechTypeHandler.AddTechType("PISIon", "Unstacked Ion Ingot ", "I48. Compressed Ion Cubes. Added by the MoreIngots mod", PluginInfo.GetSprite("MIIon"));
			RecipeData recipeData74 = new RecipeData();
			TechType techType75 = TechTypeHandler.AddTechType("PISQuartz", "Unstacked Compressed Quartz", "SiO4. Compressed quartz. Added by the MoreIngots mod", PluginInfo.GetSprite("MIQuartz"));
			RecipeData recipeData75 = new RecipeData();
			TechType techType76 = TechTypeHandler.AddTechType("PISSalt", "Unstacked Salt Lick", "NaCl. Salt. Added by the MoreIngots mod. (Suggested by Oddwood)", PluginInfo.GetSprite("MISalt"));
			RecipeData recipeData76 = new RecipeData();
			TechType techType77 = TechTypeHandler.AddTechType("PISSulphur", "Unstacked Compressed Sulphur", "S. Compressed Sulphur. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISulphur"));
			RecipeData recipeData77 = new RecipeData();
			TechType techType78 = TechTypeHandler.AddTechType("PISCrash", "Unstacked Compressed Crashpowder", "S. Compressed Crashpowder. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MICrash"));
			RecipeData recipeData78 = new RecipeData();
			TechType techType79 = TechTypeHandler.AddTechType("PISTitanim", "UnStacked Titanium", "SAu. UnStacked Titanium. Added by the MoreIngotsplus mod. (Suggested by Cookie)", PluginInfo.GetSprite("MITitanim"));
			RecipeData recipeData79 = new RecipeData();
			TechType techType80 = TechTypeHandler.AddTechType("PISComputerchip", "Unstacked Computer Chip", "S. Unstacked Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIComputerchip"));
			RecipeData recipeData80 = new RecipeData();
			TechType techType81 = TechTypeHandler.AddTechType("PISCopperwire", "Unstacked Copperwire", "S. Unstacked Computer Chip. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MICopperwire"));
			RecipeData recipeData81 = new RecipeData();
			TechType techType82 = TechTypeHandler.AddTechType("PISWirekit", "Unstacked Wire Kit", "S. Unstacked Wire Kit. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIWirekit"));
			RecipeData recipeData82 = new RecipeData();
			TechType techType83 = TechTypeHandler.AddTechType("PISAdvwirekit", "Unstacked Advanced Wiring Kit", "S. Unstacked Advanced Wiring Kit. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIAdvwirekit"));
			RecipeData recipeData83 = new RecipeData();
			TechType techType84 = TechTypeHandler.AddTechType("MIWaterPurification Packed", "Packed WaterPurification", "S. Packed WaterPurification. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIBleachjug"));
			RecipeData recipeData84 = new RecipeData();
			TechType techType85 = TechTypeHandler.AddTechType("PIMIWaterPurification", "Unpacked WaterPurification", "S. unpacked WaterPurification. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIBleachjug"));
			RecipeData recipeData85 = new RecipeData();
			TechType techType86 = TechTypeHandler.AddTechType("MISWaterPurification Stacked", "WaterPurification Stacked", "S. WaterPurification Stacked. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISBleachbarrel"));
			RecipeData recipeData86 = new RecipeData();
			TechType techType87 = TechTypeHandler.AddTechType("PISBleachbarrel", "Bleach Unbarreled", "S. Bleach Unbarrel. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIBleachjug"));
			RecipeData recipeData87 = new RecipeData();
			TechType techType88 = TechTypeHandler.AddTechType("MILubricantjug", "Jugged Lubricant", "S. Jugged Lubricant. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MILubricantjug"));
			RecipeData recipeData88 = new RecipeData();
			TechType techType89 = TechTypeHandler.AddTechType("PILubricantjug", "UnJugged Lubricantjug", "S. Unjugged Lubricantjug. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PILubricantjug"));
			RecipeData recipeData89 = new RecipeData();
			TechType techType90 = TechTypeHandler.AddTechType("MISLubricantbarrel", "Lubricant Barreled", "S. Lubricant Barreled. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISLubricantbarrel"));
			RecipeData recipeData90 = new RecipeData();
			TechType techType91 = TechTypeHandler.AddTechType("PISLubricantbarrel", "Lubricant Unbarreled", "S. Lubricant Unbarrel. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MILubricantjug"));
			RecipeData recipeData91 = new RecipeData();
			TechType techType92 = TechTypeHandler.AddTechType("MIPjug", "Jugged Polyaniline", "S. Jugged Polyaniline. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIPjug"));
			RecipeData recipeData92 = new RecipeData();
			TechType techType93 = TechTypeHandler.AddTechType("PIPjug", "UnJugged Polyanilinetjug", "S. Unjugged Polyanilinejug. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIPPjug"));
			RecipeData recipeData93 = new RecipeData();
			TechType techType94 = TechTypeHandler.AddTechType("MISPbarrel", "Polyaniline Barreled", "S. Polyaniline Barreled. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISPbarrel"));
			RecipeData recipeData94 = new RecipeData();
			TechType techType95 = TechTypeHandler.AddTechType("PISPbarrel", "Polyaniline Unbarreled", "S. Polyaniline Unbarrel. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIPjug"));
			RecipeData recipeData95 = new RecipeData();
			TechType techType96 = TechTypeHandler.AddTechType("MIAcidjug", "Jugged Acid", "S. Jugged Acid. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIAcidjug"));
			RecipeData recipeData96 = new RecipeData();
			TechType techType97 = TechTypeHandler.AddTechType("PIAcidjug", "UnJugged Acidjug", "S. Unjugged Acidjug. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIAcidjug"));
			RecipeData recipeData97 = new RecipeData();
			TechType techType98 = TechTypeHandler.AddTechType("MISAcidbarrel", "Acid Barreled", "S. Acid Barreled. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISAcidbarrel"));
			RecipeData recipeData98 = new RecipeData();
			TechType techType99 = TechTypeHandler.AddTechType("PISAcidbarrel", "Acid Unbarreled", "S. Acid Unbarrel. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIAcidjug"));
			RecipeData recipeData99 = new RecipeData();
			TechType techType100 = TechTypeHandler.AddTechType("MIBenzenejug", "Jugged Benzene", "S. Jugged Benzene. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIBenzenejug"));
			RecipeData recipeData100 = new RecipeData();
			TechType techType101 = TechTypeHandler.AddTechType("PIBenzenejug", "UnJugged Benzenejug", "S. Unjugged Benzenejug. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIBenzenejug"));
			RecipeData recipeData101 = new RecipeData();
			TechType techType102 = TechTypeHandler.AddTechType("MISBenzenebarrel", "Benzene Barreled", "S. Benzene Barreled. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISBenzenebarrel"));
			RecipeData recipeData102 = new RecipeData();
			TechType techType103 = TechTypeHandler.AddTechType("PISBenzenebarrel", "Benzene Unbarreled", "S. Benzene Unbarrel. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIBenzenejug"));
			RecipeData recipeData103 = new RecipeData();
			TechType techType104 = TechTypeHandler.AddTechType("MIGallonWater", "Jugged GallonWater", "S. Jugged GallonWater. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIGallonWater"));
			RecipeData recipeData104 = new RecipeData();
			TechType techType105 = TechTypeHandler.AddTechType("PIWaterfromGallon", "UnJugged WaterfromGallon", "S.Unjugged WaterfromGallon. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIWaterfromGallon"));
			RecipeData recipeData105 = new RecipeData();
			TechType techType106 = TechTypeHandler.AddTechType("MIS5GallonWater", "5 Gallon Water ", "S. 5 Gallon Water. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIS5GallonWater"));
			RecipeData recipeData106 = new RecipeData();
			TechType techType107 = TechTypeHandler.AddTechType("PISWaterFrom5Gallon", "Water From 5 Gallon", "S. WaterFrom5Gallon. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIGallonWater"));
			RecipeData recipeData107 = new RecipeData();
			TechType techType108 = TechTypeHandler.AddTechType("MIAerosheet", "packed Aerosheet", "S. packed Aerosheet. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIAerosheet"));
			RecipeData recipeData108 = new RecipeData();
			TechType techType109 = TechTypeHandler.AddTechType("PIAerosheet", "Unpacked Aerosheet", "S.Unpacked Aerosheet. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIAerosheet"));
			RecipeData recipeData109 = new RecipeData();
			TechType techType110 = TechTypeHandler.AddTechType("MISAerosheet", " Stacked Aerosheet ", "S. Stacked Aerosheet. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISAerosheet"));
			RecipeData recipeData110 = new RecipeData();
			TechType techType111 = TechTypeHandler.AddTechType("PISAerosheet", "Unstacked Aerosheet", "S. Unstacked Aerosheet. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIAerosheet"));
			RecipeData recipeData111 = new RecipeData();
			TechType techType112 = TechTypeHandler.AddTechType("MIArmidfiber", "packed Armidfiber", "S. packed Armidfiber. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIArmidfiber"));
			RecipeData recipeData112 = new RecipeData();
			TechType techType113 = TechTypeHandler.AddTechType("PIArmidfiber", "Unpacked Armidfiber", "S. Unpacked Armidfiber.Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIArmidfiber"));
			RecipeData recipeData113 = new RecipeData();
			TechType techType114 = TechTypeHandler.AddTechType("MISArmidfiber", " Stacked Armidfiber ", "S. Stacked Armidfiber. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISArmidfiber"));
			RecipeData recipeData114 = new RecipeData();
			TechType techType115 = TechTypeHandler.AddTechType("PISArmidfiber", "Unstacked Armidfiber", "S. Unstacked Armidfiber. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIArmidfiber"));
			RecipeData recipeData115 = new RecipeData();
			TechType techType116 = TechTypeHandler.AddTechType("MISilicone", "packed Silicone", "S. packed Silicone. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISilicone"));
			RecipeData recipeData116 = new RecipeData();
			TechType techType117 = TechTypeHandler.AddTechType("PISilicone", "Unpacked Silicone", "S. Unpacked Silicone.Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PISilicone"));
			RecipeData recipeData117 = new RecipeData();
			TechType techType118 = TechTypeHandler.AddTechType("MISSilicone", " Stacked Silicone ", "S. Stacked Silicone. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISSilicone"));
			RecipeData recipeData118 = new RecipeData();
			TechType techType119 = TechTypeHandler.AddTechType("PISSilicone", "Unstacked Silicone", "S. Unstacked Silicone. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISilicone"));
			RecipeData recipeData119 = new RecipeData();
			TechType techType120 = TechTypeHandler.AddTechType("MIFibermesh", "packed Fibermesh", "S. packed Fibermesh. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIFibermesh"));
			RecipeData recipeData120 = new RecipeData();
			TechType techType121 = TechTypeHandler.AddTechType("PIFibermesh", "Unpacked Fibermesh", "S. Unpacked Fibermesh.Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIFibermesh"));
			RecipeData recipeData121 = new RecipeData();
			TechType techType122 = TechTypeHandler.AddTechType("MISFibermesh", " Stacked Fibermesh ", "S. Stacked Fibermesh. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISFibermesh"));
			RecipeData recipeData122 = new RecipeData();
			TechType techType123 = TechTypeHandler.AddTechType("PISFibermesh", "Unstacked Fibermesh", "S. Unstacked Fibermesh. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIFibermesh"));
			RecipeData recipeData123 = new RecipeData();
			TechType techType124 = TechTypeHandler.AddTechType("MIGlass", "packed Glass", "S. packed Glass. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIGlass"));
			RecipeData recipeData124 = new RecipeData();
			TechType techType125 = TechTypeHandler.AddTechType("PIGlass", "Unpacked Glass", "S. Unpacked Glass.Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIGlass"));
			RecipeData recipeData125 = new RecipeData();
			TechType techType126 = TechTypeHandler.AddTechType("MISGlass", " Stacked Glass ", "S. Stacked Glass. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISGlass"));
			RecipeData recipeData126 = new RecipeData();
			TechType techType127 = TechTypeHandler.AddTechType("PISGlass", "Unstacked Glass", "S. Unstacked Glass. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIGlass"));
			RecipeData recipeData127 = new RecipeData();
			TechType techType128 = TechTypeHandler.AddTechType("MIEnameled", "packed Enameled Glass", "S. packed Enameled Glass. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIEnameled"));
			RecipeData recipeData128 = new RecipeData();
			TechType techType129 = TechTypeHandler.AddTechType("PIEnameled", "Unpacked Enameled Glass", "S. Unpacked Enameled Glass.Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIEnameled"));
			RecipeData recipeData129 = new RecipeData();
			TechType techType130 = TechTypeHandler.AddTechType("MISEnameled", " Stacked Enameled Glass ", "S. Stacked Enameled Glass. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISEnameled"));
			RecipeData recipeData130 = new RecipeData();
			TechType techType131 = TechTypeHandler.AddTechType("PISEnameled", "Unstacked Enameled Glass", "S. Unstacked Enameled Glass. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIEnameled"));
			RecipeData recipeData131 = new RecipeData();
			TechType techType132 = TechTypeHandler.AddTechType("MIStaker", "packed Staker Tooth", "S. packed Staker Tooth. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIStaker"));
			RecipeData recipeData132 = new RecipeData();
			TechType techType133 = TechTypeHandler.AddTechType("PIStaker", "Unpacked Staker Tooth", "S. Unpacked Staker Tooth.Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIStaker"));
			RecipeData recipeData133 = new RecipeData();
			TechType techType134 = TechTypeHandler.AddTechType("MISStaker", " Stacked Staker Tooth ", "S. Stacked Staker Tooth. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISStaker"));
			RecipeData recipeData134 = new RecipeData();
			TechType techType135 = TechTypeHandler.AddTechType("PISStaker", "Unstacked Staker Tooth", "S. Unstacked Staker Tooth. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIStaker"));
			RecipeData recipeData135 = new RecipeData();
			TechType techType136 = TechTypeHandler.AddTechType("MICoral", "packed CoralChunk", "S. packed CoralChunk . Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MICoral"));
			RecipeData recipeData136 = new RecipeData();
			TechType techType137 = TechTypeHandler.AddTechType("PICoral", "Unpacked CoralChunk", "S. Unpacked CoralChunk.Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PICoral"));
			RecipeData recipeData137 = new RecipeData();
			TechType techType138 = TechTypeHandler.AddTechType("MISCoral", " Stacked CoralChunk ", "S. Stacked CoralChunk. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISCoral"));
			RecipeData recipeData138 = new RecipeData();
			TechType techType139 = TechTypeHandler.AddTechType("PISCoral", "Unstacked CoralChunk", "S. Unstacked CoralChunk. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MICoral"));
			RecipeData recipeData139 = new RecipeData();
			TechType techType140 = TechTypeHandler.AddTechType("MITable", "packed Table Coral", "S. packed Table Coral . Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MITable"));
			RecipeData recipeData140 = new RecipeData();
			TechType techType141 = TechTypeHandler.AddTechType("PITable", "Unpacked Table Coral", "S. Unpacked Table Coral .Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PITable"));
			RecipeData recipeData141 = new RecipeData();
			TechType techType142 = TechTypeHandler.AddTechType("MISTablel", " Stacked Table Coral ", "S. Stacked Table Coral. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISTable"));
			RecipeData recipeData142 = new RecipeData();
			TechType techType143 = TechTypeHandler.AddTechType("PISTable", "Unstacked Table Coral", "S. Unstacked Table Coral. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MITable"));
			RecipeData recipeData143 = new RecipeData();
			TechType techType144 = TechTypeHandler.AddTechType("MICreepp", "packed CreepVinePiece", " S.packed CreepVinePiece.Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MICreepp"));
			RecipeData recipeData144 = new RecipeData();
			TechType techType145 = TechTypeHandler.AddTechType("PICreepp", "Unpacked CreepVinePiece", "S. Unpacked CreepVinePiece.Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PICreepp"));
			RecipeData recipeData145 = new RecipeData();
			TechType techType146 = TechTypeHandler.AddTechType("MISCreepp", " Stacked CreepVinePiece ", "S. Stacked CreepVinePiece. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISCreepp"));
			RecipeData recipeData146 = new RecipeData();
			TechType techType147 = TechTypeHandler.AddTechType("PISCreepp", "Unstacked CreepVinePiece", "S. Unstacked CreepVinePiece. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MICreepp"));
			RecipeData recipeData147 = new RecipeData();
			TechType techType148 = TechTypeHandler.AddTechType("MISeed", "packed Creepvine Seed Cluster", "S.packed Creepvine Seed Cluster.Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISeed"));
			RecipeData recipeData148 = new RecipeData();
			TechType techType149 = TechTypeHandler.AddTechType("PISeed", "Unpacked Creepvine Seed Cluster", "S. Unpacked Creepvine Seed Cluster.Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PISeed"));
			RecipeData recipeData149 = new RecipeData();
			TechType techType150 = TechTypeHandler.AddTechType("MISSeed", " Stacked Creepvine Seed Cluster ", "S. Stacked Creepvine Seed Cluster. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISSeed"));
			RecipeData recipeData150 = new RecipeData();
			TechType techType151 = TechTypeHandler.AddTechType("PISSeed", "Unstacked Creepvine Seed Cluster", "S. Unstacked Creepvine Seed Cluster. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISeed"));
			RecipeData recipeData151 = new RecipeData();
			TechType techType152 = TechTypeHandler.AddTechType("MIDeepLilypad", "packed DeepLilypad Mushroom", "S.packed DeepLilypad.Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIDeepLilypad"));
			RecipeData recipeData152 = new RecipeData();
			TechType techType153 = TechTypeHandler.AddTechType("PIDeepLilypad", "Unpacked DeepLilypad Mushroom", "S. Unpacked DeepLilypad.Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIDeepLilypad"));
			RecipeData recipeData153 = new RecipeData();
			TechType techType154 = TechTypeHandler.AddTechType("MISDeepLilypad", " Stacked DeepLilypad Mushroom ", "S. Stacked DeepLilypad. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISDeepLilypad"));
			RecipeData recipeData154 = new RecipeData();
			TechType techType155 = TechTypeHandler.AddTechType("PISDeepLilypad", "Unstacked DeepLilypad Mushroom", "S. Unstacked DeepLilypad. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIDeepLilypad"));
			RecipeData recipeData155 = new RecipeData();
			TechType techType156 = TechTypeHandler.AddTechType("MIJelly", "packed Jellyshroom", "S.packed Jellyshroom.Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIJelly"));
			RecipeData recipeData156 = new RecipeData();
			TechType techType157 = TechTypeHandler.AddTechType("PIJelly", "Unpacked Jellyshroom", "S. Unpacked Jellyshroom.Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIJelly"));
			RecipeData recipeData157 = new RecipeData();
			TechType techType158 = TechTypeHandler.AddTechType("MISJelly", " Stacked Jellyshroom ", "S. Stacked Jellyshroom. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISJelly"));
			RecipeData recipeData158 = new RecipeData();
			TechType techType159 = TechTypeHandler.AddTechType("PISJelly", "Unstacked Jellyshroom", "S. Unstacked Jellyshroom. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIJelly"));
			RecipeData recipeData159 = new RecipeData();
			TechType techType160 = TechTypeHandler.AddTechType("PIPlasteel", "Unpacked plasteel ingot", "S. Unpacked plasteel ingot.Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIPlasteel"));
			RecipeData recipeData160 = new RecipeData();
			TechType techType161 = TechTypeHandler.AddTechType("MISPlasteel", " Stacked plasteel ingot ", "S. Stacked plasteel ingot. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISPlasteel"));
			RecipeData recipeData161 = new RecipeData();
			TechType techType162 = TechTypeHandler.AddTechType("PISPlasteel", "Unstacked plasteel ingot", "S. Unstacked plasteel ingot. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIPlasteel"));
			RecipeData recipeData162 = new RecipeData();
			TechType techType163 = TechTypeHandler.AddTechType("MISnowstalker", "Packed Snowstalker ingot", "S. Packed Snowstalker ingot. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISnowstalker"));
			RecipeData recipeData163 = new RecipeData();
			TechType techType164 = TechTypeHandler.AddTechType("PISnowstalker", "Unpacked Snowstalker ingot", "S. Unpacked Snowstalker ingot. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PISnowstalker"));
			RecipeData recipeData164 = new RecipeData();
			TechType techType165 = TechTypeHandler.AddTechType("MISSnowstalker", "Stacked Snowstalker ", "S. Stacked Snowstalker . Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISSnowstalker"));
			RecipeData recipeData165 = new RecipeData();
			TechType techType166 = TechTypeHandler.AddTechType("PISSnowstalker", "Unstacked Snowstalker ", "S. Unstacked Snowstalker . Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MISnowstalker"));
			RecipeData recipeData166 = new RecipeData();
			TechType techType167 = TechTypeHandler.AddTechType("MIGenericribbon", "Packed Genericribbon ingot", "S. Packed Genericribbon ingot. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIGenericribbon"));
			RecipeData recipeData167 = new RecipeData();
			TechType techType168 = TechTypeHandler.AddTechType("PIGenericribbon", "Unpacked Genericribbon ingot", "S. Unpacked Genericribbon ingot. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIGenericribbon"));
			RecipeData recipeData168 = new RecipeData();
			TechType techType169 = TechTypeHandler.AddTechType("MISGenericribbon", "Stacked Genericribbon ", "S. Stacked Genericribbon . Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIGenericribbon"));
			RecipeData recipeData169 = new RecipeData();
			TechType techType170 = TechTypeHandler.AddTechType("PISGenericribbon", "Unstacked Genericribbon ", "S. Unstacked Genericribbon . Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIGenericribbon"));
			RecipeData recipeData170 = new RecipeData();
			TechType techType174 = TechTypeHandler.AddTechType("MIBigGallonWater", "Jugged BigGallonWater", "S. Jugged BigGallonWater. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIGallonWater"));
			RecipeData recipeData174 = new RecipeData();
			TechType techType171 = TechTypeHandler.AddTechType("PIBigWaterfromGallon", "UnJugged BigWaterfromGallon", "S.Unjugged BigWaterfromGallon. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("PIWaterfromGallon"));
			RecipeData recipeData171 = new RecipeData();
			TechType techType172 = TechTypeHandler.AddTechType("MISBig5GallonWater", "Big 5 Gallon Water ", "S. Big5GallonWater. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIS5GallonWater"));
			RecipeData recipeData172 = new RecipeData();
			TechType techType173 = TechTypeHandler.AddTechType("PISbigWaterFrom5Gallon", "Water From 5 Gallon", "S. WaterFrom5Gallon. Added by the MoreIngots mod. (Suggested by gnivler)", PluginInfo.GetSprite("MIGallonWater"));
			RecipeData recipeData173 = new RecipeData();
			TechType techType175 = TechTypeHandler.AddTechType("MIFSpores", "Packed Flowering Spores", "S. Packed Flowering Spores. Added by the MoreIngots mod. (Suggested by adamkad1)", PluginInfo.GetSprite("MISpore"));
			RecipeData recipeData175 = new RecipeData();
			TechType techType176 = TechTypeHandler.AddTechType("PIFSpores", "Unpacked Flowering Spores", "S. Unpacked Flowering Spores. Added by the MoreIngots mod. (Suggested by adamkad1)", PluginInfo.GetSprite("PISpore"));
			RecipeData recipeData176 = new RecipeData();
			TechType techType177 = TechTypeHandler.AddTechType("MISFSpores", "Stacked Flowering Spores ", "S. Stacked Flowering Spores . Added by the MoreIngots mod. (Suggested by adamkad1)", PluginInfo.GetSprite("MISSpore"));
			RecipeData recipeData177 = new RecipeData();
			TechType techType178 = TechTypeHandler.AddTechType("PISFSpores", "Unstacked Flowering Spores ", "S. Unstacked Flowering Spores . Added by the MoreIngots mod. (Suggested by adamkad1)", PluginInfo.GetSprite("MISSpore"));
			RecipeData recipeData178 = new RecipeData();
			TechType techType179 = TechTypeHandler.AddTechType("MIPRoot", "Packed Root Pustule", "S. Packed Root Pustule. Added by the MoreIngots mod. (Suggested by adamkad1)", PluginInfo.GetSprite("MIPRoot"));
			RecipeData recipeData179 = new RecipeData();
			TechType techType180 = TechTypeHandler.AddTechType("PIPRoot", "Unpacked Root Pustule", "S. Unpacked Root Pustule. Added by the MoreIngots mod. (Suggested by adamkad1)", PluginInfo.GetSprite("PIPRoot"));
			RecipeData recipeData180 = new RecipeData();
			TechType techType181 = TechTypeHandler.AddTechType("MISPRoot", "Stacked Root Pustule ", "S. Stacked Root Pustule . Added by the MoreIngots mod. (Suggested by adamkad1)", PluginInfo.GetSprite("MISPRoot"));
			RecipeData recipeData181 = new RecipeData();
			TechType techType182 = TechTypeHandler.AddTechType("PISPRoot", "Unstacked Root Pustule ", "S. Unstacked Root Pustule . Added by the MoreIngots mod. (Suggested by adamkad1)", PluginInfo.GetSprite("PISPRoot"));
			RecipeData recipeData182 = new RecipeData();
			TechType techType183 = TechTypeHandler.AddTechType("MISBall", "Packed SnowBalls", "S. Packed SnowBalls. Added by the MoreIngots mod. (Suggested by adamkad1)", PluginInfo.GetSprite("MISBall"));
			RecipeData recipeData183 = new RecipeData();
			TechType techType184 = TechTypeHandler.AddTechType("PISBall", "Unpacked SnowBalls", "S. Unpacked SnowBalls. Added by the MoreIngots mod. (Suggested by adamkad1)", PluginInfo.GetSprite("PISBall"));
			RecipeData recipeData184 = new RecipeData();
			TechType techType185 = TechTypeHandler.AddTechType("MISSBall", "Stacked SnowBalls ", "S. Stacked SnowBalls . Added by the MoreIngots mod. (Suggested by adamkad1)", PluginInfo.GetSprite("MISSBall"));
			RecipeData recipeData185 = new RecipeData();
			TechType techType186 = TechTypeHandler.AddTechType("PISSBall", "Unstacked SnowBalls ", "S. Unstacked SnowBalls . Added by the MoreIngots mod. (Suggested by adamkad1)", PluginInfo.GetSprite("PISSBall"));
			RecipeData recipeData186 = new RecipeData();
			Console.WriteLine("Loading Moreingots");
			Console.WriteLine("Loading Fabricator");
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MI", "MoreIngots", PluginInfo.GetSprite("MI"), new string[]
			{
				"Resources",
				
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "BI", "Hoarder", PluginInfo.GetSprite("BI"), new string[]
			{
				"Resources",
				
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Stacked", "Stacked", PluginInfo.GetSprite("SI"), new string[]
			{
				"Resources",
				"BI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIStacked", "Metal Stacked", PluginInfo.GetSprite("MILithum"), new string[]
			{
				"Resources",
				"BI",
				"Stacked"
			});
			
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "FIStacked", "Food Stacked", PluginInfo.GetSprite("Peeper"), new string[]
			{
				"Resources",
				"BI",
				"Stacked"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NIStacked", "Nature Stacked", PluginInfo.GetSprite("PISulphur"), new string[]
			{
				"Resources",
				"BI",
				"Stacked"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EIStacked", "Energy Stacked", PluginInfo.GetSprite("Battery"), new string[]
			{
				"Resources",
				"BI",
				"Stacked"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CIStacked", "Chemical Stacked", PluginInfo.GetSprite("PIAcidjug"), new string[]
			{
				"Resources",
				"BI",
				"Stacked"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SIStacked", "synthetic Stacked", PluginInfo.GetSprite("PISilicone"), new string[]
			{
				"Resources",
				"BI",
				"Stacked"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "USI", "Unstacked", PluginInfo.GetSprite("USI"), new string[]
			{
				"Resources",
				"BI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIUnstacked", "Metal Unstacked", PluginInfo.GetSprite("MILithum"), new string[]
			{
				"Resources",
				"BI",
				"USI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "FIUnstacked", "Food Unstacked", PluginInfo.GetSprite("Peeper"), new string[]
			{
				"Resources",
				"BI",
				"USI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NIUnstacked", "Nature Unstacked", PluginInfo.GetSprite("PISulphur"), new string[]
			{
				"Resources",
				"BI",
				"USI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EIUnstacked", "Energy Unstacked", PluginInfo.GetSprite("Battery"), new string[]
			{
				"Resources",
				"BI",
				"USI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CIUnstacked", "Chemical Unstacked", PluginInfo.GetSprite("PIAcidjug"), new string[]
			{
				"Resources",
				"BI",
				"USI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SIUnstacked", "synthetic Unstacked", PluginInfo.GetSprite("PISilicone"), new string[]
			{
				"Resources",
				"BI",
				"USI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Craft", "packed", PluginInfo.GetSprite("PI"), new string[]
			{
				"Resources",
				"MI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SICraft", "synthetic Pack", PluginInfo.GetSprite("PISilicone"), new string[]
			{
				"Resources",
				"MI",
				"Craft"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CICraft", "Chemical Pack", PluginInfo.GetSprite("PIAcidjug"), new string[]
			{
				"Resources",
				"MI",
				"Craft"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MICraft", "Metal Pack", PluginInfo.GetSprite("MILithum"), new string[]
			{
				"Resources",
				"MI",
				"Craft"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NICraft", "Nature Pack", PluginInfo.GetSprite("PISulphur"), new string[]
			{
				"Resources",
				"MI",
				"Craft"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "FICraft", "Food Pack", PluginInfo.GetSprite("Peeper"), new string[]
			{
				"Resources",
				"MI",
				"Craft"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EICraft", "Energy Pack", PluginInfo.GetSprite("Battery"), new string[]
			{
				"Resources",
				"MI",
				"Craft"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "UI", "Unpacked", PluginInfo.GetSprite("UI"), new string[]
			{
				"Resources",
				"MI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SICraft", "synthetic Pack", PluginInfo.GetSprite("PISilicone"), new string[]
			{
				"Resources",
				"MI",
				"UI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "FIUnpack", "Food Unpack", PluginInfo.GetSprite("Peeper"), new string[]
			{
				"Resources",
				"MI",
				"UI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIUnpack", "Metal Unpack", PluginInfo.GetSprite("MILithum"), new string[]
			{
				"Resources",
				"MI",
				"UI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "NIUnpack", "Nature Unpack", PluginInfo.GetSprite("PISulphur"), new string[]
			{
				"Resources",
				"MI",
				"UI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "EIUnpack", "Enegry Unpack", PluginInfo.GetSprite("Battery"), new string[]
			{
				"Resources",
				"MI",
				"UI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "CIUnpack", "Chemical Unpack", PluginInfo.GetSprite("PIAcidjug"), new string[]
			{
				"Resources",
				"MI",
				"UI"
			});
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "SIUnpack", "synthetic Unpack", PluginInfo.GetSprite("PISilicone"), new string[]
			{
				"Resources",
				"MI",
				"UI"
			});
			Console.WriteLine("Loaded Fabricator");
			Console.WriteLine("Loading Ingots");
			recipeData = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Gold, 5)
				}
			};
			CraftDataHandler.SetTechData(techType, recipeData);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType, new string[]
			{
				"Resources",
				
				"MI",
				"Craft",
				"EICraft"
			});
			recipeData2 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Diamond, 5)
				}
			};
			CraftDataHandler.SetTechData(techType2, recipeData2);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType2, new string[]
			{   "Resources",
				
				"MI",
				"Craft",
				"NICraft"
			});
			recipeData3 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Lithium, 5)
				}
			};
			CraftDataHandler.SetTechData(techType3, recipeData3);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType3, new string[]
			{
				"Resources",
				
				"MI",
				"Craft",
				"MICraft"
			});
			recipeData124 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Glass, 5)
				}
			};
			CraftDataHandler.SetTechData(techType124, recipeData124);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType124, new string[]
			{
				"Resources",
				
				"MI",
				"Craft",
				"NICraft"
			});
			recipeData175 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.LilyPadResource, 5)
				}
			};
			CraftDataHandler.SetTechData(techType175, recipeData175);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType175, new string[]
			{
				"Resources",
				
				"MI",
				"Craft",
				"NICraft"
			});
			recipeData167 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.GenericRibbon, 5)
				}
			};
			CraftDataHandler.SetTechData(techType167, recipeData167);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType167, new string[]
			{
				"Resources",
				
				"MI",
				"Craft",
				"NICraft"
			});
			recipeData128 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.EnameledGlass, 5)
				}
			};
			CraftDataHandler.SetTechData(techType128, recipeData128);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType128, new string[]
			{
				"Resources",
				
				"MI",
				"Craft",
				"NICraft"
			});

			recipeData140 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.JeweledDiskPiece, 5)
				}
			};
			CraftDataHandler.SetTechData(techType140, recipeData140);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType140, new string[]
			{
				"Resources",
				
				"MI",
				"Craft",
				"NICraft"
			});
			recipeData179 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.KelpRootPustule, 5)
				}
			};
			CraftDataHandler.SetTechData(techType179, recipeData179);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType179, new string[]
			{
				"Resources",

				"MI",
				"Craft",
				"NICraft"
			});
			recipeData183 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.SnowBall, 5)
				}
			};
			CraftDataHandler.SetTechData(techType183, recipeData183);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType183, new string[]
			{
				"Resources",

				"MI",
				"Craft",
				"NICraft"
			});
			recipeData144 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.CreepvinePiece, 5)
				}
			};
			CraftDataHandler.SetTechData(techType144, recipeData144);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType144, new string[]
			{
				"Resources",
				
				"MI",
				"Craft",
				"NICraft"
			});
			recipeData148 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.CreepvineSeedCluster, 5)
				}
			};
			CraftDataHandler.SetTechData(techType148, recipeData148);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType148, new string[]
			{
				"Resources",
				
				"MI",
				"Craft",
				"NICraft"
			});
			recipeData163 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.SnowStalkerFur ,10)
				}
			};
			CraftDataHandler.SetTechData(techType163, recipeData163);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType163, new string[]
			{
				"Resources",
				
				"MI",
				"Craft",
				"NICraft"
			});
			recipeData152 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.DeepLilyShroom, 5)
				}
			};
			CraftDataHandler.SetTechData(techType152, recipeData152);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType152, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"NICraft"
			});
			recipeData156 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.JellyPlant, 5)
				}
			};
			CraftDataHandler.SetTechData(techType156, recipeData156);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType156, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"NICraft"
			});
			recipeData4 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Copper, 5)
				}
			};
			CraftDataHandler.SetTechData(techType4, recipeData4);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType4, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"EICraft"
			});
			recipeData5 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Lead, 5)
				}
			};
			CraftDataHandler.SetTechData(techType5, recipeData5);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType5, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"MICraft"
			});
			recipeData6 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Silver, 5)
				}
			};
			CraftDataHandler.SetTechData(techType6, recipeData6);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType6, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"EICraft"
			});
			recipeData7 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Magnetite, 5)
				}
			};
			CraftDataHandler.SetTechData(techType7, recipeData7);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType7, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"EICraft"
			});
			recipeData8 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Nickel, 5)
				}
			};
			CraftDataHandler.SetTechData(techType8, recipeData8);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType8, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"MICraft"
			});
			recipeData108 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Aerogel, 5)
				}
			};
			CraftDataHandler.SetTechData(techType108, recipeData108);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType108, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"SICraft"
			});
			recipeData112 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.AramidFibers, 5)
				}
			};
			CraftDataHandler.SetTechData(techType112, recipeData112);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType112, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"SICraft"
			});
			recipeData116 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Silicone, 5)
				}
			};
			CraftDataHandler.SetTechData(techType116, recipeData116);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType116, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"SICraft"
			});
			recipeData120 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.FiberMesh, 5)
				}
			};
			CraftDataHandler.SetTechData(techType120, recipeData120);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType120, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"SICraft"
			});
			recipeData9 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Kyanite, 5)
				}
			};
			CraftDataHandler.SetTechData(techType9, recipeData9);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType9, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"NICraft"
			});
			recipeData10 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.AluminumOxide, 5)
				}
			};
			CraftDataHandler.SetTechData(techType10, recipeData10);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType10, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"NICraft"
			});
			recipeData11 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.UraniniteCrystal, 5)
				}
			};
			CraftDataHandler.SetTechData(techType11, recipeData11);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType11, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"EICraft"
			});
			recipeData13 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Quartz, 5)
				}
			};
			CraftDataHandler.SetTechData(techType13, recipeData13);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType13, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"NICraft"
			});
			recipeData14 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Salt, 5)
				}
			};
			CraftDataHandler.SetTechData(techType14, recipeData14);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType14, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"NICraft"
			});
			recipeData15 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Sulphur, 5)
				}
			};
			CraftDataHandler.SetTechData(techType15, recipeData15);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType15, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"NICraft"
			});

			recipeData12 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.PrecursorIonCrystal, 5)
				}
			};
			CraftDataHandler.SetTechData(techType12, recipeData12);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType12, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"EICraft"
			});
			recipeData17 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.ComputerChip, 5)
				}
			};
			CraftDataHandler.SetTechData(techType17, recipeData17);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType17, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"EICraft"
			});
			recipeData18 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.CopperWire, 5)
				}
			};
			CraftDataHandler.SetTechData(techType18, recipeData18);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType18, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"EICraft"
			});
			recipeData19 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.WiringKit, 5)
				}
			};
			CraftDataHandler.SetTechData(techType19, recipeData19);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType19, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"EICraft"
			});
			recipeData20 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.AdvancedWiringKit, 5)
				}
			};
			CraftDataHandler.SetTechData(techType20, recipeData20);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType20, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"EICraft"
			});
			recipeData84 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.WaterPurificationTablet, 5)
				}
			};
			CraftDataHandler.SetTechData(techType84, recipeData84);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType84, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"CICraft"
			});
			recipeData88 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Lubricant, 5)
				}
			};
			CraftDataHandler.SetTechData(techType88, recipeData88);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType88, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"CICraft"
			});
			recipeData92 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Polyaniline, 5)
				}
			};
			CraftDataHandler.SetTechData(techType92, recipeData92);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType92, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"CICraft"
			});
			recipeData96 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.HydrochloricAcid, 5)
				}
			};
			CraftDataHandler.SetTechData(techType96, recipeData96);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType96, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"CICraft"
			});
			recipeData100 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Benzene, 5)
				}
			};
			CraftDataHandler.SetTechData(techType100, recipeData100);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType100, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"CICraft"
			});
			recipeData104 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.FilteredWater, 5)
				}
			};
			CraftDataHandler.SetTechData(techType104, recipeData104);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType104, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"FICraft"
			});
			recipeData174 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.BigFilteredWater, 5)
				}
			};
			CraftDataHandler.SetTechData(techType174, recipeData174);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType174, new string[]
			{"Resources",
				
				"MI",
				"Craft",
				"FICraft"
			});
			Console.WriteLine("Ingots Loaded");
			Console.WriteLine("Stacked Loading");
			recipeData21 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType, 5)
				}
			};
			CraftDataHandler.SetTechData(techType21, recipeData21);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType21, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"EIStacked"
			});
			recipeData22 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType2, 5)
				}
			};
			CraftDataHandler.SetTechData(techType22, recipeData22);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType22, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData185 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType179, 5)
				}
			};
			CraftDataHandler.SetTechData(techType185, recipeData185);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType185, new string[]
			{"Resources",

				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData185 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType183, 5)
				}
			};
			CraftDataHandler.SetTechData(techType185, recipeData185);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType185, new string[]
			{"Resources",

				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData181 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType179, 5)
				}
			};
			CraftDataHandler.SetTechData(techType181, recipeData181);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType181, new string[]
			{"Resources",

				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData169 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType167, 5)
				}
			};
			CraftDataHandler.SetTechData(techType169, recipeData169);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType169, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData177 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType175, 5)
				}
			};
			CraftDataHandler.SetTechData(techType177, recipeData177);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType177, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData110 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType108, 5)
				}
			};
			CraftDataHandler.SetTechData(techType110, recipeData110);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType110, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"SIStacked"
			});
			recipeData126 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType124, 5)
				}
			};
			CraftDataHandler.SetTechData(techType126, recipeData126);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType126, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData161 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.PlasteelIngot, 5)
				}
			};
			CraftDataHandler.SetTechData(techType161, recipeData161);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType161, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"MIStacked"
			});
			recipeData130 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType128, 5)
				}
			};
			CraftDataHandler.SetTechData(techType130, recipeData130);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType130, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData134 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType132, 5)
				}
			};
			CraftDataHandler.SetTechData(techType134, recipeData134);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType134, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});

			recipeData142 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType140, 5)
				}
			};
			CraftDataHandler.SetTechData(techType142, recipeData142);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType142, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData146 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType144, 5)
				}
			};
			CraftDataHandler.SetTechData(techType146, recipeData146);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType146, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData150 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType148, 5)
				}
			};
			CraftDataHandler.SetTechData(techType150, recipeData150);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType150, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData154 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType152, 5)
				}
			};
			CraftDataHandler.SetTechData(techType154, recipeData154);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType154, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData158 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType156, 5)
				}
			};
			CraftDataHandler.SetTechData(techType158, recipeData158);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType158, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData114 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType112, 5)
				}
			};
			CraftDataHandler.SetTechData(techType114, recipeData114);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType110, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"SIStacked"
			});
			recipeData26 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType116, 5)
				}
			};
			CraftDataHandler.SetTechData(techType118, recipeData26);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType118, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"SIStacked"
			});
			recipeData122 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType120, 5)
				}
			};
			CraftDataHandler.SetTechData(techType122, recipeData122);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType122, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"SIStacked"
			});
			recipeData23 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType3, 5)
				}
			};
			CraftDataHandler.SetTechData(techType23, recipeData23);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType23, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"MIStacked"
			});
			recipeData24 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType4, 5)
				}
			};
			CraftDataHandler.SetTechData(techType24, recipeData24);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType24, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"EIStacked"
			});
			recipeData25 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType5, 5)
				}
			};
			CraftDataHandler.SetTechData(techType25, recipeData25);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType25, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"MIStacked"
			});
			recipeData26 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType6, 5)
				}
			};
			CraftDataHandler.SetTechData(techType26, recipeData26);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType26, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"EIStacked"
			});
			recipeData27 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType7, 5)
				}
			};
			CraftDataHandler.SetTechData(techType27, recipeData27);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType27, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"EIStacked"
			});
			recipeData28 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType8, 5)
				}
			};
			CraftDataHandler.SetTechData(techType28, recipeData28);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType28, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"MIStacked"
			});
			recipeData106 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType104, 5)
				}
			};
			CraftDataHandler.SetTechData(techType106, recipeData106);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType106, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"FIStacked"
			});
			recipeData29 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType9, 5)
				}
			};
			CraftDataHandler.SetTechData(techType29, recipeData29);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType29, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData30 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
			   {
				new Ingredient(techType10, 5)
			   }
			};
			CraftDataHandler.SetTechData(techType30, recipeData30);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType30, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData31 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType11, 5)
				}
			};
			CraftDataHandler.SetTechData(techType31, recipeData31);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType31, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"EIStacked"
			});
			recipeData33 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType13, 5)
				}
			};
			CraftDataHandler.SetTechData(techType33, recipeData33);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType33, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData34 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType14, 5)
				}
			};
			CraftDataHandler.SetTechData(techType34, recipeData34);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType34, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData35 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType15, 5)
				}
			};
			CraftDataHandler.SetTechData(techType35, recipeData35);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType35, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});

			recipeData32 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType12, 5)
				}
			};
			CraftDataHandler.SetTechData(techType32, recipeData32);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType32, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"EIStacked"
			});
			recipeData37 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.TitaniumIngot, 5)
				}
			};
			CraftDataHandler.SetTechData(techType37, recipeData37);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType37, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"MIStacked"
			});
			recipeData38 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType17, 5)
				}
			};
			CraftDataHandler.SetTechData(techType38, recipeData38);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType38, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"EIStacked"
			});
			recipeData39 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
			   {
				new Ingredient(techType18, 5)
			   }
			};
			CraftDataHandler.SetTechData(techType39, recipeData39);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType39, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"EIStacked"
			});
			recipeData40 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType19, 5)
				}
			};
			CraftDataHandler.SetTechData(techType40, recipeData40);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType40, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"EIStacked"
			});
			recipeData165 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType163, 5)
				}
			};
			CraftDataHandler.SetTechData(techType165, recipeData165);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType165, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"NIStacked"
			});
			recipeData41 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType20, 5)
				}
			};
			CraftDataHandler.SetTechData(techType41, recipeData41);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType41, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"EIStacked"
			});
			recipeData86 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType84, 5)
				}
			};
			CraftDataHandler.SetTechData(techType86, recipeData86);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType86, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"CIStacked"
			});
			recipeData94 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType92, 5)
				}
			};
			CraftDataHandler.SetTechData(techType94, recipeData94);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType94, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"CIStacked"
			});
			recipeData98 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType96, 5)
				}
			};
			CraftDataHandler.SetTechData(techType98, recipeData98);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType98, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"CIStacked"
			});
			recipeData102 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType100, 5)
				}
			};
			CraftDataHandler.SetTechData(techType102, recipeData102);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType102, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"CIStacked"
			});
			recipeData102 = new RecipeData
			{
				craftAmount = 1,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType88, 5)
				}
			};
			CraftDataHandler.SetTechData(techType90, recipeData102);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType90, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"CIStacked"
			});
			Console.WriteLine("Stacked Loaded");
			Console.WriteLine("Unpacked Loading");
			recipeData42 = new RecipeData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.Gold,
					TechType.Gold,
					TechType.Gold,
					TechType.Gold,
					TechType.Gold
					
				}
			};
			CraftDataHandler.SetTechData(techType42, recipeData42);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType42, new string[]
			{"Resources",
				
				"MI",
				"UI",
				"EIUnpack"
			});
			recipeData43 = new RecipeData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType2, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.Diamond,
					TechType.Diamond,
					TechType.Diamond,
					TechType.Diamond,
					TechType.Diamond
					
				}
			};
			CraftDataHandler.SetTechData(techType43, recipeData43);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType43, new string[]
			{"Resources",
				
				"MI",
				"UI",
				"NIUnpack"
			});
			recipeData184 = new RecipeData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType183, 1)
				},
				LinkedItems = new List<TechType>
				{ TechType.SnowBall, TechType.SnowBall, TechType.SnowBall, TechType.SnowBall, TechType.SnowBall }
			};
			recipeData180 = new RecipeData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType179, 1)
				},
				LinkedItems = new List<TechType>
				{ TechType.KelpRootPustule, TechType.KelpRootPustule, TechType.KelpRootPustule, TechType.KelpRootPustule, TechType.KelpRootPustule }
			};
			CraftDataHandler.SetTechData(techType180, recipeData180);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType180, new string[]
			{"Resources",

				"MI",
				"UI",
				"NIUnpack"
			});
			recipeData176 = new RecipeData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType175, 1)
				},
				LinkedItems = new List<TechType>
				{ TechType.LilyPadResource, TechType.LilyPadResource, TechType.LilyPadResource, TechType.LilyPadResource, TechType.LilyPadResource }
			};
			CraftDataHandler.SetTechData(techType176, recipeData176);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType176, new string[]
			{"Resources",
				
				"MI",
				"UI",
				"NIUnpack"
			});
			recipeData168 = new RecipeData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType167, 1)
				},
				LinkedItems = new List<TechType>
				{
					(TechType)3079,
					(TechType)3079,
					(TechType)3079,
					(TechType)3079,
					(TechType)3079
					
				}
			};
			CraftDataHandler.SetTechData(techType168, recipeData168);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType168, new string[]
			{"Resources",
				
				"MI",
				"UI",
				"NIUnpack"
			});
			recipeData160 = new RecipeData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.PlasteelIngot, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.TitaniumIngot,
					TechType.Lithium,
					TechType.Lithium
				}
			};
			CraftDataHandler.SetTechData(techType160, recipeData160);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType160, new string[]
			{"Resources",
				
				"MI",
				"UI",
				"MIUnpack"
			});
			recipeData105 = new RecipeData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType104, 1)
				},
				LinkedItems = new List<TechType>
				{ TechType.FilteredWater, TechType.FilteredWater, TechType.FilteredWater, TechType.FilteredWater, TechType.FilteredWater }
			};
			CraftDataHandler.SetTechData(techType105, recipeData105);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType105, new string[]
			{"Resources",
				
				"MI",
				"UI",
				"FIUnpack"
			});
			recipeData171 = new RecipeData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType174, 1)
				},
				LinkedItems = new List<TechType>
				{ TechType.BigFilteredWater, TechType.BigFilteredWater, TechType.BigFilteredWater, TechType.BigFilteredWater, TechType.BigFilteredWater }
			};
			CraftDataHandler.SetTechData(techType171, recipeData171);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType171, new string[]
			{
				"Resources",
				
				"MI",
				"UI",
				"FIUnpack"
			});
			recipeData172 = new RecipeData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType174, 5)
				},

			};
			CraftDataHandler.SetTechData(techType172, recipeData172);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType172, new string[]
			{"Resources",
				
				"BI",
				"Stacked",
				"FIStacked"
			});
			recipeData125 = new RecipeData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType124, 1)
				},
				LinkedItems = new List<TechType>
				{ TechType.Glass, TechType.Glass, TechType.Glass, TechType.Glass, TechType.Glass }
			};
			CraftDataHandler.SetTechData(techType125, recipeData125);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType125, new string[]
			{"Resources",
				
				"MI",
				"UI",
				"NIUnpack"
			});
			recipeData129 = new RecipeData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType128, 1)
				},
				LinkedItems = new List<TechType>
				{ TechType.EnameledGlass, TechType.EnameledGlass, TechType.EnameledGlass, TechType.EnameledGlass, TechType.EnameledGlass }
			};
			CraftDataHandler.SetTechData(techType129, recipeData129);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType129, new string[]
			{"Resources",
				
				"MI",
				"UI",
				"NIUnpack"
			});

			recipeData164 = new RecipeData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType163, 1)
				},
				LinkedItems = new List<TechType>
				{(TechType) 3543,(TechType) 3543,(TechType) 3543,(TechType) 3543,(TechType) 3543 }
			};
			CraftDataHandler.SetTechData(techType164, recipeData164);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType164, new string[]
			{"Resources",
				
				"MI",
				"UI",
				"NIUnpack"
			});

			

				recipeData141 = new RecipeData
				{
					craftAmount = 0,
					Ingredients = new List<Ingredient>
				{
					new Ingredient(techType140, 1)
				},
					LinkedItems = new List<TechType>
				  { TechType.JeweledDiskPiece, TechType.JeweledDiskPiece, TechType.JeweledDiskPiece, TechType.JeweledDiskPiece, TechType.JeweledDiskPiece }


				};
			
			
			

			CraftDataHandler.SetTechData(techType141, recipeData141);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType141, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"NIUnpack"
					});
					recipeData145 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType144, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.CreepvinePiece, TechType.CreepvinePiece, TechType.CreepvinePiece, TechType.CreepvinePiece, TechType.CreepvinePiece }
					};
					CraftDataHandler.SetTechData(techType145, recipeData145);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType145, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"NIUnpack"
					});
					recipeData149 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType148, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.CreepvineSeedCluster, TechType.CreepvineSeedCluster, TechType.CreepvineSeedCluster, TechType.CreepvineSeedCluster, TechType.CreepvineSeedCluster }
					};
					CraftDataHandler.SetTechData(techType149, recipeData149);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType149, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"NIUnpack"
					});
					recipeData153 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType152, 1)
				},
						LinkedItems = new List<TechType>
				{(TechType) 3107,(TechType) 3107,(TechType) 3107,(TechType) 3107,(TechType) 3107 }
					};
					CraftDataHandler.SetTechData(techType153, recipeData153);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType153, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"NIUnpack"
					});
					recipeData157 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType156, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.JellyPlant, TechType.JellyPlant, TechType.JellyPlant, TechType.JellyPlant, TechType.JellyPlant }
					};
					CraftDataHandler.SetTechData(techType157, recipeData157);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType157, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"NIUnpack"
					});
					recipeData44 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType3, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.Lithium, TechType.Lithium, TechType.Lithium, TechType.Lithium, TechType.Lithium }
					};
					CraftDataHandler.SetTechData(techType44, recipeData44);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType44, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"MIUnpack"
					});
					recipeData109 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType108, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.Aerogel, TechType.Aerogel, TechType.Aerogel, TechType.Aerogel, TechType.Aerogel }
					};
					CraftDataHandler.SetTechData(techType109, recipeData109);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType109, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"SIUnpack"
					});
					recipeData113 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType112, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.AramidFibers, TechType.AramidFibers, TechType.AramidFibers, TechType.AramidFibers, TechType.AramidFibers }
					};
					CraftDataHandler.SetTechData(techType113, recipeData113);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType113, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"SIUnpack"
					});
					recipeData117 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType116, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.Silicone, TechType.Silicone, TechType.Silicone, TechType.Silicone, TechType.Silicone }
					};
					CraftDataHandler.SetTechData(techType117, recipeData117);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType117, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"SIUnpack"
					});
					recipeData121 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType120, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.FiberMesh, TechType.FiberMesh, TechType.FiberMesh, TechType.FiberMesh, TechType.FiberMesh }
					};
					CraftDataHandler.SetTechData(techType121, recipeData121);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType121, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"SIUnpack"
					});
					recipeData45 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType4, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.Copper, TechType.Copper, TechType.Copper, TechType.Copper, TechType.Copper }
					};
					CraftDataHandler.SetTechData(techType45, recipeData45);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType45, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"EIUnpack"
					});
					recipeData46 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType5, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.Lead, TechType.Lead, TechType.Lead, TechType.Lead, TechType.Lead }
					};
					CraftDataHandler.SetTechData(techType46, recipeData46);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType46, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"MIUnpack"
					});
					recipeData47 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType6, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.Silver, TechType.Silver, TechType.Silver, TechType.Silver, TechType.Silver }
					};
					CraftDataHandler.SetTechData(techType47, recipeData47);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType47, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"EIUnpack"
					});
					recipeData48 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType7, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.Magnetite, TechType.Magnetite, TechType.Magnetite, TechType.Magnetite, TechType.Magnetite }
					};
					CraftDataHandler.SetTechData(techType48, recipeData48);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType48, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"EIUnpack"
					});
					recipeData49 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType8, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.Nickel, TechType.Nickel, TechType.Nickel, TechType.Nickel, TechType.Nickel }
					};
					CraftDataHandler.SetTechData(techType49, recipeData49);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType49, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"MIUnpack"
					});
					recipeData50 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType9, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.Kyanite, TechType.Kyanite, TechType.Kyanite, TechType.Kyanite, TechType.Kyanite }
					};
					CraftDataHandler.SetTechData(techType50, recipeData50);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType50, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"NIUnpack"
					});
					recipeData51 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType10, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.AluminumOxide, TechType.AluminumOxide, TechType.AluminumOxide, TechType.AluminumOxide, TechType.AluminumOxide }
					};
					CraftDataHandler.SetTechData(techType51, recipeData51);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType51, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"NIUnpack"
					});
					recipeData52 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType11, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.UraniniteCrystal, TechType.UraniniteCrystal, TechType.UraniniteCrystal, TechType.UraniniteCrystal, TechType.UraniniteCrystal }
					};
					CraftDataHandler.SetTechData(techType52, recipeData52);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType52, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"EIUnpack"
					});
					recipeData53 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType12, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.PrecursorIonCrystal, TechType.PrecursorIonCrystal, TechType.PrecursorIonCrystal, TechType.PrecursorIonCrystal, TechType.PrecursorIonCrystal }
					};
					CraftDataHandler.SetTechData(techType53, recipeData53);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType53, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"EIUnpack"
					});
					recipeData54 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType13, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.Quartz, TechType.Quartz, TechType.Quartz, TechType.Quartz, TechType.Quartz }
					};
					CraftDataHandler.SetTechData(techType54, recipeData54);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType54, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"NIUnpack"
					});
					recipeData55 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType14, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.Salt, TechType.Salt, TechType.Salt, TechType.Salt, TechType.Salt }
					};
					CraftDataHandler.SetTechData(techType55, recipeData55);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType55, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"NIUnpack"
					});
					recipeData56 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType15, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.Sulphur, TechType.Sulphur, TechType.Sulphur, TechType.Sulphur, TechType.Sulphur }
					};
					CraftDataHandler.SetTechData(techType56, recipeData56);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType56, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"NIUnpack"
					});

					recipeData58 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.TitaniumIngot, 1)
				},
						LinkedItems = new List<TechType>
				{
					TechType.Titanium,
					TechType.Titanium,
					TechType.Titanium,
					TechType.Titanium,
					TechType.Titanium
				}
					};
					CraftDataHandler.SetTechData(techType58, recipeData58);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType58, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"MIUnpack"
					});
					recipeData85 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType84, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.WaterPurificationTablet, TechType.WaterPurificationTablet, TechType.WaterPurificationTablet, TechType.WaterPurificationTablet, TechType.WaterPurificationTablet }
					};
					CraftDataHandler.SetTechData(techType85, recipeData85);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType85, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"CIUnpack"
					});
					recipeData97 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType96, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.HydrochloricAcid, TechType.HydrochloricAcid, TechType.HydrochloricAcid, TechType.HydrochloricAcid, TechType.HydrochloricAcid }
					};
					CraftDataHandler.SetTechData(techType97, recipeData97);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType97, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"CIUnpack"
					});
					recipeData101 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType100, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.Benzene, TechType.Benzene, TechType.Benzene, TechType.Benzene, TechType.Benzene }
					};
					CraftDataHandler.SetTechData(techType101, recipeData101);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType101, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"CIUnpack"
					});
					recipeData93 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType92, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.Polyaniline, TechType.Polyaniline, TechType.Polyaniline, TechType.Polyaniline, TechType.Polyaniline }
					};
					CraftDataHandler.SetTechData(techType93, recipeData93);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType93, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"CIUnpack"
					});
					recipeData89 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType88, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.Lubricant, TechType.Lubricant, TechType.Lubricant, TechType.Lubricant, TechType.Lubricant }
					};
					CraftDataHandler.SetTechData(techType89, recipeData89);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType89, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"CIUnpack"
					});
					recipeData59 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType17, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.ComputerChip, TechType.ComputerChip, TechType.ComputerChip, TechType.ComputerChip, TechType.ComputerChip }
					};
					CraftDataHandler.SetTechData(techType59, recipeData59);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType59, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"EIUnpack"
					});
					recipeData60 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType18, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.CopperWire, TechType.CopperWire, TechType.CopperWire, TechType.CopperWire, TechType.CopperWire }
					};
					CraftDataHandler.SetTechData(techType60, recipeData60);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType60, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"EIUnpack"
					});
					recipeData61 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType19, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.WiringKit, TechType.WiringKit, TechType.WiringKit, TechType.WiringKit, TechType.WiringKit }
					};
					CraftDataHandler.SetTechData(techType61, recipeData61);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType61, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"EIUnpack"
					});
					recipeData62 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType20, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.AdvancedWiringKit, TechType.AdvancedWiringKit, TechType.AdvancedWiringKit, TechType.AdvancedWiringKit, TechType.AdvancedWiringKit }
					};
					CraftDataHandler.SetTechData(techType62, recipeData62);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType62, new string[]
					{"Resources",
				
				"MI",
				"UI",
				"EIUnpack"
					});
					Console.WriteLine("Unpacked Loaded");
					Console.WriteLine("Unstacked Loading");
					recipeData63 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType21, 1)
				},
						LinkedItems = new List<TechType>
				{
					techType,
					techType,
					techType,
					techType,
					techType
					
				}
					};
					CraftDataHandler.SetTechData(techType63, recipeData63);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType63, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"EIUnstacked"
					});
					recipeData64 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType22, 1)
				},
						LinkedItems = new List<TechType>
				{ techType2, techType2, techType2, techType2, techType2 }
					};
					CraftDataHandler.SetTechData(techType64, recipeData64);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType64, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"NIUnstacked"
					});
					recipeData107 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType106, 1)
				},
						LinkedItems = new List<TechType>
				{ techType104, techType104, techType104, techType104, techType104 }
					};
					CraftDataHandler.SetTechData(techType107, recipeData107);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType107, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"FIUnstacked"
					});
					recipeData162 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType161, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.PlasteelIngot, TechType.PlasteelIngot, TechType.PlasteelIngot, TechType.PlasteelIngot, TechType.PlasteelIngot }
					};
					CraftDataHandler.SetTechData(techType162, recipeData162);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType162, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"MIUnstacked"
					});
					recipeData127 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType126, 1)
				},
						LinkedItems = new List<TechType>
				{ techType124, techType124, techType124, techType124, techType124 }
					};
					CraftDataHandler.SetTechData(techType127, recipeData127);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType127, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"NIUnstacked"
					});
					recipeData170 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType169, 1)
				},
						LinkedItems = new List<TechType>
				{ techType167, techType167, techType167, techType167, techType167 }
					};
					CraftDataHandler.SetTechData(techType170, recipeData170);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType170, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"NIUnstacked"
					});
					recipeData131 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType130, 1)
				},
						LinkedItems = new List<TechType>
				{ techType128, techType128, techType128, techType128, techType128 }
					};
					CraftDataHandler.SetTechData(techType131, recipeData131);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType131, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"NIUnstacked"
					});

					recipeData166 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType165, 1)
				},
						LinkedItems = new List<TechType>
				{ techType163, techType163, techType163, techType163, techType163 }
					};
					CraftDataHandler.SetTechData(techType166, recipeData166);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType166, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"NIUnstacked"
					});

					recipeData143 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType142, 1)
				},
						LinkedItems = new List<TechType>
				{ techType140, techType140, techType140, techType140, techType140 }
					};
					CraftDataHandler.SetTechData(techType143, recipeData143);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType143, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"NIUnstacked"
					});
					recipeData147 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType146, 1)
				},
						LinkedItems = new List<TechType>
				{ techType144, techType144, techType144, techType144, techType144 }
					};
					CraftDataHandler.SetTechData(techType147, recipeData147);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType147, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"NIUnstacked"
					});
					recipeData151 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType150, 1)
				},
						LinkedItems = new List<TechType>
				{ techType148, techType148, techType148, techType148, techType148 }
					};
					CraftDataHandler.SetTechData(techType151, recipeData151);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType151, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"NIUnstacked"
					});
					recipeData155 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType154, 1)
				},
						LinkedItems = new List<TechType>
				{ techType152, techType152, techType152, techType152, techType152 }
					};
					CraftDataHandler.SetTechData(techType155, recipeData155);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType155, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"NIUnstacked"
					});
					recipeData159 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType158, 1)
				},
						LinkedItems = new List<TechType>
				{ techType156, techType156, techType156, techType156, techType156 }
					};
					CraftDataHandler.SetTechData(techType159, recipeData159);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType159, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"NIUnstacked"
					});
					recipeData65 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType23, 1)
				},
						LinkedItems = new List<TechType>
				{ techType3, techType3, techType3, techType3, techType3 }
					};
					CraftDataHandler.SetTechData(techType65, recipeData65);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType65, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"MIUnstacked"
					});
					recipeData66 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType24, 1)
				},
						LinkedItems = new List<TechType>
				{ techType4, techType4, techType4, techType4, techType4 }
					};
					CraftDataHandler.SetTechData(techType66, recipeData66);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType66, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"EIUnstacked"
					});
					recipeData67 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType25, 1)
				},
						LinkedItems = new List<TechType>
				{ techType5, techType5, techType5, techType5, techType5 }
					};
					CraftDataHandler.SetTechData(techType67, recipeData67);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType67, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"MIUnstacked"
					});
					recipeData68 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType26, 1)
				},
						LinkedItems = new List<TechType>
				{ techType6, techType6, techType6, techType6, techType6 }
					};
					CraftDataHandler.SetTechData(techType68, recipeData68);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType68, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"EIUnstacked"
					});
					recipeData69 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType27, 1)
				},
						LinkedItems = new List<TechType>
				{ techType7, techType7, techType7, techType7, techType7 }
					};
					CraftDataHandler.SetTechData(techType69, recipeData69);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType69, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"EIUnstacked"
					});
					recipeData70 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType28, 1)
				},
						LinkedItems = new List<TechType>
				{ techType8, techType8, techType8, techType8, techType8 }
					};
					CraftDataHandler.SetTechData(techType70, recipeData70);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType70, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"MIUnstacked"
					});
					recipeData71 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType29, 1)
				},
						LinkedItems = new List<TechType>
				{ techType9, techType9, techType9, techType9, techType9 }
					};
					CraftDataHandler.SetTechData(techType71, recipeData71);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType71, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"NIUnstacked"
					});
					recipeData72 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType30, 1)
				},
						LinkedItems = new List<TechType>
				{ techType10, techType10, techType10, techType10, techType10 }
					};
					CraftDataHandler.SetTechData(techType72, recipeData72);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType72, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"NIUnstacked"
					});
					recipeData111 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType110, 1)
				},
						LinkedItems = new List<TechType>
				{ techType108, techType108, techType108, techType108, techType108 }
					};
					CraftDataHandler.SetTechData(techType111, recipeData111);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType111, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"SIUnstacked"
					});
					recipeData115 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType114, 1)
				},
						LinkedItems = new List<TechType>
				{ techType112, techType112, techType112, techType112, techType112 }
					};
					CraftDataHandler.SetTechData(techType115, recipeData115);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType115, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"SIUnstacked"
					});
					recipeData119 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType118, 1)
				},
						LinkedItems = new List<TechType>
				{ techType116, techType116, techType116, techType116, techType116 }
					};
					CraftDataHandler.SetTechData(techType119, recipeData119);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType119, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"SIUnstacked"
					});
					recipeData123 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType122, 1)
				},
						LinkedItems = new List<TechType>
				{ techType120, techType120, techType120, techType120, techType120 }
					};
					CraftDataHandler.SetTechData(techType123, recipeData123);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType123, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"SIUnstacked"
					});
					recipeData73 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType31, 1)
				},
						LinkedItems = new List<TechType>
				{ techType11, techType11, techType11, techType11, techType11 }
					};
					CraftDataHandler.SetTechData(techType73, recipeData73);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType73, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"EIUnstacked"
					});
					recipeData74 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType32, 1)
				},
						LinkedItems = new List<TechType>
				{ techType12, techType12, techType12, techType12, techType12 }
					};
					CraftDataHandler.SetTechData(techType74, recipeData74);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType74, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"EIUnstacked"
					});
					recipeData75 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType33, 1)
				},
						LinkedItems = new List<TechType>
				{ techType13, techType13, techType13, techType13, techType13 }
					};
					CraftDataHandler.SetTechData(techType75, recipeData75);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType75, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"NIUnstacked"
					});
					recipeData76 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType34, 1)
				},
						LinkedItems = new List<TechType>
				{ techType14, techType14, techType14, techType14, techType14 }
					};
					CraftDataHandler.SetTechData(techType76, recipeData76);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType76, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"NIUnstacked"
					});
					recipeData77 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType35, 1)
				},
						LinkedItems = new List<TechType>
				{ techType15, techType15, techType15, techType15, techType15 }
					};
					CraftDataHandler.SetTechData(techType77, recipeData77);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType77, new string[]
					{"Resources",
				
				"BI",
				"USI",
				"NIUnstacked"
					});
			recipeData186 = new RecipeData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType185, 1)
				},
				LinkedItems = new List<TechType>
				{ techType183, techType183, techType183, techType183, techType183 }
			};
			CraftDataHandler.SetTechData(techType186, recipeData186);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType186, new string[]
			{"Resources",

				"BI",
				"USI",
				"NIUnstacked"
			});
			recipeData182 = new RecipeData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType181, 1)
				},
				LinkedItems = new List<TechType>
				{ techType179, techType179, techType179, techType179, techType179 }
			};
			CraftDataHandler.SetTechData(techType182, recipeData182);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType182, new string[]
			{"Resources",

				"BI",
				"USI",
				"NIUnstacked"
			});
			recipeData178 = new RecipeData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(techType177, 1)
				},
				LinkedItems = new List<TechType>
				{ techType175, techType175, techType175, techType175, techType175 }
			};
			CraftDataHandler.SetTechData(techType178, recipeData178);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType178, new string[]
			{"Resources",
				
				"BI",
				"USI",
				"NIUnstacked"
			});
			recipeData79 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType37, 1)
				},
						LinkedItems = new List<TechType>
				{ TechType.TitaniumIngot, TechType.TitaniumIngot, TechType.TitaniumIngot, TechType.TitaniumIngot, TechType.TitaniumIngot }
					};
					CraftDataHandler.SetTechData(techType79, recipeData79);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType79, new string[]
					{
				"Resources",
				
				"BI",
				"USI",
				"MIUnstacked"
					});
					recipeData80 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType38, 1)
				},
						LinkedItems = new List<TechType>
				{ techType17, techType17, techType17, techType17, techType17 }
					};
					CraftDataHandler.SetTechData(techType80, recipeData80);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType80, new string[]
					{
				"Resources",
				
				"BI",
				"USI",
				"EIUnstacked"
					});
					recipeData81 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType39, 1)
				},
						LinkedItems = new List<TechType>
				{ techType18, techType18, techType18, techType18, techType18 }
					};
					CraftDataHandler.SetTechData(techType81, recipeData81);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType81, new string[]
					{
				"Resources",
				
				"BI",
				"USI",
				"EIUnstacked"
					});
					recipeData82 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType40, 1)
				},
						LinkedItems = new List<TechType>
				{ techType19, techType19, techType19, techType19, techType19 }
					};
					CraftDataHandler.SetTechData(techType82, recipeData82);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType82, new string[]
					{
				"Resources",
				
				"BI",
				"USI",
				"EIUnstacked"
					});
					recipeData83 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType41, 1)
				},
						LinkedItems = new List<TechType>
				{ techType20, techType20, techType20, techType20, techType20 }
					};
					CraftDataHandler.SetTechData(techType83, recipeData83);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType83, new string[]
					{
				"Resources",
				
				"BI",
				"USI",
				"EIUnstacked"
					});
					recipeData99 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType98, 1)
				},
						LinkedItems = new List<TechType>
				{ techType96, techType96, techType96, techType96, techType96 }
					};
					CraftDataHandler.SetTechData(techType99, recipeData99);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType99, new string[]
					{
				"Resources",
				
				"BI",
				"USI",
				"CIUnstacked"
					});
					recipeData87 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType86, 1)
				},
						LinkedItems = new List<TechType>
				{ techType84, techType84, techType84, techType84, techType84 }
					};
					CraftDataHandler.SetTechData(techType87, recipeData87);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType87, new string[]
					{   "Resources",
				
				"BI",
				"USI",
				"CIUnstacked"
					});
					recipeData103 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType102, 1)
				},
						LinkedItems = new List<TechType>
				{ techType100, techType100, techType100, techType100, techType100 }
					};
					CraftDataHandler.SetTechData(techType103, recipeData103);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType103, new string[]
					{
				"Resources",
				
				"BI",
				"USI",
				"CIUnstacked"
					});
					recipeData95 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType94, 1)
				},
						LinkedItems = new List<TechType>
				{ techType92, techType92, techType92, techType92, techType92 }
					};
					CraftDataHandler.SetTechData(techType95, recipeData95);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType95, new string[]
					{
				"Resources",
				
				"BI",
				"USI",
				"CIUnstacked"
					});
					recipeData173 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType172, 1)
				},
						LinkedItems = new List<TechType>
				{ techType174, techType174, techType174, techType174, techType174 }
					};
					CraftDataHandler.SetTechData(techType173, recipeData173);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType173, new string[]
					{
				"Resources",
				
				"BI",
				"USI",
				"FIUnstacked"
					});

					recipeData91 = new RecipeData
					{
						craftAmount = 0,
						Ingredients = new List<Ingredient>
				{
					new Ingredient(techType90, 1)
				},
						LinkedItems = new List<TechType>
				{ techType88, techType88, techType88, techType88, techType88 }
					};
					CraftDataHandler.SetTechData(techType91, recipeData91);
					CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType91, new string[]
					{
				"Resources",
				
				"BI",
				"USI",
				"CIUnstacked"
					});
					Console.WriteLine("Unstacked Loaded");
					Console.WriteLine("MoreIngots Loaded");
				}

				// Token: 0x06000002 RID: 2 RVA: 0x0000A464 File Offset: 0x00008664
				public static Sprite GetSprite(string name)
				{
					return ImageUtils.LoadSpriteFromFile("./BepInEx/plugins/MoreIngotsBZ/Assets/" + name + ".png", TextureFormat.BC7);
				}
			}
		}
	

