// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  ULKYOME-PC
// DateTime: 01.10.2023 03:42:26
// UserName: Ulkyome
// Input file <E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy - 18.09.2023 11:46:58>

// options: lines

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace LSLib.LS.Stats.StatParser
{
public enum StatTokens {error=46,EOF=47,NEW=48,
    ADD=49,ENTRY=50,TYPE=51,DATA=52,PARAM=53,USING=54,
    KEY=55,ABILITY=56,ITEMCOLOR=57,NAMEGROUP=58,NAME=59,NAMECOOL=60,
    ITEMGROUP=61,LEVELGROUP=62,ROOTGROUP=63,REQUIREMENT=64,DELTAMOD=65,NEW_BOOST=66,
    EQUIPMENT=67,ADD_EQUIPMENTGROUP=68,ADD_EQUIPMENT_ENTRY=69,ITEMCOMBOPROPERTY=70,NEW_ITEMCOMBOPROPERTYENTRY=71,ITEM_COMBINATION=72,
    ITEM_COMBINATION_RESULT=73,CRAFTING_PREVIEW_DATA=74,SKILLSET=75,SKILL=76,CATEGORY_MAP=77,WEAPON_COUNTER=78,
    SKILLBOOK_COUNTER=79,ARMOR_COUNTER=80,TREASURE=81,ITEMTYPES=82,TREASURE_TABLE=83,NEW_SUBTABLE=84,
    OBJECT_CATEGORY=85,START_LEVEL=86,END_LEVEL=87,MIN_LEVEL=88,MAX_LEVEL=89,IGNORE_LEVEL_DIFF=90,
    USE_TREASURE_GROUPS=91,BAD=92,INTEGER=93,STRING=94,DATA_ITEM=95};

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public partial class StatParser: ShiftReduceParser<System.Object, LSLib.LS.Story.GoalParser.CodeLocation>
{
#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[100];
  private static State[] states = new State[221];
  private static string[] nonTerms = new string[] {
      "StatFile", "$accept", "Declarations", "Declaration", "TreasureTypesDeclaration", 
      "DataDeclaration", "EntryHeader", "EntryProperties", "EntryProperty", "EntryStdHeader", 
      "DataKeyHeader", "AbilityHeader", "RequirementsHeader", "DeltaModHeader", 
      "ItemColorHeader", "ItemCombinationHeader", "ItemCombinationResultHeader", 
      "ItemProgressionNamesHeader", "ItemProgressionVisualsHeader", "EquipmentHeader", 
      "ItemComboPropertyHeader", "ObjectCategoryItemComboPreviewDataHeader", 
      "SkillSetHeader", "TreasureGroupHeader", "TreasureTableHeader", "EntryType", 
      "EntryUsing", "EntryData", "EntryDataHack", "EntryParam", "ItemProgressionName", 
      "ItemProgressionNameCool", "ItemProgressionVisualLevel", "ItemProgressionVisualName", 
      "ItemProgressionVisualRoot", "DeltaModifierBoost", "EquipmentGroup", "ItemComboPropertyEntry", 
      "SkillSetSkill", "TreasureGroupWeaponCounter", "TreasureGroupSkillbookCounter", 
      "TreasureGroupArmorCounter", "TreasureSubtable", "TreasureTableMinLevel", 
      "TreasureTableMaxLevel", "TreasureTableIgnoreLevelDiff", "TreasureTableUseTreasureGroups", 
      "EquipmentEntries", "EquipmentEntry", "EntrySubProperties", "TreasureTableObjects", 
      "TreasureTableEntry", "TreasureTableObject", "TreasureTableObjectStartLevel", 
      "TreasureTableObjectEndLevel", };

  static StatParser() {
    states[0] = new State(-3,new int[]{-1,1,-3,3});
    states[1] = new State(new int[]{47,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{48,132,55,164,56,169,64,186,77,201,81,206,47,-2},new int[]{-4,4,-5,5,-6,6,-7,7,-10,131,-11,163,-12,168,-13,185,-14,190,-15,191,-16,192,-17,193,-18,194,-19,195,-20,196,-21,197,-22,198,-23,199,-24,200,-25,205});
    states[4] = new State(-4);
    states[5] = new State(-5);
    states[6] = new State(-7);
    states[7] = new State(-9,new int[]{-8,8});
    states[8] = new State(new int[]{51,11,54,14,52,17,95,21,53,23,49,27,66,59,68,64,71,70,78,75,79,80,80,85,84,90,88,120,89,123,90,126,91,129,48,-8,55,-8,56,-8,64,-8,77,-8,81,-8,47,-8},new int[]{-9,9,-26,10,-27,13,-28,16,-29,20,-30,22,-31,26,-32,54,-33,55,-34,56,-35,57,-36,58,-37,63,-38,69,-39,73,-40,74,-41,79,-42,84,-43,89,-44,119,-45,122,-46,125,-47,128});
    states[9] = new State(-10);
    states[10] = new State(-43);
    states[11] = new State(new int[]{94,12});
    states[12] = new State(-65);
    states[13] = new State(-44);
    states[14] = new State(new int[]{94,15});
    states[15] = new State(-66);
    states[16] = new State(-45);
    states[17] = new State(new int[]{94,18});
    states[18] = new State(new int[]{94,19});
    states[19] = new State(-67);
    states[20] = new State(-46);
    states[21] = new State(-68);
    states[22] = new State(-47);
    states[23] = new State(new int[]{94,24});
    states[24] = new State(new int[]{94,25});
    states[25] = new State(-69);
    states[26] = new State(-48);
    states[27] = new State(new int[]{59,28,60,32,62,36,63,42,58,46,76,52});
    states[28] = new State(new int[]{94,29});
    states[29] = new State(new int[]{44,30});
    states[30] = new State(new int[]{94,31});
    states[31] = new State(-70);
    states[32] = new State(new int[]{94,33});
    states[33] = new State(new int[]{44,34});
    states[34] = new State(new int[]{94,35});
    states[35] = new State(-71);
    states[36] = new State(new int[]{93,37});
    states[37] = new State(new int[]{44,38});
    states[38] = new State(new int[]{93,39});
    states[39] = new State(new int[]{44,40});
    states[40] = new State(new int[]{94,41});
    states[41] = new State(-72);
    states[42] = new State(new int[]{94,43});
    states[43] = new State(new int[]{44,44});
    states[44] = new State(new int[]{94,45});
    states[45] = new State(-73);
    states[46] = new State(new int[]{94,47});
    states[47] = new State(new int[]{44,48});
    states[48] = new State(new int[]{94,49});
    states[49] = new State(new int[]{44,50});
    states[50] = new State(new int[]{94,51});
    states[51] = new State(-74);
    states[52] = new State(new int[]{94,53});
    states[53] = new State(-83);
    states[54] = new State(-49);
    states[55] = new State(-50);
    states[56] = new State(-51);
    states[57] = new State(-52);
    states[58] = new State(-53);
    states[59] = new State(new int[]{94,60});
    states[60] = new State(new int[]{44,61});
    states[61] = new State(new int[]{93,62});
    states[62] = new State(-75);
    states[63] = new State(-54);
    states[64] = new State(-77,new int[]{-48,65});
    states[65] = new State(new int[]{69,67,51,-76,54,-76,52,-76,95,-76,53,-76,49,-76,66,-76,68,-76,71,-76,78,-76,79,-76,80,-76,84,-76,88,-76,89,-76,90,-76,91,-76,48,-76,55,-76,56,-76,64,-76,77,-76,81,-76,47,-76},new int[]{-49,66});
    states[66] = new State(-78);
    states[67] = new State(new int[]{94,68});
    states[68] = new State(-79);
    states[69] = new State(-55);
    states[70] = new State(-81,new int[]{-50,71});
    states[71] = new State(new int[]{52,17,51,-80,54,-80,95,-80,53,-80,49,-80,66,-80,68,-80,71,-80,78,-80,79,-80,80,-80,84,-80,88,-80,89,-80,90,-80,91,-80,48,-80,55,-80,56,-80,64,-80,77,-80,81,-80,47,-80},new int[]{-28,72});
    states[72] = new State(-82);
    states[73] = new State(-56);
    states[74] = new State(-57);
    states[75] = new State(new int[]{94,76});
    states[76] = new State(new int[]{44,77});
    states[77] = new State(new int[]{94,78});
    states[78] = new State(-84);
    states[79] = new State(-58);
    states[80] = new State(new int[]{94,81});
    states[81] = new State(new int[]{44,82});
    states[82] = new State(new int[]{94,83});
    states[83] = new State(-85);
    states[84] = new State(-59);
    states[85] = new State(new int[]{94,86});
    states[86] = new State(new int[]{44,87});
    states[87] = new State(new int[]{94,88});
    states[88] = new State(-86);
    states[89] = new State(-60);
    states[90] = new State(new int[]{94,91});
    states[91] = new State(-92,new int[]{-51,92});
    states[92] = new State(new int[]{85,95,86,114,87,117,51,-87,54,-87,52,-87,95,-87,53,-87,49,-87,66,-87,68,-87,71,-87,78,-87,79,-87,80,-87,84,-87,88,-87,89,-87,90,-87,91,-87,48,-87,55,-87,56,-87,64,-87,77,-87,81,-87,47,-87},new int[]{-52,93,-53,94,-54,113,-55,116});
    states[93] = new State(-93);
    states[94] = new State(-94);
    states[95] = new State(new int[]{94,96});
    states[96] = new State(new int[]{44,97});
    states[97] = new State(new int[]{93,98});
    states[98] = new State(new int[]{44,99});
    states[99] = new State(new int[]{93,100});
    states[100] = new State(new int[]{44,101});
    states[101] = new State(new int[]{93,102});
    states[102] = new State(new int[]{44,103});
    states[103] = new State(new int[]{93,104});
    states[104] = new State(new int[]{44,105});
    states[105] = new State(new int[]{93,106});
    states[106] = new State(new int[]{44,107});
    states[107] = new State(new int[]{93,108});
    states[108] = new State(new int[]{44,109});
    states[109] = new State(new int[]{93,110});
    states[110] = new State(new int[]{44,111});
    states[111] = new State(new int[]{93,112});
    states[112] = new State(-99);
    states[113] = new State(-95);
    states[114] = new State(new int[]{94,115});
    states[115] = new State(-97);
    states[116] = new State(-96);
    states[117] = new State(new int[]{94,118});
    states[118] = new State(-98);
    states[119] = new State(-61);
    states[120] = new State(new int[]{94,121});
    states[121] = new State(-88);
    states[122] = new State(-62);
    states[123] = new State(new int[]{94,124});
    states[124] = new State(-89);
    states[125] = new State(-63);
    states[126] = new State(new int[]{93,127});
    states[127] = new State(-90);
    states[128] = new State(-64);
    states[129] = new State(new int[]{93,130});
    states[130] = new State(-91);
    states[131] = new State(-11);
    states[132] = new State(new int[]{50,133,65,135,57,137,72,145,73,147,58,149,61,151,67,153,70,155,74,157,75,159,83,161});
    states[133] = new State(new int[]{94,134});
    states[134] = new State(-27);
    states[135] = new State(new int[]{94,136});
    states[136] = new State(-31);
    states[137] = new State(new int[]{94,138});
    states[138] = new State(new int[]{44,139});
    states[139] = new State(new int[]{94,140});
    states[140] = new State(new int[]{44,141});
    states[141] = new State(new int[]{94,142});
    states[142] = new State(new int[]{44,143});
    states[143] = new State(new int[]{94,144});
    states[144] = new State(-34);
    states[145] = new State(new int[]{94,146});
    states[146] = new State(-32);
    states[147] = new State(new int[]{94,148});
    states[148] = new State(-33);
    states[149] = new State(new int[]{94,150});
    states[150] = new State(-35);
    states[151] = new State(new int[]{94,152});
    states[152] = new State(-36);
    states[153] = new State(new int[]{94,154});
    states[154] = new State(-37);
    states[155] = new State(new int[]{94,156});
    states[156] = new State(-38);
    states[157] = new State(new int[]{94,158});
    states[158] = new State(-39);
    states[159] = new State(new int[]{94,160});
    states[160] = new State(-40);
    states[161] = new State(new int[]{94,162});
    states[162] = new State(-42);
    states[163] = new State(-12);
    states[164] = new State(new int[]{94,165});
    states[165] = new State(new int[]{44,166});
    states[166] = new State(new int[]{94,167});
    states[167] = new State(-28);
    states[168] = new State(-13);
    states[169] = new State(new int[]{59,170});
    states[170] = new State(new int[]{44,171});
    states[171] = new State(new int[]{93,172});
    states[172] = new State(new int[]{44,173});
    states[173] = new State(new int[]{93,174});
    states[174] = new State(new int[]{44,175});
    states[175] = new State(new int[]{93,176});
    states[176] = new State(new int[]{44,177});
    states[177] = new State(new int[]{93,178});
    states[178] = new State(new int[]{44,179});
    states[179] = new State(new int[]{93,180});
    states[180] = new State(new int[]{44,181});
    states[181] = new State(new int[]{93,182});
    states[182] = new State(new int[]{44,183});
    states[183] = new State(new int[]{93,184});
    states[184] = new State(-29);
    states[185] = new State(-14);
    states[186] = new State(new int[]{94,187});
    states[187] = new State(new int[]{44,188});
    states[188] = new State(new int[]{94,189});
    states[189] = new State(-30);
    states[190] = new State(-15);
    states[191] = new State(-16);
    states[192] = new State(-17);
    states[193] = new State(-18);
    states[194] = new State(-19);
    states[195] = new State(-20);
    states[196] = new State(-21);
    states[197] = new State(-22);
    states[198] = new State(-23);
    states[199] = new State(-24);
    states[200] = new State(-25);
    states[201] = new State(new int[]{94,202});
    states[202] = new State(new int[]{44,203});
    states[203] = new State(new int[]{94,204});
    states[204] = new State(-41);
    states[205] = new State(-26);
    states[206] = new State(new int[]{82,207});
    states[207] = new State(new int[]{94,208});
    states[208] = new State(new int[]{44,209});
    states[209] = new State(new int[]{94,210});
    states[210] = new State(new int[]{44,211});
    states[211] = new State(new int[]{94,212});
    states[212] = new State(new int[]{44,213});
    states[213] = new State(new int[]{94,214});
    states[214] = new State(new int[]{44,215});
    states[215] = new State(new int[]{94,216});
    states[216] = new State(new int[]{44,217});
    states[217] = new State(new int[]{94,218});
    states[218] = new State(new int[]{44,219});
    states[219] = new State(new int[]{94,220});
    states[220] = new State(-6);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-2, new int[]{-1,47});
    rules[2] = new Rule(-1, new int[]{-3});
    rules[3] = new Rule(-3, new int[]{});
    rules[4] = new Rule(-3, new int[]{-3,-4});
    rules[5] = new Rule(-3, new int[]{-3,-5});
    rules[6] = new Rule(-5, new int[]{81,82,94,44,94,44,94,44,94,44,94,44,94,44,94});
    rules[7] = new Rule(-4, new int[]{-6});
    rules[8] = new Rule(-6, new int[]{-7,-8});
    rules[9] = new Rule(-8, new int[]{});
    rules[10] = new Rule(-8, new int[]{-8,-9});
    rules[11] = new Rule(-7, new int[]{-10});
    rules[12] = new Rule(-7, new int[]{-11});
    rules[13] = new Rule(-7, new int[]{-12});
    rules[14] = new Rule(-7, new int[]{-13});
    rules[15] = new Rule(-7, new int[]{-14});
    rules[16] = new Rule(-7, new int[]{-15});
    rules[17] = new Rule(-7, new int[]{-16});
    rules[18] = new Rule(-7, new int[]{-17});
    rules[19] = new Rule(-7, new int[]{-18});
    rules[20] = new Rule(-7, new int[]{-19});
    rules[21] = new Rule(-7, new int[]{-20});
    rules[22] = new Rule(-7, new int[]{-21});
    rules[23] = new Rule(-7, new int[]{-22});
    rules[24] = new Rule(-7, new int[]{-23});
    rules[25] = new Rule(-7, new int[]{-24});
    rules[26] = new Rule(-7, new int[]{-25});
    rules[27] = new Rule(-10, new int[]{48,50,94});
    rules[28] = new Rule(-11, new int[]{55,94,44,94});
    rules[29] = new Rule(-12, new int[]{56,59,44,93,44,93,44,93,44,93,44,93,44,93,44,93});
    rules[30] = new Rule(-13, new int[]{64,94,44,94});
    rules[31] = new Rule(-14, new int[]{48,65,94});
    rules[32] = new Rule(-16, new int[]{48,72,94});
    rules[33] = new Rule(-17, new int[]{48,73,94});
    rules[34] = new Rule(-15, new int[]{48,57,94,44,94,44,94,44,94});
    rules[35] = new Rule(-18, new int[]{48,58,94});
    rules[36] = new Rule(-19, new int[]{48,61,94});
    rules[37] = new Rule(-20, new int[]{48,67,94});
    rules[38] = new Rule(-21, new int[]{48,70,94});
    rules[39] = new Rule(-22, new int[]{48,74,94});
    rules[40] = new Rule(-23, new int[]{48,75,94});
    rules[41] = new Rule(-24, new int[]{77,94,44,94});
    rules[42] = new Rule(-25, new int[]{48,83,94});
    rules[43] = new Rule(-9, new int[]{-26});
    rules[44] = new Rule(-9, new int[]{-27});
    rules[45] = new Rule(-9, new int[]{-28});
    rules[46] = new Rule(-9, new int[]{-29});
    rules[47] = new Rule(-9, new int[]{-30});
    rules[48] = new Rule(-9, new int[]{-31});
    rules[49] = new Rule(-9, new int[]{-32});
    rules[50] = new Rule(-9, new int[]{-33});
    rules[51] = new Rule(-9, new int[]{-34});
    rules[52] = new Rule(-9, new int[]{-35});
    rules[53] = new Rule(-9, new int[]{-36});
    rules[54] = new Rule(-9, new int[]{-37});
    rules[55] = new Rule(-9, new int[]{-38});
    rules[56] = new Rule(-9, new int[]{-39});
    rules[57] = new Rule(-9, new int[]{-40});
    rules[58] = new Rule(-9, new int[]{-41});
    rules[59] = new Rule(-9, new int[]{-42});
    rules[60] = new Rule(-9, new int[]{-43});
    rules[61] = new Rule(-9, new int[]{-44});
    rules[62] = new Rule(-9, new int[]{-45});
    rules[63] = new Rule(-9, new int[]{-46});
    rules[64] = new Rule(-9, new int[]{-47});
    rules[65] = new Rule(-26, new int[]{51,94});
    rules[66] = new Rule(-27, new int[]{54,94});
    rules[67] = new Rule(-28, new int[]{52,94,94});
    rules[68] = new Rule(-29, new int[]{95});
    rules[69] = new Rule(-30, new int[]{53,94,94});
    rules[70] = new Rule(-31, new int[]{49,59,94,44,94});
    rules[71] = new Rule(-32, new int[]{49,60,94,44,94});
    rules[72] = new Rule(-33, new int[]{49,62,93,44,93,44,94});
    rules[73] = new Rule(-34, new int[]{49,63,94,44,94});
    rules[74] = new Rule(-35, new int[]{49,58,94,44,94,44,94});
    rules[75] = new Rule(-36, new int[]{66,94,44,93});
    rules[76] = new Rule(-37, new int[]{68,-48});
    rules[77] = new Rule(-48, new int[]{});
    rules[78] = new Rule(-48, new int[]{-48,-49});
    rules[79] = new Rule(-49, new int[]{69,94});
    rules[80] = new Rule(-38, new int[]{71,-50});
    rules[81] = new Rule(-50, new int[]{});
    rules[82] = new Rule(-50, new int[]{-50,-28});
    rules[83] = new Rule(-39, new int[]{49,76,94});
    rules[84] = new Rule(-40, new int[]{78,94,44,94});
    rules[85] = new Rule(-41, new int[]{79,94,44,94});
    rules[86] = new Rule(-42, new int[]{80,94,44,94});
    rules[87] = new Rule(-43, new int[]{84,94,-51});
    rules[88] = new Rule(-44, new int[]{88,94});
    rules[89] = new Rule(-45, new int[]{89,94});
    rules[90] = new Rule(-46, new int[]{90,93});
    rules[91] = new Rule(-47, new int[]{91,93});
    rules[92] = new Rule(-51, new int[]{});
    rules[93] = new Rule(-51, new int[]{-51,-52});
    rules[94] = new Rule(-52, new int[]{-53});
    rules[95] = new Rule(-52, new int[]{-54});
    rules[96] = new Rule(-52, new int[]{-55});
    rules[97] = new Rule(-54, new int[]{86,94});
    rules[98] = new Rule(-55, new int[]{87,94});
    rules[99] = new Rule(-53, new int[]{85,94,44,93,44,93,44,93,44,93,44,93,44,93,44,93,44,93});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)StatTokens.error, (int)StatTokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
      case 3: // Declarations -> /* empty */
#line 98 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                           { CurrentSemanticValue = MakeDeclarationList(); }
#line default
        break;
      case 4: // Declarations -> Declarations, Declaration
#line 99 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                        { CurrentSemanticValue = AddDeclaration(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 5: // Declarations -> Declarations, TreasureTypesDeclaration
#line 100 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                                     { CurrentSemanticValue = ValueStack[ValueStack.Depth-2]; }
#line default
        break;
      case 8: // DataDeclaration -> EntryHeader, EntryProperties
#line 107 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                              { CurrentSemanticValue = AddProperty(ValueStack[ValueStack.Depth-1], ValueStack[ValueStack.Depth-2]); }
#line default
        break;
      case 9: // EntryProperties -> /* empty */
#line 109 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                              { CurrentSemanticValue = MakeDeclaration(CurrentLocationSpan); }
#line default
        break;
      case 10: // EntryProperties -> EntryProperties, EntryProperty
#line 110 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                                { CurrentSemanticValue = AddProperty(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 27: // EntryStdHeader -> NEW, ENTRY, STRING
#line 130 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                  { CurrentSemanticValue = MakeProperty(LocationStack[LocationStack.Depth-1], "Name", ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 28: // DataKeyHeader -> KEY, STRING, ',', STRING
#line 133 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(CurrentLocationSpan, new [] {
					MakeProperty(LocationStack[LocationStack.Depth-3], "Key", ValueStack[ValueStack.Depth-3]),
					MakeProperty("EntityType", "Data"),
					MakeProperty(LocationStack[LocationStack.Depth-1], "Value", ValueStack[ValueStack.Depth-1])
				}); }
