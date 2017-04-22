using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace UnitTestProject1.ProjectDetailsPageFactory
{
    public class ProjectDetailsPageFactory
    {
        private IWebDriver driver;

        [FindsBy(How =How.Id,Using = "projectTitle")]
        public IWebElement ProjectTitleTxtField { get; set; }

        [FindsBy(How =How.Id,Using = "projectDescription")]
        public IWebElement ProjectDescriptionTxtField { get; set; }

        [FindsBy(How =How.CssSelector,Using ="#page--content > project-details > div > form > div:nth-child(5) > div > div > div > span > span")]
        public IWebElement DatePickerBtn { get; set; }

        [FindsBy(How =How.Id,Using = "duration1")]
        public IWebElement Under6MonthsDuration { get; set; }

        [FindsBy(How =How.Id,Using = "duration2")]
        public IWebElement Btw6Monthsand1YearDuration { get; set; }

        [FindsBy(How =How.Id,Using = "duration3")]
        public IWebElement Btw1and2YearsDuration { get; set; }

        [FindsBy(How = How.Id, Using = "duration4")]
        public IWebElement Over2YearsDuration { get; set; }

        public ProjectDetailsPageFactory(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void EnterProjectTitle()
        {
            ProjectTitleTxtField.SendKeys("Digital Transformation");
        }

        public void EnterProjectDescription()
        {
            ProjectDescriptionTxtField.SendKeys("Digital Transformation of the project is very important for the future");
        }
        public void SelectDate()
        {
            DatePickerBtn.Click();
        }
        public void SelectUnder6Months()
        {
            Under6MonthsDuration.Click();
        }
        public void Select6_12Months()
        {
            Btw6Monthsand1YearDuration.Click();
        }
        public void Select1_2Years()
        {
            Btw1and2YearsDuration.Click();
        }
        public void SelectOver2Years()
        {
            Over2YearsDuration.Click();
        }
            
    }
}
