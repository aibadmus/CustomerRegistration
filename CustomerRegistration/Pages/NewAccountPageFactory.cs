using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;
using System;





namespace UnitTestProject1.NewAccountPage
{
 
    public class Register 
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "firstName")]
        private IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "lastName")]
        private IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "accountEmail")]
        private IWebElement AccountEmail { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "confirmPassword")]
        private IWebElement ConfirmPassword { get; set; }

        [FindsBy(How = How.Id, Using = "Register")]
        private IWebElement Registerbutton { get; set; }


        public Register(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public Register()
        {
        }

        public void setFirstname(string strFirstName)
        {
            FirstName.SendKeys("Tester");
        }
            
        
        /*
            FirstName.SendKeys("Testone");
            LastName.SendKeys("lastname");
            AccountEmail.SendKeys("123456@email.co.uk");
            Password.SendKeys("Password01");
            ConfirmPassword.SendKeys("Password01");
            Registerbotton.Click();
            */
        
        public void setLastName(string strLastName)
        {
            LastName.SendKeys("MyLastName");

        }
        public void setAccountEmail(string strAccountEmail)
        {
            AccountEmail.SendKeys("myemail001@test.com");
        }
        public void setPassword(string strPassword)
        {
            Password.SendKeys("Password001");
        }
        public void setConfirmPassword(string strConfirmPassword)
        {
            ConfirmPassword.SendKeys("Password001");
        }
        public void setRegister()
        {
            Registerbutton.Click();
        }
        
    }
}
