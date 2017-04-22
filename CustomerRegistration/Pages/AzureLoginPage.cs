using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support;
using System;

namespace UnitTestProject1.AzureLoginPage
{
    public class ScotentAzureLoginPage
    {
        private IWebDriver driver;
    
        
        [FindsBy(How = How.Id, Using = "logonIdentifier")]
        [CacheLookup]
        public IWebElement AzureEmailAddressField { get; set;}

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        public IWebElement AzurePasswordField { get; set; }

        [FindsBy(How = How.Id, Using = "next")]
        [CacheLookup]
        public IWebElement AzureSigninButton { get; set; }

        public ScotentAzureLoginPage (IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
          public void AzureLogIn( )
        {   
            AzureEmailAddressField.Click();
            AzureEmailAddressField.SendKeys("devopstest1@scotent.co.uk");
            AzurePasswordField.SendKeys("Monday13");
            AzureSigninButton.Click();
            
        }
    }
    }

