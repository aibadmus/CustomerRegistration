using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UnitTestProject1.CommonElementPageFactory
{
    public class CommonElement
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "saveApplicationBack")]
        public IWebElement SaveAndGoBackBtn { get; set; }

        [FindsBy(How = How.Id, Using = "saveApplicationCont")]
        public IWebElement SaveAndContinueBtn { get; set; }

        [FindsBy(How = How.Id, Using = "quotesFile")]
        public IWebElement ChooseFileBtn { get; set; }

        public CommonElement(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void SaveAndBack ()
        {
            SaveAndGoBackBtn.Click();
        }
        public void ClickSaveAndContinue ()
        {
            SaveAndContinueBtn.Click();
        }
        public void LoadFile()
        {
            ChooseFileBtn.Click();
        }
        public void VerifySaveAndContinueBtn()
        {
            bool isElementDisplayed = SaveAndContinueBtn.Displayed;
        }
    }

}