#line default
        break;
      case 29: // AbilityHeader -> ABILITY, NAME, ',', INTEGER, ',', INTEGER, ',', INTEGER, ',', 
               //                  INTEGER, ',', INTEGER, ',', INTEGER, ',', INTEGER
#line 141 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(CurrentLocationSpan, new [] {
					MakeProperty(LocationStack[LocationStack.Depth-15], "Name", ValueStack[ValueStack.Depth-15]),
					MakeProperty("EntityType", "Ability")
				}); }
#line default
        break;
      case 30: // RequirementsHeader -> REQUIREMENT, STRING, ',', STRING
#line 147 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(CurrentLocationSpan, new [] {
					MakeProperty(LocationStack[LocationStack.Depth-3], "Name", ValueStack[ValueStack.Depth-3]),
					MakeProperty("EntityType", "Requirement"),
					MakeProperty(LocationStack[LocationStack.Depth-1], "Requirements", ValueStack[ValueStack.Depth-1])
				}); }
#line default
        break;
      case 31: // DeltaModHeader -> NEW, DELTAMOD, STRING
#line 154 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(CurrentLocationSpan, new [] {
					MakeProperty(LocationStack[LocationStack.Depth-1], "Name", ValueStack[ValueStack.Depth-1]),
					MakeProperty("EntityType", "DeltaModifier")
				}); }
