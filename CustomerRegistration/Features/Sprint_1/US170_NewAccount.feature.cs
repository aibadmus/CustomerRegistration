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
namespace UnitTestProject1.Features.Sprint_1
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("New customer registration", SourceFile="Features\\Sprint_1\\US170_NewAccount.feature", SourceLine=0)]
    public partial class NewCustomerRegistrationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "US170_NewAccount.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "New customer registration", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 3
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Password fields don\'t match", new string[] {
                "Password",
                "not",
                "matching"}, SourceLine=7)]
        public virtual void PasswordFieldsDonTMatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Password fields don\'t match", new string[] {
                        "Password",
                        "not",
                        "matching"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 10
testRunner.Given("I want to start an application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
testRunner.And("I do not already have an online account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Surname",
                        "EmailAddress",
                        "Password",
                        "Confirmpassword"});
            table1.AddRow(new string[] {
                        "Simon",
                        "Templer",
                        "Jamsonjjpppj907@0088.co.uk",
                        "Password123",
                        "WordPass123"});
#line 12
testRunner.When("I provide the details on the Application form: New account page", ((string)(null)), table1, "When ");
#line 15
testRunner.And("I click on the Enter a Password field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
testRunner.Then("an error message should appear that the password doesn\'t match", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Surname",
                        "EmailAddress",
                        "Password",
                        "Confirmpassword"});
            table2.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "Password123",
                        "Password123"});
#line 17
testRunner.And("I update the password to match", ((string)(null)), table2, "And ");
#line 20
testRunner.And("I click on the Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
testRunner.Then("the Application form: Business Details page should appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
testRunner.And("I close browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("The user provides incorrect details on the application form and clicks on registe" +
            "r", new string[] {
                "Incorrect",
                "Email",
                "Details"}, SourceLine=24)]
        public virtual void TheUserProvidesIncorrectDetailsOnTheApplicationFormAndClicksOnRegister()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user provides incorrect details on the application form and clicks on registe" +
                    "r", new string[] {
                        "Incorrect",
                        "Email",
                        "Details"});
#line 25
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 27
testRunner.Given("I want to start an application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
testRunner.And("I do not already have an online account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Surname",
                        "EmailAddress",
                        "Password",
                        "Confirmpassword"});
            table3.AddRow(new string[] {
                        "Simon",
                        "Templer",
                        "JamesBond.co.uk",
                        "Password123",
                        "Password123"});
#line 29
testRunner.When("I provide the details with an invalid email on the Application form: New account " +
                    "page", ((string)(null)), table3, "When ");
#line 32
testRunner.And("I click on the Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
testRunner.Then("an error message should appear that email should be in the format", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Surname",
                        "EmailAddress",
                        "Password",
                        "Confirmpassword"});
            table4.AddRow(new string[] {
                        "",
                        "",
                        "James00bbkhBond@.co.uk",
                        "Password123",
                        "Password123"});
