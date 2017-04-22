using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject1
{

    [Binding]
    public class NewCustomerRegistrationSteps
    {
        public IWebDriver driver;

        [Given(@"I want to start an application")]
        public void GivenIWantToStartAnApplication()
        {
            driver = new ChromeDriver(@"C:\Users\aibad\Test\chromedriver");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://qa1grantweb.azurewebsites.net/grants/home");
            driver.FindElement(By.Id("start-application")).Click();
            
        }

        [Given(@"I do not already have an online account")]
        public void GivenIDoNotAlreadyHaveAnOnlineAccount()
        {
            driver.FindElement(By.CssSelector("#navbar > ul > li > a")).Equals("Sign in / Register");
        }
        [When(@"I provide the details on the Application form: New account page")]
        public void WhenIProvideTheDetailsOnTheApplicationFormNewAccountPage(Table table)
        {
            FormDetails details = table.CreateInstance<FormDetails>();        
            driver.FindElement(By.Id("firstName")).SendKeys(details.FirstName);
            driver.FindElement(By.Id("lastName")).SendKeys(details.Surname);
            driver.FindElement(By.Id("accountEmail")).SendKeys(details.EmailAddress);
            driver.FindElement(By.Id("password")).SendKeys(details.Password);
            driver.FindElement(By.Id("confirmPassword")).SendKeys(details.ConfirmPassword);

        }
   

        [Then(@"the Application form: Business Details page should appear")]
        public void ThenTheApplicationFormBusinessDetailsPageShouldAppear()
        {

            driver.FindElement(By.CssSelector("#breadcrumb > h1 > span")).GetAttribute("Business Details");

        }

        [Then(@"an error message should appear that the password doesn't match")]
        public void ThenAnErrorMessageShouldAppearThatThePasswordDoesnTMatch()
        {
            //driver.FindElement(By.CssSelector("#page--content > div.col-sm-9 > form > div:nth-child(5)")).Equals("The provided passwords must match");
            driver.FindElement(By.Id("confirmPassword")).GetAttribute("The provided passwords  match");

        }
        [When(@"I click on the Enter a Password field")]
        public void WhenIClickOnTheEnterAPasswordField()
        {
            driver.FindElement(By.Id("password")).Click();
        }

        [Then(@"an error message should appear that email should be in the format")]
        public void ThenAnErrorMessageShouldAppearThatEmailShouldBeInTheFormat()
        {
            driver.FindElement(By.Id("accountEmail")).GetAttribute("Please enter a valid email address in the form abc@email.com");
            //driver.FindElement(By.CssSelector("#page--content > div.col-sm-9 > form > div:nth-child(4) > div")).Equals("Please enter a valid email address in the form abc@email.com");

        }
        [Then(@"I update the password to match")]
        public void ThenIUpdateThePasswordToMatch(Table table)
        {
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("confirmPassword")).Clear();
            FormDetails details = table.CreateInstance<FormDetails>();
            driver.FindElement(By.Id("password")).SendKeys(details.Password);
            driver.FindElement(By.Id("confirmPassword")).SendKeys(details.ConfirmPassword);
        }
        [Then(@"I clear the fields")]
        public void ThenIClearTheFields()
        {
            driver.FindElement(By.Id("firstName")).Clear();
            driver.FindElement(By.Id("lastName")).Clear();
            driver.FindElement(By.Id("accountEmail")).Clear();
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("confirmPassword")).Clear();
        }

        [When(@"I provide the details with an invalid email on the Application form: New account page")]
        public void WhenIProvideTheDetailsWithAnInvalidEmailOnTheApplicationFormNewAccountPage(Table table)
        {

            FormDetails details = table.CreateInstance<FormDetails>();
            driver.FindElement(By.Id("firstName")).SendKeys(details.FirstName);
            driver.FindElement(By.Id("lastName")).SendKeys(details.Surname);
            driver.FindElement(By.Id("accountEmail")).SendKeys(details.EmailAddress);
            driver.FindElement(By.Id("password")).SendKeys(details.Password);
            driver.FindElement(By.Id("confirmPassword")).SendKeys(details.ConfirmPassword);
        }

        [Then(@"I Update the email to the correct format")]
        public void ThenIUpdateTheEmailToTheCorrectFormat(Table table)
        {
            driver.FindElement(By.Id("accountEmail")).Clear();
            FormDetails details = table.CreateInstance<FormDetails>();
            driver.FindElement(By.Id("firstName")).SendKeys(details.FirstName);
            driver.FindElement(By.Id("lastName")).SendKeys(details.Surname);
            driver.FindElement(By.Id("accountEmail")).SendKeys(details.EmailAddress);
            driver.FindElement(By.Id("password")).SendKeys(details.Password);
            driver.FindElement(By.Id("confirmPassword")).SendKeys(details.ConfirmPassword);
        }

        [Then(@"I click on the Register button")]
        public void ThenIClickOnTheRegisterButton()
        {
            driver.FindElement(By.CssSelector("#page--content > div.col-sm-9 > form > div.form-actions > input")).Click();
        }
        [When(@"I click on the Register button")]
        public void WhenIClickOnTheRegisterButton()
        {
            driver.FindElement(By.CssSelector("#page--content > div.col-sm-9 > form > div.form-actions > input")).Submit();
        }

        [Then(@"I close browser")]
        public void ThenICloseBrowser()
        {
            driver.Close();
        }

    }
}
