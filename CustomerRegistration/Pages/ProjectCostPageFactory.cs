using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace UnitTestProject1.ProjectCosts
{
   public class ProjectCostPageFractory
    {
        private IWebDriver driver;

        [FindsBy(How =How.Id,Using = "projectTotalCost")]
        public IWebElement ProjectCostField { get; set; }

        [FindsBy(How =How.Id,Using = "costToRecruit")]
        public IWebElement ProjectRecruitCostField { get; set; }

        [FindsBy(How =How.Id,Using = "contributeToProject")]
        public IWebElement ProjectContribution { get; set; }

        [FindsBy(How =How.Id,Using = "totalCosts")]
        public IWebElement TotalCost { get; set; }

        [FindsBy(How =How.Id,Using = "costToRecruit")]
        public IWebElement CostToRecruit { get; set; }

        [FindsBy(How =How.Id,Using = "contributeToProject")]
        public IWebElement ContributeToProject { get; set; }

        [FindsBy(How =How.Id,Using = "maximumGrants")]
        public IWebElement MaximumGrants { get; set; }

       public ProjectCostPageFractory(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void EnterProjectCost()
        {
            ProjectCostField.SendKeys("269.90");
        }
        public void EnterRecruitmentCost()
        {
            ProjectRecruitCostField.SendKeys("5000");
        }
        public void EnterContribution()
        {
            ProjectContribution.SendKeys("2000");
        }

            
        }
    }

