using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject1.ApplicationSubmission
{
    public class ApplicationSubmissionPageFactory
    {
        private IWebDriver driver;

        [FindsBy(How =How.Id,Using = "isDeclarationSigned")]
        public IWebElement TermsAndConditionTickBox { get; set; }



        public ApplicationSubmissionPageFactory (IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ClickTermsAndConditionsBox ()
        {
            TermsAndConditionTickBox.Click();
        }

    }
}
