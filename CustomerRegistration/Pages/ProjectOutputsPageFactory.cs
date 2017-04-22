using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject1.rojectOutputsPageFactory
{
    public class ProjectOutputsPageFactory
    {
        private IWebDriver driver;

        [FindsBy(How =How.Id,Using = "projectBenifitDescription")]
        public IWebElement LongTermBenefitsTxtField  { get; set; }

        [FindsBy(How =How.Id,Using = "isOfBenefitToProjectNo0")]
        public IWebElement NoIncreaseInTurnover { get; set; }

        [FindsBy(How =How.Id,Using = "'isOfBenefitToProjectYes'+i")]
        public IWebElement YesIncreaseInTurnover { get; set; }

        [FindsBy(How =How.Id,Using = "isOfBenefitToProjectNo1")]
        public IWebElement NoInternationRevenue { get; set; }

        [FindsBy(How =How.Id,Using = "'isOfBenefitToProjectYes'+i")]
        public IWebElement YesInternationRevenue { get; set; }

        [FindsBy(How =How.Id,Using = "isOfBenefitToProjectNo2")]
        public IWebElement NoCreateMoreJobs { get; set; }

        [FindsBy(How =How.Id,Using = "'isOfBenefitToProjectYes'+i")]
        public IWebElement YesCreateMoreJobs { get; set; }

        [FindsBy(How =How.Id,Using = "isOfBenefitToProjectNo3")]
        public IWebElement NoHighValueJobs { get; set; }

        [FindsBy(How =How.Id,Using = "'isOfBenefitToProjectYes'+i")]
        public IWebElement YesHighValueJobs { get; set; }

        [FindsBy(How = How.Id, Using = "isOfBenefitToProjectNo4")]
        public IWebElement NoSafeGuardJobs { get; set; }

        [FindsBy(How = How.Id, Using = "'isOfBenefitToProjectYes'+i")]
        public IWebElement YesSafeGuardJobs { get; set; }

        [FindsBy(How = How.Id, Using = "isOfBenefitToProjectNo5")]
        public IWebElement NoMakingSavings { get; set; }

        [FindsBy(How = How.Id, Using = "'isOfBenefitToProjectYes'+i")]
        public IWebElement YesMakingSavings { get; set; }

        public ProjectOutputsPageFactory(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void EnterBenefitTxt()
        {
            LongTermBenefitsTxtField.SendKeys("The workforce will grow from 10 to 150 in the first year");
        }
        public void ClickNoIncreaseInTurnover()
        {
            NoIncreaseInTurnover.Click();
        }
        public void ClickYesIncreaseInTurnover()
        {
            YesIncreaseInTurnover.Click();
        }
        public void ClickNoInternationRevenue()
        {
            NoInternationRevenue.Click();
        }
        public void ClickYesInternationRevenue()
        {
            YesInternationRevenue.Click();
        }
        public void ClickNoCreateMoreJobs()
        {
            NoCreateMoreJobs.Click();
        }
        public void ClickYesCreateMoreJobs()
        {
            YesCreateMoreJobs.Click();
        }
        public void ClickNoHighValueJobs()
        {
            NoHighValueJobs.Click();
        }
        public void ClickYesHighValueJobs()
        {
            YesHighValueJobs.Click();
        }
        public void ClickNoSafeGuardJobs()
        {
            NoSafeGuardJobs.Click();
        }
        public void ClickYesSafeGuardJobs()
        {
            YesSafeGuardJobs.Click();
        }
        public void ClickNoMakingSavings()
        {
            NoMakingSavings.Click();
        }
        public void ClickYesMakingSavings()
        {
            YesMakingSavings.Click();
        }
    }
    
}
