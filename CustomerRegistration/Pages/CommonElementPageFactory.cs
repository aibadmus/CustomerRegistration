using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UnitTestProject1.CommonElementPageFactory
{
    public class CommonElement: Steps
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "saveApplicationBack")]
        public IWebElement SaveAndGoBackBtn { get; set; }

        [FindsBy(How = How.Id, Using = "saveApplicationCont")]
        public static IWebElement SaveAndContinueBtn { get; set; }

        [FindsBy(How = How.Id, Using = "quotesFile")]
        public IWebElement ChooseFileBtn { get; set; }

        //Select Elements
        public CommonElement(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void ClickSaveAndGoBack ()
        {
            SaveAndGoBackBtn.Click();
        }
        public  void ClickSaveAndContinue ()
        {
            SaveAndContinueBtn.Click();

        }
        public void ClickLoadFile()
        {
            ChooseFileBtn.Click();
        }

        //Verify Elements
        public static void VerifySaveAndContinueBtn(IWebDriver driver)
        {
            bool isElementDisplayed = SaveAndContinueBtn.Displayed;
        }
        public void VerifySaveAndGoBackBtn()
        {
            bool isElementDisplayed = SaveAndGoBackBtn.Displayed;
        }
        public void VerifyChooseFileBtn()
        {
            bool isElementDisplayed = ChooseFileBtn.Displayed;
        }

        internal void VerifySaveAndContinueBtn()
        {
            throw new NotImplementedException();
        }
    }

}