#line default
        break;
      case 32: // ItemCombinationHeader -> NEW, ITEM_COMBINATION, STRING
#line 160 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(CurrentLocationSpan, new [] {
					MakeProperty(LocationStack[LocationStack.Depth-1], "Name", ValueStack[ValueStack.Depth-1]),
					MakeProperty("EntityType", "ItemCombination")
				}); }
#line default
        break;
      case 33: // ItemCombinationResultHeader -> NEW, ITEM_COMBINATION_RESULT, STRING
#line 166 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(CurrentLocationSpan, new [] {
					MakeProperty(LocationStack[LocationStack.Depth-1], "Name", ValueStack[ValueStack.Depth-1]),
					MakeProperty("EntityType", "ItemCombinationResult")
				}); }
#line default
        break;
      case 34: // ItemColorHeader -> NEW, ITEMCOLOR, STRING, ',', STRING, ',', STRING, ',', 
               //                    STRING
#line 172 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(CurrentLocationSpan, new [] {
					MakeProperty(LocationStack[LocationStack.Depth-7], "ItemColorName", ValueStack[ValueStack.Depth-7]),
					MakeProperty("EntityType", "ItemColor"),
					MakeProperty(LocationStack[LocationStack.Depth-5], "Primary Color", ValueStack[ValueStack.Depth-5]),
					MakeProperty(LocationStack[LocationStack.Depth-3], "Secondary Color", ValueStack[ValueStack.Depth-3]),
					MakeProperty(LocationStack[LocationStack.Depth-1], "Tertiary Color", ValueStack[ValueStack.Depth-1]),
				}); }
