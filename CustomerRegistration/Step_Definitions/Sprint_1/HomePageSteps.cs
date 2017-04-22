using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using UnitTestProject1.HomeObjects;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject1
{
    [Binding]
    public class HomePageSteps

    {
        IWebDriver driver;
           

        [Given(@"I am a new user")]
        public void GivenIAmANewUser ()
        {
            
            driver = new ChromeDriver(@"C:\Users\badmus\Test\chromedriver");
            driver.Navigate().GoToUrl("http://qa1grantweb.azurewebsites.net/grants/home");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));   
                
            
        }
        [Given(@"I am not logged in")]
        public void GivenIAmNotLoggedIn()
        {

            driver.PageSource.Contains("Sign in / Register");
 
        }

        [When(@"I am on the Apply for Domestic Market Development Support page")]
        public void WhenIAmOnTheApplyForDomesticMarketDevelopmentSupportPage()
        {
            driver.FindElement(By.CssSelector("#breadcrumb > ol > li.active")).Equals("Domestic Market Development Support");
        }

        [Then(@"I can see the page content")]
        public void ThenICanSeeThePageContent()
        {
            driver.FindElement(By.CssSelector("#page--content > div:nth-child(1) > div > div > h2")).Equals("What you will need for your application");
        }

        [Then(@"I can see the Start New Application button")]
        public void ThenICanSeeTheStartNewApplicationButton()
        {
            IWebElement body = driver.FindElement(By.Id("start-application"));

        }

        [When(@"I click on the Start New Application button")]
        public void WhenIClickOnTheStartNewApplicationButton()
        {
           var grantshomePageFactory = new GrantsHomePageFactory(driver);
            grantshomePageFactory.ClickStartNewApplicationBtn ();

         
        }

        [Then(@"the Application form: New Account page is displayed")]
        public void ThenTheApplicationFormNewAccountPageIsDisplayed()
        {
            IWebElement body = driver.FindElement(By.TagName("body"));
            Assert.IsTrue(body.Text.Contains("New Account"));
        }
        
    }
}    