using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject1.PreviewPageFactory
{
    public class PreviewPageFactory
    {
        private IWebDriver driver;

        [FindsBy(How =How.Id,Using =("editBusinessDetails"))]
        public IWebElement EditBusinessDetails { get; set; }

        [FindsBy(How = How.Id, Using = ("editProjectDetails"))]
        public IWebElement EditProjectDetails { get; set; }

        [FindsBy(How = How.Id, Using = ("editProjectOutputs"))]
        public IWebElement EditProjectOutputs { get; set; }

        [FindsBy(How = How.Id, Using = ("editExternalConsultants"))]
        public IWebElement EditProjectResources { get; set; }

        [FindsBy(How = How.Id, Using = ("editProjectCosts"))]
        public IWebElement EditProjectCosts { get; set; }

        public PreviewPageFactory(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void ClickEditBusinessDetailsBtn()
        {
            EditBusinessDetails.Click();
        }

        public void ClickEditProjectDetailsBtn()
        {
            EditProjectDetails.Click();
        }
        public void ClickProjectOutputs()
        {
            EditProjectOutputs.Click();
        }

        public void ClickProjectResources()
        {
            EditProjectResources.Click();
        }
        public void ClickEditProjectCosts()
        {
            EditProjectCosts.Click();
        }
    }
}
