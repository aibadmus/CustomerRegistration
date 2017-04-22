using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace UnitTestProject1.HomeObjects
{

    public class GrantsHomePageFactory
    {
       private IWebDriver driver;
        

        [FindsBy(How = How.Id, Using = "Sign in / Register")]
        public IWebElement btnSignIn { get; set; }

        [FindsBy(How = How.Id, Using = "start-application")]
        public IWebElement btnStartApplication { get; set; }

        public GrantsHomePageFactory(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void ClickSignIn()
        {
            btnSignIn.Click();
        }
        public void ClickStartNewApplicationBtn()
        {
            btnStartApplication.Click();
        }
             
            
    } 

}