#line default
        break;
      case 35: // ItemProgressionNamesHeader -> NEW, NAMEGROUP, STRING
#line 181 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(CurrentLocationSpan, new [] {
					MakeProperty(LocationStack[LocationStack.Depth-1], "Name", ValueStack[ValueStack.Depth-1]),
					MakeProperty("EntityType", "ItemProgressionNames")
				}); }
#line default
        break;
      case 36: // ItemProgressionVisualsHeader -> NEW, ITEMGROUP, STRING
#line 187 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(CurrentLocationSpan, new [] {
					MakeProperty(LocationStack[LocationStack.Depth-1], "Name", ValueStack[ValueStack.Depth-1]),
					MakeProperty("EntityType", "ItemProgressionVisuals")
				}); }
#line default
        break;
      case 37: // EquipmentHeader -> NEW, EQUIPMENT, STRING
#line 193 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(CurrentLocationSpan, new [] {
					MakeProperty(LocationStack[LocationStack.Depth-1], "Name", ValueStack[ValueStack.Depth-1]),
					MakeProperty("EntityType", "Equipment")
				}); }
#line default
        break;
      case 38: // ItemComboPropertyHeader -> NEW, ITEMCOMBOPROPERTY, STRING
#line 199 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(CurrentLocationSpan, new [] {
					MakeProperty(LocationStack[LocationStack.Depth-1], "Name", ValueStack[ValueStack.Depth-1]),
					MakeProperty("EntityType", "ItemComboProperties")
				}); }
