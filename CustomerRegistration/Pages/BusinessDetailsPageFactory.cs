using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.BusinessDetailsPage
{
    public class BusinessDetailsPageFactory
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "companyName")]
        public IWebElement CompanyNameTxtField { get; set; }

        [FindsBy(How =How.Id,Using = "companyNameHelp")]
        public IWebElement CompanyNameHelpTxt { get; set; }

        [FindsBy(How =How.Id,Using = "progress--indicator")]
        public IWebElement ProgressIndicator { get; set; }

        [FindsBy(How = How.Id, Using = "companyRegNo")]
        public IWebElement CompanyRegNoTxtField { get; set; }

        [FindsBy(How =How.Id,Using = "companyRegNoHelp")]
        public IWebElement CompanyRegNoHelpTxt { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#companyRegNoHelp > a")]
        public IWebElement CompanyHouseWebsiteLink { get; set; }
        
        [FindsBy(How =How.Id,Using = "companyTypeOptionsHelp")]
        public IWebElement CompanyTypeOption { get; set; }

        [FindsBy(How = How.Id, Using = "companyTypeSME")]
        public IWebElement CompanyTypeSMERadioBtn { get; set; }

        [FindsBy(How = How.Id, Using = "companyTypeEnterprise")]
        public IWebElement CompanyTypeEnterpriseRadioBtn { get; set; }

        [FindsBy(How =How.Id,Using = "minimisSupportOptionsHelp")]
        public IWebElement DeMinimisHelpTxt { get; set; }

        [FindsBy(How = How.Id, Using = "minimisSupportNo")]
        public IWebElement MinimisSupportNoRadioBtn { get; set; }

        [FindsBy(How =How.CssSelector,Using = "#minimisFundingHelp > strong > a")]
        public IWebElement EuropeanCurrencyConversionTool { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page--content > div.col-sm-9 > form > fieldset:nth-child(5) > label:nth-child(3)")]
        public IWebElement MinimisSupportYesRadioBtn { get; set; }

        [FindsBy(How = How.Id, Using = "isDeMinimisSupportNotreceived")]
        public IWebElement NotReceivedDeMinimisCheckBox { get; set; }

        [FindsBy(How =How.CssSelector,Using = "#page--content > div.col-sm-9 > form > fieldset:nth-child(5) > div.form-sub-group > table > tbody > tr:nth-child(2) > td:nth-child(1)")]
        public IWebElement TypeOfDeMinimisDropDown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page--content > div.col-sm-9 > form > section:nth-child(5) > div > div:nth-child(2) > div.panel.panel-default > div > table > tbody > tr:nth-child(2) > td:nth-child(1) > select > option:nth-child(1)")]
        public IWebElement GeneralDeMinimis { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page--content > div.col-sm-9 > form > section:nth-child(5) > div > div:nth-child(2) > div.panel.panel-default > div > table > tbody > tr:nth-child(2) > td:nth-child(1) > select > option:nth-child(2)")]
        public IWebElement AgricultureDeMinimis { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page--content > div.col-sm-9 > form > section:nth-child(5) > div > div:nth-child(2) > div.panel.panel-default > div > table > tbody > tr:nth-child(2) > td:nth-child(1) > select > option:nth-child(3)")]
        public IWebElement FisheriesDeMinimis { get; set; }

        [FindsBy(How = How.Id, Using = "#page--content > div.col-sm-9 > form > section:nth-child(5) > div > div:nth-child(2) > div.panel.panel-default > div > table > tbody > tr:nth-child(2) > td:nth-child(1) > select > option:nth-child(4)")]
        public IWebElement RoadTransportDeminimis { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page--content > div.col-sm-9 > form > fieldset:nth-child(5) > div.form-sub-group > table > tbody > tr:nth-child(2) > td:nth-child(2)")]
        public IWebElement FinancialYearDropDown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#undefined")]
        public IWebElement AddMoreRows { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#amount_0Input")]
        public IWebElement DeMinimisAmountField { get; set; }
        
        [FindsBy(How =How.Id,Using = "deMinimisType2")]
        public IWebElement SecondDeMinimisRow { get; set; }


        public BusinessDetailsPageFactory(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        //Verify Elements 
        public void VerifyCompanyNameField()
        {
            bool isElementDisplayed = CompanyNameTxtField.Displayed;
        }
        public void VerifyCompanyNameHelpTxt()
        {
            bool isElementDisplayed = CompanyNameHelpTxt.Displayed;
        }
        public void VerifycompanyRegNoField()
        {
            bool isElementDisplayed = CompanyRegNoTxtField.Displayed;
        }
        public void VerifyCompanyRegNoHelpTxt()
        {
            bool isElementDisplayed = CompanyRegNoHelpTxt.Displayed;
        }
        
        public void VerifyCompanyHouseWebsiteLink()
        {
            bool isElementDisplayed = CompanyHouseWebsiteLink.Displayed;
        }

        public void VerifyCompanyTypeHelpTxt()
        {
            bool isElementDisplayed = CompanyTypeOption.Displayed;
        }
        public void verifySMERadioBtn()
        {
            bool isElementDisplayed = CompanyTypeSMERadioBtn.Displayed;
        }
        public void verifyEnterpriseRadioBtn()
        {
            bool isElementDisplayed = CompanyTypeEnterpriseRadioBtn.Displayed;
        }
        public void verifyDeMinimisYesRadioBtn()
        {

            bool isElementDisplayed = MinimisSupportYesRadioBtn.Displayed;
        }
        public void verifyDeMinimisHelpTxt()
        {
            bool isElementDisplayed = DeMinimisHelpTxt.Displayed;
        }
        public void verifyDeMinimisNoRadioBtn()
        {
            bool isElementDisplayed = MinimisSupportNoRadioBtn.Displayed;
        }
        public void verifyDeMinimisNotReceived()
        {
            //bool isElementDisplayed = driver.FindElement(By.Id("isDeMinimisSupportNotreceived")).Displayed;
            bool isElementDisplayed = NotReceivedDeMinimisCheckBox.Displayed;
        }
        public void verifyDeMinimisTypeDropDown()
        {
            bool isElementDisplayed = TypeOfDeMinimisDropDown.Displayed;
        }
        public void verifyFinancialYearDropDown()
        {
            bool isElementDisplayed = FinancialYearDropDown.Displayed;
        }
        public void verifyDeminimisAmount()
        {
            bool isElementDisplayed = DeMinimisAmountField.Displayed;
        }
        public void verifyAddMoreDeMinimisRowBtn()
        {
            bool isElementDisplayed = AddMoreRows.Displayed;
        }
        public void verifyProgressIndicator()
        {
            bool isElementDisplayed = ProgressIndicator.Displayed;
        }
        public void verifyAddedDeMinimisRow()
        {
            bool isElementDisplayed = SecondDeMinimisRow.Displayed;
        }
        public void verifyEuropeanCurrencyConversionToolWebsiteBrowserTab()
        {
            var popup = driver.WindowHandles[1]; // handler for the new tab
            Assert.IsTrue(!string.IsNullOrEmpty(popup)); // tab was opened
            Assert.AreEqual(driver.SwitchTo().Window(popup).Url, "http://ec.europa.eu/budget/contracts_grants/info_contracts/inforeuro/index_en.cfm"); // url is OK  
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close(); // close the tab
            driver.SwitchTo().Window(driver.WindowHandles[0]); // get back to the main window      
        }
        public void verifyCompaniesHouseWebsiteBrowserTab()
        {
            var popup = driver.WindowHandles[1]; // handler for the new tab
            Assert.IsTrue(!string.IsNullOrEmpty(popup)); // tab was opened
            Assert.AreEqual(driver.SwitchTo().Window(popup).Url, "https://beta.companieshouse.gov.uk/"); // url is OK  
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close(); // close the tab
            driver.SwitchTo().Window(driver.WindowHandles[0]); // get back to the main window    
        }




        //Select Elements
        public void SelectCompanyRegNoField()
        {
            CompanyRegNoTxtField.Click();
        }
        public void SelectCompanyNameField()
        {
            CompanyNameTxtField.Click();
        }
        public void SelectCompaniesHouseWebsite()
        {
            CompanyHouseWebsiteLink.Click();
        }
        public void SelectSMERadioBtn()
        {
            CompanyTypeSMERadioBtn.Click();
        }
        public void SelectEnterpriseRadioBtn()
        {
            CompanyTypeEnterpriseRadioBtn.Click();
        }
        public void SelectDeMinimisYesRadioBtn()
        {
            IWebElement oCheckBox = driver.FindElement(By.CssSelector("#page--content > div.col-sm-9 > form > fieldset:nth-child(5) > label:nth-child(3)"));
            System.Threading.Thread.Sleep(5000);
            oCheckBox.Click();

            //IWebElement radioBtn = MinimisSupportYesRadioBtn;
        }
        public void SelectDeMinimisNoRadioBtn()
        {
            IWebElement oCheckBox = driver.FindElement(By.CssSelector("#page--content > div.col-sm-9 > form > fieldset:nth-child(5) > label:nth-child(4)"));
            System.Threading.Thread.Sleep(5000);
            oCheckBox.Click();
        }
        public void SelectAddMoreRowsBtn()
        {
            AddMoreRows.Click();
        }
        public void SelectEuropeanCurrencyConversionTool()
        {
            EuropeanCurrencyConversionTool.Click();
        }

    }
}   
