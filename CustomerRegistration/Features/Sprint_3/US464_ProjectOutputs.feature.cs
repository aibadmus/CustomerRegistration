﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UnitTestProject1.Features.Sprint_3
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("US464_ProjectOutputs", SourceFile="Features\\Sprint_3\\US464_ProjectOutputs.feature", SourceLine=0)]
    public partial class US464_ProjectOutputsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "US464_ProjectOutputs.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "US464_ProjectOutputs", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Page is displayed", SourceLine=2)]
        public virtual void PageIsDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Page is displayed", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("I am completing an application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
testRunner.When("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
testRunner.Then("I can see the progress indicator control", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 7
testRunner.And("I can see the Save And continue button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
testRunner.And("I can see the Save And go back button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
testRunner.And("I can see the Business benefits text box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
testRunner.And("I can see the Turnover question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
testRunner.And("I can see the International revenue question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
testRunner.And("I can see the Staff question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
testRunner.And("I can see the High value jobs question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
testRunner.And("I can see the Safeguarding question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
testRunner.And("I can see the Savings question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Help is displayed", SourceLine=16)]
        public virtual void HelpIsDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Help is displayed", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
testRunner.Given("I am completing an application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
testRunner.When("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
testRunner.Then(@"the help text 'Please tell us the business benefits of the project. This could be a new or improved product, service or process; improved leadership or management capability; improved ICT or other infrastructure; new markets entered; improved knowledge; efficiency gains. 1000 characters is around 200 words.' is displayed under the Business benefits question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
testRunner.And("the help text \'Please give us information as a direct result of your business in " +
                    "ScotlAnd And not your business as a whole. Tell us what you think the impact wil" +
                    "l be in years 1, 2 And 3.\' is displayed under the heading Long term benefits of " +
                    "this project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
testRunner.And("the help text \'High value jobs are jobs with a salary more than £36,321 per annum" +
                    ".\' is displayed under the High value jobs question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("selecting \'yes\' to the turnover question", SourceLine=23)]
        public virtual void SelectingYesToTheTurnoverQuestion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("selecting \'yes\' to the turnover question", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
testRunner.When("I select \'yes\' to the turnover question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
testRunner.Then("a text box appears with the label Turnover for last financial year", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
testRunner.And("a text box appears with the label Year 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
testRunner.And("a text box appears with the label Year 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
testRunner.And("a text box appears with the label Year 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("selecting \'yes\' to the international revenue question", SourceLine=31)]
        public virtual void SelectingYesToTheInternationalRevenueQuestion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("selecting \'yes\' to the international revenue question", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
testRunner.When("I select \'yes\' to the international revenue question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
testRunner.Then("a text box appears with the label Current international revenue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
testRunner.And("a text box appears with the label Year 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
testRunner.And("a text box appears with the label Year 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
testRunner.And("a text box appears with the label Year 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("selecting \'yes\' to the creating more jobs question", SourceLine=39)]
        public virtual void SelectingYesToTheCreatingMoreJobsQuestion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("selecting \'yes\' to the creating more jobs question", ((string[])(null)));
#line 40
this.ScenarioSetup(scenarioInfo);
#line 41
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
testRunner.When("I select \'yes\' to the jobs question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
testRunner.Then("a text box appears with the label Year 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
testRunner.And("a text box appears with the label Year 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
testRunner.And("a text box appears with the label Year 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("selecting \'yes\' to the high value jobs question", SourceLine=46)]
        public virtual void SelectingYesToTheHighValueJobsQuestion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("selecting \'yes\' to the high value jobs question", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
testRunner.When("I select \'yes\' to the high value jobs question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
testRunner.Then("a text box appears with the label Current number of high value jobs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
testRunner.And("a text box appears with the label Year 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
testRunner.And("a text box appears with the label Year 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
testRunner.And("a text box appears with the label Year 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("selecting \'yes\' to the safeguarding jobs question", SourceLine=54)]
        public virtual void SelectingYesToTheSafeguardingJobsQuestion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("selecting \'yes\' to the safeguarding jobs question", ((string[])(null)));
#line 55
this.ScenarioSetup(scenarioInfo);
#line 56
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
testRunner.When("I select \'yes\' to the safeguarding jobs question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
testRunner.Then("a text box appears with the label Year 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
testRunner.And("a text box appears with the label Year 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
testRunner.And("a text box appears with the label Year 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("selecting \'yes\' to the savings question", SourceLine=61)]
        public virtual void SelectingYesToTheSavingsQuestion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("selecting \'yes\' to the savings question", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
testRunner.When("I select \'yes\' to the savings question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
testRunner.Then("a text box appears with the label Year 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
testRunner.And("a text box appears with the label Year 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
testRunner.And("a text box appears with the label Year 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("entering incompatible data in any form field", SourceLine=68)]
        public virtual void EnteringIncompatibleDataInAnyFormField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("entering incompatible data in any form field", ((string[])(null)));
#line 69
this.ScenarioSetup(scenarioInfo);
#line 70
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 71
testRunner.When("I enter incompatible characters in any form field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
testRunner.Then("I should receive an appropriate validation error message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("completing the form fields And moving to the next page", SourceLine=73)]
        public virtual void CompletingTheFormFieldsAndMovingToTheNextPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("completing the form fields And moving to the next page", ((string[])(null)));
#line 74
this.ScenarioSetup(scenarioInfo);
#line 75
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 76
testRunner.And("all mAndatory form fields contain data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
testRunner.When("I click on the Save And continue button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
testRunner.Then("the External consultants page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("leaving any mAndatory field blank", SourceLine=79)]
        public virtual void LeavingAnyMAndatoryFieldBlank()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("leaving any mAndatory field blank", ((string[])(null)));
#line 80
this.ScenarioSetup(scenarioInfo);
#line 81
testRunner.Given("I am on the Project outputs Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 82
testRunner.And("any mAndatory form field does not contain data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
testRunner.When("I click on the Save And continue button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
testRunner.Then("I should receive an appropriate validation error message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
testRunner.And("focus should return to first blank mAndatory form field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("moving to the previous page", SourceLine=86)]
        public virtual void MovingToThePreviousPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("moving to the previous page", ((string[])(null)));
#line 87
this.ScenarioSetup(scenarioInfo);
#line 88
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 89
testRunner.When("I click on the Save And go back button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
testRunner.Then("the Project details page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("US464_ProjectOutputs")]
    public partial class US464_ProjectOutputsFeature_NUnit
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "US464_ProjectOutputs.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "US464_ProjectOutputs", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Page is displayed")]
        public virtual void PageIsDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Page is displayed", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("I am completing an application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
testRunner.When("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
testRunner.Then("I can see the progress indicator control", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 7
testRunner.And("I can see the Save And continue button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
testRunner.And("I can see the Save And go back button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
testRunner.And("I can see the Business benefits text box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
testRunner.And("I can see the Turnover question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
testRunner.And("I can see the International revenue question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
testRunner.And("I can see the Staff question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
testRunner.And("I can see the High value jobs question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
testRunner.And("I can see the Safeguarding question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
testRunner.And("I can see the Savings question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Help is displayed")]
        public virtual void HelpIsDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Help is displayed", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
testRunner.Given("I am completing an application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
testRunner.When("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
testRunner.Then(@"the help text 'Please tell us the business benefits of the project. This could be a new or improved product, service or process; improved leadership or management capability; improved ICT or other infrastructure; new markets entered; improved knowledge; efficiency gains. 1000 characters is around 200 words.' is displayed under the Business benefits question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
testRunner.And("the help text \'Please give us information as a direct result of your business in " +
                    "ScotlAnd And not your business as a whole. Tell us what you think the impact wil" +
                    "l be in years 1, 2 And 3.\' is displayed under the heading Long term benefits of " +
                    "this project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
testRunner.And("the help text \'High value jobs are jobs with a salary more than £36,321 per annum" +
                    ".\' is displayed under the High value jobs question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("selecting \'yes\' to the turnover question")]
        public virtual void SelectingYesToTheTurnoverQuestion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("selecting \'yes\' to the turnover question", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
testRunner.When("I select \'yes\' to the turnover question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
testRunner.Then("a text box appears with the label Turnover for last financial year", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
testRunner.And("a text box appears with the label Year 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
testRunner.And("a text box appears with the label Year 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
testRunner.And("a text box appears with the label Year 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("selecting \'yes\' to the international revenue question")]
        public virtual void SelectingYesToTheInternationalRevenueQuestion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("selecting \'yes\' to the international revenue question", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
testRunner.When("I select \'yes\' to the international revenue question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
testRunner.Then("a text box appears with the label Current international revenue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
testRunner.And("a text box appears with the label Year 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
testRunner.And("a text box appears with the label Year 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
testRunner.And("a text box appears with the label Year 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("selecting \'yes\' to the creating more jobs question")]
        public virtual void SelectingYesToTheCreatingMoreJobsQuestion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("selecting \'yes\' to the creating more jobs question", ((string[])(null)));
#line 40
this.ScenarioSetup(scenarioInfo);
#line 41
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
testRunner.When("I select \'yes\' to the jobs question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
testRunner.Then("a text box appears with the label Year 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
testRunner.And("a text box appears with the label Year 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
testRunner.And("a text box appears with the label Year 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("selecting \'yes\' to the high value jobs question")]
        public virtual void SelectingYesToTheHighValueJobsQuestion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("selecting \'yes\' to the high value jobs question", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
testRunner.When("I select \'yes\' to the high value jobs question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
testRunner.Then("a text box appears with the label Current number of high value jobs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
testRunner.And("a text box appears with the label Year 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
testRunner.And("a text box appears with the label Year 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
testRunner.And("a text box appears with the label Year 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("selecting \'yes\' to the safeguarding jobs question")]
        public virtual void SelectingYesToTheSafeguardingJobsQuestion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("selecting \'yes\' to the safeguarding jobs question", ((string[])(null)));
#line 55
this.ScenarioSetup(scenarioInfo);
#line 56
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
testRunner.When("I select \'yes\' to the safeguarding jobs question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
testRunner.Then("a text box appears with the label Year 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
testRunner.And("a text box appears with the label Year 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
testRunner.And("a text box appears with the label Year 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("selecting \'yes\' to the savings question")]
        public virtual void SelectingYesToTheSavingsQuestion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("selecting \'yes\' to the savings question", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
testRunner.When("I select \'yes\' to the savings question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
testRunner.Then("a text box appears with the label Year 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
testRunner.And("a text box appears with the label Year 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
testRunner.And("a text box appears with the label Year 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("entering incompatible data in any form field")]
        public virtual void EnteringIncompatibleDataInAnyFormField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("entering incompatible data in any form field", ((string[])(null)));
#line 69
this.ScenarioSetup(scenarioInfo);
#line 70
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 71
testRunner.When("I enter incompatible characters in any form field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
testRunner.Then("I should receive an appropriate validation error message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("completing the form fields And moving to the next page")]
        public virtual void CompletingTheFormFieldsAndMovingToTheNextPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("completing the form fields And moving to the next page", ((string[])(null)));
#line 74
this.ScenarioSetup(scenarioInfo);
#line 75
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 76
testRunner.And("all mAndatory form fields contain data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
testRunner.When("I click on the Save And continue button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
testRunner.Then("the External consultants page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("leaving any mAndatory field blank")]
        public virtual void LeavingAnyMAndatoryFieldBlank()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("leaving any mAndatory field blank", ((string[])(null)));
#line 80
this.ScenarioSetup(scenarioInfo);
#line 81
testRunner.Given("I am on the Project outputs Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 82
testRunner.And("any mAndatory form field does not contain data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
testRunner.When("I click on the Save And continue button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
testRunner.Then("I should receive an appropriate validation error message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
testRunner.And("focus should return to first blank mAndatory form field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("moving to the previous page")]
        public virtual void MovingToThePreviousPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("moving to the previous page", ((string[])(null)));
#line 87
this.ScenarioSetup(scenarioInfo);
#line 88
testRunner.Given("I am on the Project outputs page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 89
testRunner.When("I click on the Save And go back button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
testRunner.Then("the Project details page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