#line default
        break;
      case 39: // ObjectCategoryItemComboPreviewDataHeader -> NEW, CRAFTING_PREVIEW_DATA, STRING
#line 205 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(CurrentLocationSpan, new [] {
					MakeProperty(LocationStack[LocationStack.Depth-1], "Name", ValueStack[ValueStack.Depth-1])
				}); }
#line default
        break;
      case 40: // SkillSetHeader -> NEW, SKILLSET, STRING
#line 210 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(CurrentLocationSpan, new [] {
					MakeProperty(LocationStack[LocationStack.Depth-1], "Name", ValueStack[ValueStack.Depth-1]),
					MakeProperty("EntityType", "SkillSet")
				}); }
#line default
        break;
      case 41: // TreasureGroupHeader -> CATEGORY_MAP, STRING, ',', STRING
#line 216 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(CurrentLocationSpan, new [] {
					MakeProperty(LocationStack[LocationStack.Depth-3], "Name", ValueStack[ValueStack.Depth-3]),
					MakeProperty(LocationStack[LocationStack.Depth-1], "TreasureGroup", ValueStack[ValueStack.Depth-1]),
					MakeProperty("EntityType", "TreasureGroups")
				}); }
#line default
        break;
      case 42: // TreasureTableHeader -> NEW, TREASURE_TABLE, STRING