#line 34
testRunner.And("I Update the email to the correct format", ((string)(null)), table4, "And ");
#line 37
testRunner.And("I click on the Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
testRunner.Then("the Application form: Business Details page should appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
testRunner.And("I close browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("The user provides details on the application form and clicks on register", SourceLine=41)]
        public virtual void TheUserProvidesDetailsOnTheApplicationFormAndClicksOnRegister()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user provides details on the application form and clicks on register", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 44
testRunner.Given("I want to start an application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
testRunner.And("I do not already have an online account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Surname",
                        "EmailAddress",
                        "Password",
                        "Confirmpassword"});
            table5.AddRow(new string[] {
                        "Simon",
                        "Templer",
                        "James0047ondk06@scotent.co.uk",
                        "Password123",
                        "Password123"});
#line 46
testRunner.When("I provide the details on the Application form: New account page", ((string)(null)), table5, "When ");
#line 49
testRunner.And("I click on the Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
testRunner.Then("the Application form: Business Details page should appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
testRunner.And("I close browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
    [NUnit.Framework.DescriptionAttribute("New customer registration")]
    public partial class NewCustomerRegistrationFeature_NUnit
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "US170_NewAccount.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "New customer registration", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 3
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Password fields don\'t match")]
        [NUnit.Framework.CategoryAttribute("Password")]
        [NUnit.Framework.CategoryAttribute("not")]
        [NUnit.Framework.CategoryAttribute("matching")]
        public virtual void PasswordFieldsDonTMatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Password fields don\'t match", new string[] {
                        "Password",
                        "not",
                        "matching"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 10
testRunner.Given("I want to start an application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
testRunner.And("I do not already have an online account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Surname",
                        "EmailAddress",
                        "Password",
                        "Confirmpassword"});
            table1.AddRow(new string[] {
                        "Simon",
                        "Templer",
                        "Jamsonjjpppj907@0088.co.uk",
                        "Password123",
                        "WordPass123"});
#line 12
testRunner.When("I provide the details on the Application form: New account page", ((string)(null)), table1, "When ");
#line 15
testRunner.And("I click on the Enter a Password field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
testRunner.Then("an error message should appear that the password doesn\'t match", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Surname",
                        "EmailAddress",
                        "Password",
                        "Confirmpassword"});
            table2.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "Password123",
                        "Password123"});
#line 17
testRunner.And("I update the password to match", ((string)(null)), table2, "And ");
#line 20
testRunner.And("I click on the Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
testRunner.Then("the Application form: Business Details page should appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
testRunner.And("I close browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user provides incorrect details on the application form and clicks on registe" +
            "r")]
        [NUnit.Framework.CategoryAttribute("Incorrect")]
        [NUnit.Framework.CategoryAttribute("Email")]
        [NUnit.Framework.CategoryAttribute("Details")]
        public virtual void TheUserProvidesIncorrectDetailsOnTheApplicationFormAndClicksOnRegister()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user provides incorrect details on the application form and clicks on registe" +
                    "r", new string[] {
                        "Incorrect",
                        "Email",
                        "Details"});
#line 25
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 27
testRunner.Given("I want to start an application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
testRunner.And("I do not already have an online account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Surname",
                        "EmailAddress",
                        "Password",
                        "Confirmpassword"});
            table3.AddRow(new string[] {
                        "Simon",
                        "Templer",
                        "JamesBond.co.uk",
                        "Password123",
                        "Password123"});
#line 29
testRunner.When("I provide the details with an invalid email on the Application form: New account " +
                    "page", ((string)(null)), table3, "When ");
#line 32
testRunner.And("I click on the Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
testRunner.Then("an error message should appear that email should be in the format", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Surname",
                        "EmailAddress",
                        "Password",
                        "Confirmpassword"});
            table4.AddRow(new string[] {
                        "",
                        "",
                        "James00bbkhBond@.co.uk",
                        "Password123",
                        "Password123"});
#line 34
testRunner.And("I Update the email to the correct format", ((string)(null)), table4, "And ");
#line 37
testRunner.And("I click on the Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
testRunner.Then("the Application form: Business Details page should appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
testRunner.And("I close browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user provides details on the application form and clicks on register")]
        public virtual void TheUserProvidesDetailsOnTheApplicationFormAndClicksOnRegister()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user provides details on the application form and clicks on register", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 44
testRunner.Given("I want to start an application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
testRunner.And("I do not already have an online account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Surname",
                        "EmailAddress",
                        "Password",
                        "Confirmpassword"});
            table5.AddRow(new string[] {
                        "Simon",
                        "Templer",
                        "James0047ondk06@scotent.co.uk",
                        "Password123",
                        "Password123"});
#line 46
testRunner.When("I provide the details on the Application form: New account page", ((string)(null)), table5, "When ");
#line 49
testRunner.And("I click on the Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
testRunner.Then("the Application form: Business Details page should appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
testRunner.And("I close browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion