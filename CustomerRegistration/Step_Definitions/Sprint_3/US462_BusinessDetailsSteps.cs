using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UnitTestProject1.AzureLoginPage;
using UnitTestProject1.CommonElementPageFactory;
using UnitTestProject1.BrowserSettings;
using UnitTestProject1.HomeObjects;
using UnitTestProject1.BusinessDetailsPage;
using UnitTestProject1.CommonElementPageFactory;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Step_Definitions.Sprint_3
{
    [Binding]
    public class US462_BusinessDetailsSteps
    {
        IWebDriver driver;
        private string baseCssSelector;

        [When(@"I am on the Business details page")]
        public void GivenIAmOnTheBusinessDetailsPage()
        {

            driver = new ChromeDriver(@"C:\Users\aibad\Test\chromedriver");
            driver.Navigate().GoToUrl("http://qa1grantweb.azurewebsites.net/grants/home");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));
            //  driver.FindElement(By.Id("start-application")).Click();
            //driver.Navigate().GoToUrl("https://login.microsoftonline.com/QA1ScotEnt.onmicrosoft.com/oauth2/v2.0/authorize?client_id=0bf4fad2-c576-47e1-a689-4796d560fdb1&response_type=code+id_token&redirect_uri=https://qa1grantweb.azurewebsites.net/auth/signin&response_mode=form_post&scope=openid%20offline_access&p=B2C_1_scotent-signin_signup&state=%2Cgrants%2Cbusinessdetails");

            //var browserConfig = new BrowserConfig(driver);
            // browserConfig.OpenGrantsChromeBrowser();

            var grantsHomePageFactory = new GrantsHomePageFactory(driver);
            grantsHomePageFactory.ClickStartNewApplicationBtn();
            driver.Navigate().GoToUrl("https://login.microsoftonline.com/QA1ScotEnt.onmicrosoft.com/oauth2/v2.0/authorize?client_id=0bf4fad2-c576-47e1-a689-4796d560fdb1&response_type=code+id_token&redirect_uri=https://qa1grantweb.azurewebsites.net/auth/signin&response_mode=form_post&scope=openid%20offline_access&p=B2C_1_scotent-signin_signup&state=%2Cgrants%2Cbusinessdetails");


            var scotentAzureLoginPage = new ScotentAzureLoginPage(driver);
            scotentAzureLoginPage.AzureLogIn();

        }
        [Given(@"I have clicked on the button Add more rows")]
        public void GivenIHaveClickedOnTheButtonAddMoreRows()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select NO on the de minimis question")]
        public void WhenISelectOnTheDeMinimisQuestion()
        {
            /*
            IWebElement oCheckBox = driver.FindElement(By.CssSelector("#page--content > div.col-sm-9 > form > fieldset:nth-child(5) > label:nth-child(4)"));
            System.Threading.Thread.Sleep(5000);
            oCheckBox.Click();
            
             */
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.SelectDeMinimisNoRadioBtn();

        }

        [When(@"I have answered YES to the de minimis question")]
        public void WhenIHaveAnsweredYESToTheDeMinimisQuestion()
        {

            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.SelectDeMinimisYesRadioBtn();

        }
        [When(@"I click on the Add more rows button")]
        public void WhenIClickOnTheAddMoreRowsButton()
        {
            driver.FindElement(By.CssSelector("#page--content > div.col-sm-9 > form > fieldset:nth-child(5) > div.form-sub-group > table > tbody > tr:nth-child(3) > td:nth-child(2)")).Click();
            /*
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.SelectAddMoreRowsBtn(); 
            */

        }

        [When(@"I click on the button Delete row")]
        public void WhenIClickOnTheButtonDeleteRow()
        {
            driver.FindElement(By.Id("remove_0")).Click();
        }
        [When(@"I click on the Companies House website link")]
        public void WhenIClickOnTheCompaniesHouseWebsiteLink()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.SelectCompaniesHouseWebsite();
        }


        [When(@"I click on the Save and Continue button")]
        public void WhenIClickOnTheSaveAndContinueButton()
        {
            var commonElement = new CommonElement(driver);
            commonElement.ClickSaveAndContinue();
        }

        [Then(@"a check box appears with the following label: I confirm that I haven't received any de minimis aid in my last (.*) financial years\.")]
        public void ThenACheckBoxAppearsWithTheFollowingLabelIConfirmThatIHavenTReceivedAnyDeMinimisAidInMyLastFinancialYears_(int p0)
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifyDeMinimisNotReceived();

        }

        [Then(@"I see Type of de minimis table drop down option")]
        public void ThenISeeTypeOfDeMinimisTableDropDownOption()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifyDeMinimisTypeDropDown();
        }

        [Then(@"I see Financial Year table drop down option")]
        public void ThenISeeFinancialYearTableDropDownOption()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifyFinancialYearDropDown();
        }

        [Then(@"I see Amount text field")]
        public void ThenISeeAmountTextField()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifyDeminimisAmount();
        }

        [Then(@"an additional data entry row is added to the bottom of the table")]
        public void ThenAnAdditionalDataEntryRowIsAddedToTheBottomOfTheTable()
        {

            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifyAddedDeMinimisRow();
        }

        [Then(@"the row I am on is removed from the table")]
        public void ThenTheRowIAmOnIsRemovedFromTheTable()
        {

            if (driver.FindElements(By.CssSelector("#page--content > div.col-sm-9 > form > fieldset:nth-child(5) > div.form-sub-group > table > tbody > tr:nth-child(4)")).Count != 0)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }

        [Then(@"the companies house website opens in a new browser tab: https://beta\.companieshouse\.gov\.uk/")]
        public void ThenTheCompaniesHouseWebsiteOpensInANewBrowserTabHttpsBeta_Companieshouse_Gov_Uk()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifyCompaniesHouseWebsiteBrowserTab();
        }

        [Then(@"I can see the progress indicator control")]
        public void ThenICanSeeTheProgressIndicatorControl()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifyProgressIndicator();
        }

        [Then(@"the Project details page is displayed")]
        public void ThenTheProjectDetailsPageIsDisplayed()
        {
            ScenarioContext.Current.Pending();

        }
        [Then(@"I can see the Save And continue button")]
        public void GivenICanSeeTheSaveAndContinueButton()
        {
            var commonElement = new CommonElement(driver);
            commonElement.VerifySaveAndContinueBtn();
        }

        [Then(@"I can see the Business name field")]
        public void GivenICanSeeTheBusinessNameField()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.VerifyCompanyNameField();
        }
        [Then(@"I can see the Companies House registration number field")]
        public void GivenICanSeeTheCompaniesHouseRegistrationNumberField()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.VerifycompanyRegNoField();

        }
        [Then(@"I can see the SME radio button option")]
        public void GivenICanSeeTheSMERadioButtonOption()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifySMERadioBtn();

        }
        [Then(@"I can see the Large enterprise radio button option")]
        public void GivenICanSeeTheLargeEnterpriseRadioButtonOption()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifyEnterpriseRadioBtn();

        }
        [Then(@"I can see the Yes radio button to the De minimis question")]
        public void GivenICanSeeTheYesRadioButtonToTheDeMinimisQuestion()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifyDeMinimisYesRadioBtn();

        }

        [Then(@"I can see the No radio button to the De minimis question")]
        public void GivenICanSeeTheNoRadioButtonToTheDeMinimisQuestion()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifyDeMinimisNoRadioBtn();
        }
        [Then(@"the help text is displayed under the Company name question")]
        public void ThenTheHelpTextIsDisplayedUnderTheCompanyNameQuestion()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.VerifyCompanyNameHelpTxt();
        }
        [Then(@"the help text is displayed under the Company registration number question")]
        public void ThenTheHelpTextIsDisplayedUnderTheCompanyRegistrationNumberQuestion()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.VerifyCompanyRegNoHelpTxt();
        }
        [Then(@"I see the Companies House Website Link")]
        public void ThenISeeTheCompaniesHouseWebsiteLink()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.VerifyCompanyHouseWebsiteLink();
        }
        [Then(@"the help text is displayed under the SME question")]
        public void ThenTheHelpTextIsDisplayedUnderTheSMEQuestion()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.VerifyCompanyTypeHelpTxt();
        }

        [Then(@"the help text is displayed under the De minimis question")]
        public void ThenTheHelpTextIsDisplayedUnderTheDeMinimisQuestion()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifyDeMinimisHelpTxt();
        }

        [When(@"I click on the European Currency Conversion Tool link")]
        public void WhenIClickOnTheEuropeanCurrencyConversionToolLink()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.SelectEuropeanCurrencyConversionTool();
        }
        [Then(@"the European Commission currency conversion website opens in a new browser tab : http://ec\.europa\.eu/budget/contracts_grants/info_contracts/inforeuro/index_en\.cfm")]
        public void ThenTheEuropeanCommissionCurrencyConversionWebsiteOpensInANewBrowserTabHttpEc_Europa_EuBudgetContracts_GrantsInfo_ContractsInforeuroIndex_En_Cfm()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
            businessDetailsPageFactory.verifyEuropeanCurrencyConversionToolWebsiteBrowserTab();
        }
        [When(@"all mandatory form fields contain data")]
        public void WhenAllMandatoryFormFieldsContainData()
        {
            var businessDetailsPageFactory = new BusinessDetailsPageFactory(driver);
        }


        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            driver.Close();
        }

    }
        }