#line 223 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(CurrentLocationSpan, new [] {
					MakeProperty("Name", ValueStack[ValueStack.Depth-1]),
					MakeProperty("EntityType", "TreasureTable")
				}); }
#line default
        break;
      case 65: // EntryType -> TYPE, STRING
#line 252 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                        { CurrentSemanticValue = MakeProperty(CurrentLocationSpan, "EntityType", ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 66: // EntryUsing -> USING, STRING
#line 254 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                          { CurrentSemanticValue = MakeProperty(CurrentLocationSpan, "Using", ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 67: // EntryData -> DATA, STRING, STRING
#line 256 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                               { CurrentSemanticValue = MakeProperty(CurrentLocationSpan, ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 69: // EntryParam -> PARAM, STRING, STRING
#line 260 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                 { CurrentSemanticValue = MakeProperty(CurrentLocationSpan, ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 70: // ItemProgressionName -> ADD, NAME, STRING, ',', STRING
#line 263 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeElement("Names", new Dictionary<String, object> {
						{"Name", Unwrap(ValueStack[ValueStack.Depth-3])},
						{"Description", Unwrap(ValueStack[ValueStack.Depth-1])}
				}); }
#line default
        break;
      case 71: // ItemProgressionNameCool -> ADD, NAMECOOL, STRING, ',', STRING
