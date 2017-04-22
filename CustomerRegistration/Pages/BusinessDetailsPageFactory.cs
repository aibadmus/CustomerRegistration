using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace UnitTestProject1.BusinessDetailsPage
{
    public class BusinessDetailsPageFactory
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "companyName")]
        public IWebElement CompanyNameTxtField { get; set; }

        [FindsBy(How = How.Id, Using = "companyRegNo")]
        public IWebElement CompanyRegNoTxtField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#companyRegNoHelp > a")]
        public IWebElement CompanyHouseWebsiteLink { get; set; }

        [FindsBy(How = How.Id, Using = "companyTypeSME")]
        public IWebElement CompanyTypeSMERadioBtn { get; set; }

        [FindsBy(How = How.Id, Using = "companyTypeEnterprise")]
        public IWebElement CompanyTypeEnterpriseRadioBtn { get; set; }

        [FindsBy(How = How.Id, Using = "minimisSupportNo")]
        public IWebElement MinimisSupportNoRadioBtn { get; set; }

        [FindsBy(How = How.Id, Using = "minimisSupportYes")]
        public IWebElement MinimisSupportYesRadioBtn { get; set; }

        [FindsBy(How = How.Id, Using = "isDeMinimisSupportNotreceived")]
        public IWebElement NotReceivedDeMinimisCheckBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page--content > div.col-sm-9 > form > section:nth-child(5) > div > div:nth-child(2) > div.panel.panel-default > div > table > tbody > tr:nth-child(2) > td:nth-child(1) > select")]
        public IWebElement TypeOfDeMinimisDropDown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page--content > div.col-sm-9 > form > section:nth-child(5) > div > div:nth-child(2) > div.panel.panel-default > div > table > tbody > tr:nth-child(2) > td:nth-child(1) > select > option:nth-child(1)")]
        public IWebElement GeneralDeMinimis { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page--content > div.col-sm-9 > form > section:nth-child(5) > div > div:nth-child(2) > div.panel.panel-default > div > table > tbody > tr:nth-child(2) > td:nth-child(1) > select > option:nth-child(2)")]
        public IWebElement AgricultureDeMinimis { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page--content > div.col-sm-9 > form > section:nth-child(5) > div > div:nth-child(2) > div.panel.panel-default > div > table > tbody > tr:nth-child(2) > td:nth-child(1) > select > option:nth-child(3)")]
        public IWebElement FisheriesDeMinimis { get; set; }

        [FindsBy(How = How.Id, Using = "#page--content > div.col-sm-9 > form > section:nth-child(5) > div > div:nth-child(2) > div.panel.panel-default > div > table > tbody > tr:nth-child(2) > td:nth-child(1) > select > option:nth-child(4)")]
        public IWebElement RoadTransportDeminimis { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page--content > div.col-sm-9 > form > section:nth-child(5) > div > div:nth-child(2) > div.panel.panel-default > div > table > tbody > tr:nth-child(2) > td:nth-child(2) > select")]
        public IWebElement FinancialYearDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "undefined")]
        public IWebElement AddMoreRows { get; set; }

        [FindsBy(How = How.Id, Using = "amount_dbf990a9-e182-4159-ae9d-08d450d41aa4")]
        public IWebElement BusinessDetailsAmountTxtField { get; set; }


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
        public void VerifycompanyRegNoField()
        {
            bool isElementDisplayed = CompanyRegNoTxtField.Displayed;
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
        public void verifyDeMinimisNoRadioBtn()
        {
            bool isElementDisplayed = MinimisSupportNoRadioBtn.Displayed;

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
        public void SelectSMERadioBtn()
        {
            CompanyTypeSMERadioBtn.Click();
        }
        public void SelectEnterpriseRadioBtn()
        {
            CompanyTypeEnterpriseRadioBtn.Click();
        }
        public void SelecDeMinimisYesRadioBtn()
        {
            MinimisSupportYesRadioBtn.Click();
        }
        public void SelectDeMinimisNoRadioBtn()
        {
            MinimisSupportNoRadioBtn.Click();
        }
    }
}   
