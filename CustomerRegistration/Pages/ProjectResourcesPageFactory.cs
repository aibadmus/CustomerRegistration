using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support;

namespace UnitTestProject1.ExternalConsultantsPageFactory
{
    public class ProjectResourcesPageFactory
    {
        private IWebDriver driver;

        [FindsBy(How =How.Id,Using =("usingExternalConsultantsNo"))]
        public IWebElement TemporaryStaff { get; set; }

        [FindsBy(How =How.Id,Using =("usingExternalConsultantsYes"))]
        public IWebElement ExternalConsultant { get; set; }

        [FindsBy(How =How.Id,Using =("quoteObtainedNo"))]
        public IWebElement NoQuoteObtained { get; set; }

        [FindsBy(How =How.Id,Using =("quoteObtainedYes"))]
        public IWebElement YesQuoteObtained { get; set; }

        [FindsBy(How =How.Id,Using =("usingExternalConsultantsQuotesDescription"))]
        public IWebElement ExtConsultantsQuotesDescTxtField { get; set; }

        [FindsBy(How =How.Id,Using =("declaredInterestNo"))]
        public IWebElement NoDeclaredInterest { get; set; }

        [FindsBy(How =How.Id,Using =("declaredInterestYes"))]
        public IWebElement YesDeclaredInterest { get; set; }

        [FindsBy(How =How.Id,Using =("declaredInterestDescription"))]
        public IWebElement DeclaredInterestDescTextField { get; set; }

        public ProjectResourcesPageFactory (IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void SelectTemporaryStaff()
        {
            TemporaryStaff.Click();
        }
        public void SelectExternalConsultant()
        {
            ExternalConsultant.Click();
        }
        public void SelectNoQuoteObtained()
        {
            NoQuoteObtained.Click();
        }
        public void SelectYesQuoteObtained()
        {
            YesQuoteObtained.Click();
        }
        public void EnterDescriptionExtConsultantsQuotes()
        {
            ExtConsultantsQuotesDescTxtField.SendKeys("We will be using some external consultants for a 7 months period for this project");
        }
        public void SelectNoDeclaredInterest() {
            NoDeclaredInterest.Click();

        }
        public void SelectYesDeclaredInterest()
        {
            YesDeclaredInterest.Click();
        }
        public void EnterDeclaredInterestDescription()
        {
            DeclaredInterestDescTextField.SendKeys("I will like to let you know that I have 100 billion in my account but still like to have a grant");
        }
    }
}
