﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Warewolf.ToolsSpecs.Toolbox.Recordset.Length
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class LengthFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Length.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Length", "In order to get the length of a records\r\nAs a Warewolf user\r\nI want a tool that t" +
                    "akes a record set gives me its length", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Length")))
            {
                Warewolf.ToolsSpecs.Toolbox.Recordset.Length.LengthFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Length of a recordset with 3 rows")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Length")]
        public virtual void LengthOfARecordsetWith3Rows()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Length of a recordset with 3 rows", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "[[rs]]",
                        ""});
            table1.AddRow(new string[] {
                        "rs(1).row",
                        "1"});
            table1.AddRow(new string[] {
                        "rs(3).row",
                        "2"});
            table1.AddRow(new string[] {
                        "rs(5).row",
                        "3"});
#line 7
 testRunner.Given("I get the length from a recordset that looks like with this shape", ((string)(null)), table1, "Given ");
#line 12
 testRunner.And("get length on record \"[[rs()]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.When("the length tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("the length result should be 5", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Recordset"});
            table2.AddRow(new string[] {
                        "[[rs(1).row]] = 1"});
            table2.AddRow(new string[] {
                        "[[rs(3).row]] = 2"});
            table2.AddRow(new string[] {
                        "[[rs(5).row]] = 3"});
#line 16
 testRunner.And("the debug inputs as", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table3.AddRow(new string[] {
                        "[[result]] = 5"});
#line 21
 testRunner.And("the debug output as", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Length of a recordset with 8 rows")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Length")]
        public virtual void LengthOfARecordsetWith8Rows()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Length of a recordset with 8 rows", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        ""});
            table4.AddRow(new string[] {
                        "rs(1).row",
                        "1"});
            table4.AddRow(new string[] {
                        "rs(2).row",
                        "2"});
            table4.AddRow(new string[] {
                        "rs(3).row",
                        "3"});
            table4.AddRow(new string[] {
                        "rs(4).row",
                        "4"});
            table4.AddRow(new string[] {
                        "rs(5).row",
                        "5"});
            table4.AddRow(new string[] {
                        "rs(6).row",
                        "6"});
            table4.AddRow(new string[] {
                        "rs(7).row",
                        "7"});
            table4.AddRow(new string[] {
                        "rs(8).row",
                        "8"});
#line 26
 testRunner.Given("I get the length from a recordset that looks like with this shape", ((string)(null)), table4, "Given ");
#line 36
 testRunner.And("get length on record \"[[rs()]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.When("the length tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("the length result should be 8", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Recordset"});
            table5.AddRow(new string[] {
                        "[[rs(1).row]] =  1"});
            table5.AddRow(new string[] {
                        "[[rs(2).row]] =  2"});
            table5.AddRow(new string[] {
                        "[[rs(3).row]] =  3"});
            table5.AddRow(new string[] {
                        "[[rs(4).row]] =  4"});
            table5.AddRow(new string[] {
                        "[[rs(5).row]] =  5"});
            table5.AddRow(new string[] {
                        "[[rs(6).row]] =  6"});
            table5.AddRow(new string[] {
                        "[[rs(7).row]] =  7"});
            table5.AddRow(new string[] {
                        "[[rs(8).row]] =  8"});
#line 40
 testRunner.And("the debug inputs as", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table6.AddRow(new string[] {
                        "[[result]] = 8"});
#line 50
 testRunner.And("the debug output as", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Recordset length for coloumn")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Length")]
        public virtual void RecordsetLengthForColoumn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recordset length for coloumn", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        ""});
            table7.AddRow(new string[] {
                        "rs(1).row",
                        "1"});
            table7.AddRow(new string[] {
                        "rs(2).row",
                        "2"});
            table7.AddRow(new string[] {
                        "rs(3).row",
                        "3"});
            table7.AddRow(new string[] {
                        "rs(4).row",
                        "4"});
            table7.AddRow(new string[] {
                        "rs(5).row",
                        "5"});
            table7.AddRow(new string[] {
                        "rs(6).row",
                        "6"});
            table7.AddRow(new string[] {
                        "rs(7).row",
                        "7"});
            table7.AddRow(new string[] {
                        "rs(8).row",
                        "8"});
#line 55
 testRunner.Given("I get the length from a recordset that looks like with this shape", ((string)(null)), table7, "Given ");
#line 65
 testRunner.And("get length on record \"[[rs().row]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.When("the length tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Recordset"});
#line 68
 testRunner.And("the debug inputs as", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
#line 70
 testRunner.And("the debug output as", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Recordset length for coloumns invalid")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Length")]
        public virtual void RecordsetLengthForColoumnsInvalid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recordset length for coloumns invalid", ((string[])(null)));
#line 73
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        ""});
            table10.AddRow(new string[] {
                        "rs().row",
                        "1"});
            table10.AddRow(new string[] {
                        "rs().row",
                        "2"});
            table10.AddRow(new string[] {
                        "rs().row",
                        "3"});
            table10.AddRow(new string[] {
                        "rs().row",
                        "4"});
            table10.AddRow(new string[] {
                        "rs().row2",
                        "5"});
            table10.AddRow(new string[] {
                        "rs().row2",
                        "6"});
            table10.AddRow(new string[] {
                        "rs().row2",
                        "7"});
#line 74
 testRunner.Given("I get the length from a recordset that looks like with this shape", ((string)(null)), table10, "Given ");
#line 83
 testRunner.And("get length on record \"[[rs().row]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.When("the length tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Recordset"});
#line 86
 testRunner.And("the debug inputs as", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
#line 88
 testRunner.And("the debug output as", ((string)(null)), table12, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Recordset length")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Length")]
        public virtual void RecordsetLength()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recordset length", ((string[])(null)));
#line 91
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        ""});
            table13.AddRow(new string[] {
                        "rs().row",
                        "1"});
            table13.AddRow(new string[] {
                        "rs().row",
                        "2"});
            table13.AddRow(new string[] {
                        "rs().row",
                        "3"});
            table13.AddRow(new string[] {
                        "rs().row",
                        "4"});
            table13.AddRow(new string[] {
                        "rs().row2",
                        "5"});
            table13.AddRow(new string[] {
                        "rs().row2",
                        "6"});
            table13.AddRow(new string[] {
                        "rs().row2",
                        "7"});
#line 92
 testRunner.Given("I get the length from a recordset that looks like with this shape", ((string)(null)), table13, "Given ");
#line 101
 testRunner.And("get length on record \"[[rs()]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.When("the length tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.Then("the length result should be 6", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Recordset"});
            table14.AddRow(new string[] {
                        "[[rs(1).row]] =  1"});
            table14.AddRow(new string[] {
                        "[[rs(2).row]] =  2"});
            table14.AddRow(new string[] {
                        "[[rs(3).row]] =  3"});
            table14.AddRow(new string[] {
                        "[[rs(4).row]] =  4"});
            table14.AddRow(new string[] {
                        "[[rs(4).row2]] =  5"});
            table14.AddRow(new string[] {
                        "[[rs(5).row2]] =  6"});
            table14.AddRow(new string[] {
                        "[[rs(6).row2]] =  7"});
#line 105
 testRunner.And("the debug inputs as", ((string)(null)), table14, "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table15.AddRow(new string[] {
                        "[[result]] = 6"});
#line 114
 testRunner.And("the debug output as", ((string)(null)), table15, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Recordset length for invalid recordset")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Length")]
        public virtual void RecordsetLengthForInvalidRecordset()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recordset length for invalid recordset", ((string[])(null)));
#line 118
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        ""});
            table16.AddRow(new string[] {
                        "rs(1).row",
                        "1"});
            table16.AddRow(new string[] {
                        "rs(2).row",
                        "2"});
            table16.AddRow(new string[] {
                        "rs(3).row",
                        "3"});
            table16.AddRow(new string[] {
                        "rs(4).row",
                        "4"});
            table16.AddRow(new string[] {
                        "rs(5).row",
                        "5"});
            table16.AddRow(new string[] {
                        "rs(6).row",
                        "6"});
            table16.AddRow(new string[] {
                        "rs(7).row",
                        "7"});
            table16.AddRow(new string[] {
                        "rs(8).row",
                        "8"});