#line 269 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeElement("NamesCool", new Dictionary<String, object> {
						{"Name", Unwrap(ValueStack[ValueStack.Depth-3])},
						{"Description", Unwrap(ValueStack[ValueStack.Depth-1])}
				}); }
#line default
        break;
      case 72: // ItemProgressionVisualLevel -> ADD, LEVELGROUP, INTEGER, ',', INTEGER, ',', 
               //                               STRING
#line 275 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeElement("LevelGroups", new Dictionary<String, object> {
						{"MinLevel", Unwrap(ValueStack[ValueStack.Depth-5])},
						{"MaxLevel", Unwrap(ValueStack[ValueStack.Depth-3])},
						{"Rarity", Unwrap(ValueStack[ValueStack.Depth-1])},
				}); }
#line default
        break;
      case 73: // ItemProgressionVisualName -> ADD, ROOTGROUP, STRING, ',', STRING
#line 282 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeElement("NameGroups", new Dictionary<String, object> {
						{"RootTemplate", Unwrap(ValueStack[ValueStack.Depth-3])},
						{"ItemColor", Unwrap(ValueStack[ValueStack.Depth-1])},
				}); }
#line default
        break;
      case 74: // ItemProgressionVisualRoot -> ADD, NAMEGROUP, STRING, ',', STRING, ',', STRING
#line 288 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeElement("RootGroups", new Dictionary<String, object> {
						{"NameGroup", Unwrap(ValueStack[ValueStack.Depth-5])},
						{"AffixType", Unwrap(ValueStack[ValueStack.Depth-3])},
						{"Icon", Unwrap(ValueStack[ValueStack.Depth-1])},
				}); }
#line default
        break;
      case 75: // DeltaModifierBoost -> NEW_BOOST, STRING, ',', INTEGER
#line 295 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeElement("Boosts", new Dictionary<String, object> {
						{"Boost", Unwrap(ValueStack[ValueStack.Depth-3])},
						{"Multiplier", Unwrap(ValueStack[ValueStack.Depth-1])},
				}); }
#line default
        break;
      case 76: // EquipmentGroup -> ADD_EQUIPMENTGROUP, EquipmentEntries
#line 300 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                                     { CurrentSemanticValue = MakeElement("EquipmentGroups", ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 77: // EquipmentEntries -> /* empty */
#line 302 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                               { CurrentSemanticValue = MakeCollection(); }
#line default
        break;
      case 78: // EquipmentEntries -> EquipmentEntries, EquipmentEntry
#line 303 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                                  { CurrentSemanticValue = AddElement(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 79: // EquipmentEntry -> ADD_EQUIPMENT_ENTRY, STRING
#line 306 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                            { CurrentSemanticValue = ValueStack[ValueStack.Depth-1]; }
#line default
        break;
      case 80: // ItemComboPropertyEntry -> NEW_ITEMCOMBOPROPERTYENTRY, EntrySubProperties
#line 308 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                                                      { CurrentSemanticValue = MakeElement("Entries", ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 81: // EntrySubProperties -> /* empty */
#line 310 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                 { CurrentSemanticValue = MakeDeclaration(); }
#line default
        break;
      case 82: // EntrySubProperties -> EntrySubProperties, EntryData
