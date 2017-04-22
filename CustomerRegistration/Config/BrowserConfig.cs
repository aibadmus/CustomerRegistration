using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace UnitTestProject1.BrowserSettings
{
    public class BrowserConfig
    {
        private  IWebDriver driver;

        public BrowserConfig(IWebDriver driver)
        {
            this.driver = driver;
        }

        public  void OpenGrantsChromeBrowser()
        {
            driver = new ChromeDriver(@"C:\Users\badmus\Test\chromedriver");
            driver.Navigate().GoToUrl("http://qa1grantweb.azurewebsites.net/grants/home");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));
           
        }
        public void OpenAzureinChrome()
        {
            driver = new ChromeDriver(@"C:\Users\badmus\Test\chromedriver");
            driver.Navigate().GoToUrl("https://login.microsoftonline.com/QA1ScotEnt.onmicrosoft.com/oauth2/v2.0/authorize?client_id=0bf4fad2-c576-47e1-a689-4796d560fdb1&response_type=code+id_token&redirect_uri=https://qa1grantweb.azurewebsites.net/auth/signin&response_mode=form_post&scope=openid%20offline_access&p=B2C_1_scotent-signin_signup&state=%2Cgrants%2Cbusinessdetails");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));
        }
    }
}