#line 119
 testRunner.Given("I get the length from a recordset that looks like with this shape", ((string)(null)), table16, "Given ");
#line 129
 testRunner.And("get length on record \"[[rs().&^]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
 testRunner.When("the length tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 131
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Recordset"});
#line 132
 testRunner.And("the debug inputs as", ((string)(null)), table17, "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
#line 134
 testRunner.And("the debug output as", ((string)(null)), table18, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void EnsureRecordsetLengthInputsWorkAsExpected(string variable, string val, string error, string message, string result, string value, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ensure Recordset length inputs work as expected", exampleTags);
#line 137
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        ""});
            table19.AddRow(new string[] {
                        "rs().row",
                        "1"});
            table19.AddRow(new string[] {
                        "rs().row",
                        "2"});
            table19.AddRow(new string[] {
                        "rs().row",
                        "3"});
            table19.AddRow(new string[] {
                        "rs().row",
                        "4"});
            table19.AddRow(new string[] {
                        "rs().row2",
                        "5"});
            table19.AddRow(new string[] {
                        "rs().row2",
                        "6"});
            table19.AddRow(new string[] {
                        "rs().row2",
                        "7"});
#line 138
 testRunner.Given("I get the length from a recordset that looks like with this shape", ((string)(null)), table19, "Given ");
#line 147
 testRunner.And(string.Format("get length on record \"{0}\"", variable), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
 testRunner.When("the length tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 149
 testRunner.Then(string.Format("the execution has \"{0}\" error", error), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Ensure Recordset length inputs work as expected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Length")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "[[a]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:variable", "[[a]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:val", "The")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Error", "AN")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:message", "Scalar not allowed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "[[b]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "[[b]] = failure")]
        public virtual void EnsureRecordsetLengthInputsWorkAsExpected_A()
        {
            this.EnsureRecordsetLengthInputsWorkAsExpected("[[a]]", "The", "AN", "Scalar not allowed", "[[b]]", "[[b]] = failure", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Ensure Recordset length inputs work as expected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Length")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "\"\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:variable", "\"\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:val", "\"\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Error", "AN")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:message", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "[[rec(1).a]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "0")]
        public virtual void EnsureRecordsetLengthInputsWorkAsExpected_()
        {
            this.EnsureRecordsetLengthInputsWorkAsExpected("\"\"", "\"\"", "AN", "", "[[rec(1).a]]", "0", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Ensure Recordset length inputs work as expected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Length")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "dfsd")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:variable", "dfsd")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:val", "dfsd")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Error", "AN")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:message", "Invalid characters have been entered as Recordset")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "[[rec(*).a]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Failure")]
        public virtual void EnsureRecordsetLengthInputsWorkAsExpected_Dfsd()
        {
            this.EnsureRecordsetLengthInputsWorkAsExpected("dfsd", "dfsd", "AN", "Invalid characters have been entered as Recordset", "[[rec(*).a]]", "Failure", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Ensure Recordset length inputs work as expected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Length")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "12")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:variable", "12")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:val", "12")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Error", "AN")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:message", "Invalid characters have been entered as Recordset")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "[[rec([[int]]).a]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Failure")]
        public virtual void EnsureRecordsetLengthInputsWorkAsExpected_12()
        {
            this.EnsureRecordsetLengthInputsWorkAsExpected("12", "12", "AN", "Invalid characters have been entered as Recordset", "[[rec([[int]]).a]]", "Failure", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Ensure Recordset length inputs work as expected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Length")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "[[rec(1)]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:variable", "[[rec(1)]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:val", "\"\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Error", "AN")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:message", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "[[rs().a]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "[[rs(1).a]] = 3")]
        public virtual void EnsureRecordsetLengthInputsWorkAsExpected_Rec1()
        {
            this.EnsureRecordsetLengthInputsWorkAsExpected("[[rec(1)]]", "\"\"", "AN", "", "[[rs().a]]", "[[rs(1).a]] = 3", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Ensure Recordset length inputs work as expected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Length")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "[[rec(*)]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:variable", "[[rec(*)]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:val", "\"\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Error", "AN")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:message", "Blank result variable")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "\"\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "\"\"")]
        public virtual void EnsureRecordsetLengthInputsWorkAsExpected_Rec()
        {
            this.EnsureRecordsetLengthInputsWorkAsExpected("[[rec(*)]]", "\"\"", "AN", "Blank result variable", "\"\"", "\"\"", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Ensure Recordset length inputs work as expected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Length")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "[[rec([[int]])]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:variable", "[[rec([[int]])]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:val", "\"\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Error", "AN")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:message", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "[[sdasd]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "3")]
        public virtual void EnsureRecordsetLengthInputsWorkAsExpected_RecInt()
        {
            this.EnsureRecordsetLengthInputsWorkAsExpected("[[rec([[int]])]]", "\"\"", "AN", "", "[[sdasd]]", "3", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Ensure Recordset length inputs work as expected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Length")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "[[c]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:variable", "[[c]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:val", "\"\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Error", "AN")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:message", "Scalar not allowed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "[[d]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Failure")]
        public virtual void EnsureRecordsetLengthInputsWorkAsExpected_C()
        {
            this.EnsureRecordsetLengthInputsWorkAsExpected("[[c]]", "\"\"", "AN", "Scalar not allowed", "[[d]]", "Failure", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Length of an null recordset")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Length")]
        public virtual void LengthOfAnNullRecordset()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Length of an null recordset", ((string[])(null)));
#line 161
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        ""});
            table20.AddRow(new string[] {
                        "[[rs().row]]",
                        "NULL"});
#line 162
 testRunner.Given("I get the length from a recordset that looks like with this shape", ((string)(null)), table20, "Given ");
#line 165
 testRunner.And("get length on record \"[[rs()]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 166
 testRunner.When("the length tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 167
 testRunner.Then("the length result should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 168
 testRunner.And("the execution has \"No\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Length of an unassigned recordset")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Length")]
        public virtual void LengthOfAnUnassignedRecordset()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Length of an unassigned recordset", ((string[])(null)));
#line 170
this.ScenarioSetup(scenarioInfo);
#line 171
 testRunner.Given("get length on record \"[[rs()]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 172
 testRunner.When("the length tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 173
 testRunner.Then("the execution has \"An\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