#line 311 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                               { CurrentSemanticValue = AddProperty(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 83: // SkillSetSkill -> ADD, SKILL, STRING
#line 314 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                 { CurrentSemanticValue = MakeElement("NameGroups", ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 84: // TreasureGroupWeaponCounter -> WEAPON_COUNTER, STRING, ',', STRING
#line 317 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(new [] {
					MakeProperty(LocationStack[LocationStack.Depth-3], "WeaponTreasureGroup", ValueStack[ValueStack.Depth-3]),
					MakeProperty(LocationStack[LocationStack.Depth-1], "WeaponDefaultCounter", ValueStack[ValueStack.Depth-1])
				}); }
#line default
        break;
      case 85: // TreasureGroupSkillbookCounter -> SKILLBOOK_COUNTER, STRING, ',', STRING
#line 323 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(new [] {
					MakeProperty(LocationStack[LocationStack.Depth-3], "SkillbookTreasureGroup", ValueStack[ValueStack.Depth-3]),
					MakeProperty(LocationStack[LocationStack.Depth-1], "SkillbookDefaultCounter", ValueStack[ValueStack.Depth-1])
				}); }
#line default
        break;
      case 86: // TreasureGroupArmorCounter -> ARMOR_COUNTER, STRING, ',', STRING
#line 329 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeDeclaration(new [] {
					MakeProperty(LocationStack[LocationStack.Depth-3], "ArmorTreasureGroup", ValueStack[ValueStack.Depth-3]),
					MakeProperty(LocationStack[LocationStack.Depth-1], "ArmorDefaultCounter", ValueStack[ValueStack.Depth-1])
				}); }
#line default
        break;
      case 87: // TreasureSubtable -> NEW_SUBTABLE, STRING, TreasureTableObjects
#line 335 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeElement("Subtables", 
					AddProperty(
						MakeDeclaration(new [] { MakeProperty(LocationStack[LocationStack.Depth-2], "DropCount", ValueStack[ValueStack.Depth-2]) }),
						ValueStack[ValueStack.Depth-1]
					));
				}
#line default
        break;
      case 88: // TreasureTableMinLevel -> MIN_LEVEL, STRING
#line 342 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                         { CurrentSemanticValue = MakeProperty(CurrentLocationSpan, "MinLevel", ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 89: // TreasureTableMaxLevel -> MAX_LEVEL, STRING
#line 344 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                         { CurrentSemanticValue = MakeProperty(CurrentLocationSpan, "MaxLevel", ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 90: // TreasureTableIgnoreLevelDiff -> IGNORE_LEVEL_DIFF, INTEGER
#line 346 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                                         { CurrentSemanticValue = MakeProperty(CurrentLocationSpan, "IgnoreLevelDiff", ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 91: // TreasureTableUseTreasureGroups -> USE_TREASURE_GROUPS, INTEGER
#line 348 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                                             { CurrentSemanticValue = MakeProperty(CurrentLocationSpan, "UseTreasureGroups", ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 92: // TreasureTableObjects -> /* empty */
#line 350 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                   { CurrentSemanticValue = MakeDeclaration(); }
#line default
        break;
      case 93: // TreasureTableObjects -> TreasureTableObjects, TreasureTableEntry
#line 351 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                                          { CurrentSemanticValue = AddProperty(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 97: // TreasureTableObjectStartLevel -> START_LEVEL, STRING
#line 359 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                                   { CurrentSemanticValue = MakeProperty(CurrentLocationSpan, "StartLevel", ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 98: // TreasureTableObjectEndLevel -> END_LEVEL, STRING
#line 361 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                                               { CurrentSemanticValue = MakeProperty(CurrentLocationSpan, "EndLevel", ValueStack[ValueStack.Depth-1]); }
#line default
        break;
      case 99: // TreasureTableObject -> OBJECT_CATEGORY, STRING, ',', INTEGER, ',', INTEGER, ',', 
               //                        INTEGER, ',', INTEGER, ',', INTEGER, ',', INTEGER, ',', 
               //                        INTEGER, ',', INTEGER
#line 364 "E:\source\repos\BG3_Tran\LSLib\\LS\Stats\Parser\Stat.yy"
                { CurrentSemanticValue = MakeElement("Objects", MakeDeclaration(new [] {
					MakeProperty("ObjectCategory", ValueStack[ValueStack.Depth-17]),
					MakeProperty("Frequency", ValueStack[ValueStack.Depth-15]),
					MakeProperty("Common", ValueStack[ValueStack.Depth-13]),
					MakeProperty("Uncommon", ValueStack[ValueStack.Depth-11]),
					MakeProperty("Rare", ValueStack[ValueStack.Depth-9]),
					MakeProperty("Epic", ValueStack[ValueStack.Depth-7]),
					MakeProperty("Legendary", ValueStack[ValueStack.Depth-5]),
					MakeProperty("Divine", ValueStack[ValueStack.Depth-3]),
					MakeProperty("Unique", ValueStack[ValueStack.Depth-1]),
					}));
				}
#line default
        break;
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((StatTokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((StatTokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}
