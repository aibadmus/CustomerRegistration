using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace UnitTestProject1
{
    [Binding]
    public class BusinessDetailsPageSteps
    {
        IWebDriver driver;
        [Given(@"I am a logged in user")]
        public void GivenIAmALoggedInUser()
        {
            driver = new ChromeDriver(@"C:\Users\aibad\Test\chromedriver");
            driver.Navigate().GoToUrl("http://qa1grantweb.azurewebsites.net/grants/home");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
            driver.FindElement(By.Id("start-application")).Click();

        }
        
        [Given(@"I am on the Business Details page")]
        public void GivenIAmOnTheBusinessDetailsPage()
        {
            driver.FindElement(By.CssSelector("#progress--indicator > li.current--step > a")).GetAttribute("Business details");
        }
        
        [Given(@"all mandatory form fields contain data")]
        public void GivenAllMAndatoryFormFieldsContainData()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"any mandatory form field does not contain data")]
        public void GivenAnyMAndatoryFormFieldDoesNotContainData()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I am on the Business Details page")]
        public void WhenIAmOnTheBusinessDetailsPage()
        {
            driver.FindElement(By.Id("page--content")).Click();

        }

        [When(@"I focus on the Company Name field")]
        public void WhenIFocusOnTheCompanyNameField()
        {
            driver.FindElement(By.Id("companyName")).Click();
        }
        
        [When(@"I focus on the Companies House registration number field")]
        public void WhenIFocusOnTheCompaniesHouseRegistrationNumberField()
        {
            driver.FindElement(By.Id("companyRegNo")).Click();
        }

        [When(@"I focus on the Is the company an SME field")]
        public void WhenIFocusOnTheIsTheCompanyAnSME_Field()
        {
            driver.FindElement(By.Id("companyTypeSME")).Click();
        }

        [When(@"I focus on the Company Turnover field")]
        public void WhenIFocusOnTheCompanyTurnoverField()
        {
            driver.FindElement(By.Id("companyTurnover")).Click();
        }

        [When(@"I focus on the Number of employees field")]
        public void WhenIFocusOnTheNumberOfEmployeesField()
        {
            driver.FindElement(By.Id("numberOfEmployees")).Click();
        }
        
        [When(@"I click on the Save & Continue button")]
        public void WhenIClickOnTheSaveContinueButton()
        {
            driver.FindElement(By.Id("saveApplicationCont")).Click();
        }
        
        [When(@"I click on the Save & Go Back button")]
        public void WhenIClickOnTheSaveGoBackButton()
        {
            driver.FindElement(By.Id("saveApplicationBack")).Click();
        }
        
        [Then(@"I can see the progress indicator control")]
        public void ThenICanSeeTheProgressIndicatorControl()
        {
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            //driver.FindElement(By.CssSelector("#progress--indicator > li.current--step > a > span")).GetAttribute("light");
            //bool status = driver.FindElement(By.Id("progress--indicator")).Displayed;
            IWebDriver driver = new RemoteWebDriver(DesiredCapabilities.Chrome());
            IWebElement body = driver.FindElement(By.TagName("body"));

            Assert.IsTrue(body.Text.Contains("progress--indicator"));

        }

        [Then(@"I can see the Save & Go Back button")]
        public void ThenICanSeeTheSaveGoBackButton()
        {
            driver.FindElement(By.Id("saveApplicationBack")).Equals("Save & Go Back");

        }

        [Then(@"I can see the Save &Continue button")]
        public void ThenICanSeeTheSaveContinueButton()
        {
            driver.FindElement(By.Id("saveApplicationCont")).Equals("Save and continue");
        }
        
        [Then(@"I can see the Company name field")]
        public void ThenICanSeeTheCompanyNameField()
        {
            bool status = driver.FindElement(By.Id("companyName")).Displayed;

        }

        [Then(@"I can see the Companies House Registration Number field")]
        public void ThenICanSeeTheCompaniesHouseRegistrationNumberField()
        {
            bool status = driver.FindElement(By.Id("companyRegNo")).Displayed;
            
        }

        [Then(@"I can see the SME field")]
        public void ThenICanSeeTheSMEField()
        {
            bool status = driver.FindElement(By.Id("companyTypeSME")).Displayed;
        }

        [Then(@"I can see the Company Turnover field")]
        public void ThenICanSeeTheCompanyTurnoverField()
        {
            bool status = driver.FindElement(By.Id("companyTurnover")).Displayed;
    
        }

        [Then(@"I can see the Number of Employees field")]
        public void ThenICanSeeTheNumberOfEmployeesField()
        {
            bool status = driver.FindElement(By.Id("numberOfEmployees")).Displayed;
        }

        [Then(@"the help text '(.*)' is displayed")]
        public void ThenTheHelpTextIsDisplayed(string p0)
        {
            driver.FindElement(By.CssSelector("body")).Text.Contains("The name your company is registered as at Companies House");
        }
        
        [Then(@"I should receive an appropriate validation error message for the company Turnover details")]
        public void ThenIShouldReceiveAnAppropriateValidationErrorMessage()
        {
            driver.FindElement(By.CssSelector("body")).Text.Contains("Company turnover is required");
        }

        [Then(@"the Project Details page is displayed")]
        public void ThenTheProjectDetailsPageIsDisplayed()
        {
            driver.FindElement(By.CssSelector("body")).Text.Contains("project-details");

        }

        [Then(@"focus should return to first blank mandatory form field")]
        public void ThenFocusShouldReturnToFirstBlankMAndatoryFormField()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Your Details page is displayed")]
        public void ThenTheYourDetailsPageIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"any previously entered data appears")]
        public void ThenAnyPreviouslyEnteredDataAppears()
        {
            ScenarioContext.Current.Pending();
        }
        [Then(@"the help text for SME '(.*)' is displayed")]
        public void ThenTheHelpTextForSMEIsDisplayed(string p0)
        {
            driver.FindElement(By.CssSelector("body")).Text.Contains("An SME is an enterprise which employ fewer than 250 persons And which has an annual turnover not exceeding 50 million euro, And/or an annual balance sheet total not exceeding 43 million euro And is independent. An independent enterprise:  no more than 25% of the capital or voting rights are owned by one or more enterprises which fall outside the SME definition.");

        }
        [Then(@"the help info for registration number text '(.*)' is displayed")]
        public void ThenTheHelpInfoForRegistrationNumberTextIsDisplayed(string p0)
        {
            driver.FindElement(By.CssSelector("body")).Text.Contains("The registration number of your business can be found on the Companies House website");
        }

        [Then(@"the help info for  Company Turnover text '(.*)' is displayed")]
        public void ThenTheHelpInfoForCompanyTurnoverTextIsDisplayed(string p0)
        {
            driver.FindElement(By.CssSelector("body")).Text.Contains("The total global turnover of your business at its latest financial year end in pounds sterling.");
        }

        [Then(@"the help info of Number of employee text '(.*)' is displayed")]
        public void ThenTheHelpInfoOfNumberOfEmployeeTextIsDisplayed(string p0)
        {
            driver.FindElement(By.CssSelector("body")).Text.Contains("Total global full time equivalent job numbers at latest financial year end.");

        }
        [Then(@"I close business details page")]
        public void ThenICloseBusinessDetailsPage()
        {
            driver.Quit();
        }
        [When(@"I enter incompatible characters in any form field")]
        public void WhenIEnterIncompatibleCharactersInAnyFormField(Table table)
        {

            BusinessDetails details = table.CreateInstance<BusinessDetails>();
            driver.FindElement(By.Id("companyName")).SendKeys(details.CompanyName);
            driver.FindElement(By.Id("companyRegNo")).SendKeys(details.CompanyRegNo);
            driver.FindElement(By.Id("companyTurnover")).SendKeys(details.CompanyTurnover);
            driver.FindElement(By.Id("numberOfEmployees")).SendKeys(details.NumberofEmployees);

        }
        [Then(@"I should receive an appropriate validation error message for the Number of Employee")]
        public void ThenIShouldReceiveAnAppropriateValidationErrorMessageForTheNumberOfEmployee()
        {
            driver.FindElement(By.CssSelector("body")).Text.Contains("Number of employees is required");
        }
        [Given(@"all mandatory form fields contain data")]
        public void GivenAllMandatoryFormFieldsContainData(Table table)
        {
            BusinessDetails details = table.CreateInstance<BusinessDetails>();
            driver.FindElement(By.Id("companyName")).SendKeys(details.CompanyName);
            driver.FindElement(By.Id("companyRegNo")).SendKeys(details.CompanyRegNo);
            driver.FindElement(By.Id("companyTurnover")).SendKeys(details.CompanyTurnover);
            driver.FindElement(By.Id("numberOfEmployees")).SendKeys(details.NumberofEmployees);
        }
        [Given(@"I select the SME radio button")]
        public void GivenISelectTheSMERadioButton()
        {
            driver.FindElement(By.Id("companyTypeSME")).Click();
        }

    }


}

