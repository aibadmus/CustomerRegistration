using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1.Step_Definitions
{
    [Binding]
    public class EditPagesViaPreviewPageSteps
    {
        IWebDriver driver;

        
        [Given(@"I am on the Application form: Preview Your Submission page")]
        public void GivenIAmOnTheApplicationFormPreviewYourSubmissionPage()
        {
            driver.Navigate().GoToUrl("http://qa1grantweb.azurewebsites.net/grants/home");
            driver.FindElement(By.Id("start-application")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("QA");
            driver.FindElement(By.Id("lastName")).SendKeys("Tester");
            driver.FindElement(By.Id("accountEmail")).SendKeys("QA0001@test.com");
            driver.FindElement(By.Id("password")).SendKeys("abcd1234");
            driver.FindElement(By.Id("confirmPassword")).SendKeys("abcd1234");
            driver.FindElement(By.Id("btnRegisterUser")).Click();
            driver.FindElement(By.Id("btnRegisterUser")).Click();
            driver.FindElement(By.Id("companyName")).Click();
            driver.FindElement(By.Id("companyName")).SendKeys("Company");
            driver.FindElement(By.Id("companyRegNo")).SendKeys("SC123456");
            driver.FindElement(By.Id("companyTypeSME")).Click();
            driver.FindElement(By.Id("companyTurnover")).Clear();
            driver.FindElement(By.Id("companyTurnover")).SendKeys("2999");
            driver.FindElement(By.Id("numberOfEmployees")).Clear();
            driver.FindElement(By.Id("numberOfEmployees")).SendKeys("3");
            driver.FindElement(By.Id("saveApplicationCont")).Click();
            driver.FindElement(By.CssSelector("#projectActivityChoices > div > div > fieldset > div:nth-child(2) > label > input")).Click();
            driver.FindElement(By.Id("7f8ab67d - 6aa4 - 4185 - 5ec9 - 08d449cfa47b_undefined")).Click();
            driver.FindElement(By.Id("header + otherItem.id")).Click();
            driver.FindElement(By.Id("header + otherItem.id")).SendKeys("Other activities text entry in the other text feild");
            driver.FindElement(By.Id("projectTitle")).Click();
            driver.FindElement(By.Id("projectTitle")).SendKeys("Project Title");
            driver.FindElement(By.Id("projectDescription")).Click();
            driver.FindElement(By.Id("projectDescription")).SendKeys("Desc test");
            driver.FindElement(By.CssSelector("#page--content > project-details > div > form > div:nth-child(5) > div:nth-child(1) > fieldset > div:nth-child(3) > div > span > span")).Click();
            driver.FindElement(By.Id("startDateString")).Click();
            driver.FindElement(By.Id("startDateString")).SendKeys("01/01/2017");
            driver.FindElement(By.CssSelector("#page--content > project-details > div > form > div:nth-child(5) > div:nth-child(1) > fieldset > div:nth-child(3) > div.input-group.date > span > span")).Click();
            driver.FindElement(By.CssSelector("#page--content > project-details > div > form > div:nth-child(5) > div:nth-child(1) > fieldset > div:nth-child(5) > div > span > span")).Click();
            driver.FindElement(By.Id("endtDateString")).Click();
            driver.FindElement(By.Id("endtDateString")).SendKeys("02/02/2017");
            driver.FindElement(By.CssSelector("#page--content > project-details > div > form > div:nth-child(5) > div:nth-child(1) > fieldset > div:nth-child(5) > div.input-group.date > span > span")).Click();
            driver.FindElement(By.CssSelector("#projectReasonChoices > div > div > fieldset > div:nth-child(2) > label > input")).Click();
            driver.FindElement(By.Id("saveApplicationCont")).Click();
            driver.FindElement(By.Id("aa29dd84-2df2-42fd-5ed6-08d449cfa47b_undefined")).Click();
            driver.FindElement(By.Id("header+otherItem.id")).Click();
            driver.FindElement(By.Id("header+otherItem.id")).SendKeys("Other Business Benefits text field entry test");
            driver.FindElement(By.CssSelector("#businessBenifits > div > div > fieldset > div:nth-child(2) > label > input")).Click();
            driver.FindElement(By.Id("saveApplicationCont")).Click();
            driver.FindElement(By.Id("usingExternalConsultantsYes")).Click();
            driver.FindElement(By.Id("usingExternalConsultantsDescription")).Clear();
            driver.FindElement(By.Id("usingExternalConsultantsDescription")).SendKeys("External consultants 'please explain' text field test");
            driver.FindElement(By.Id("quoteObtainedYes")).Click();
            driver.FindElement(By.Id("quoteObtainedNo")).Click();
            driver.FindElement(By.Id("saveApplicationCont")).Click();
            driver.FindElement(By.CssSelector("body")).Text.Contains("Preview Your Submission");
        }

        [When(@"I click on the Edit button of the Business Details section")]
        public void WhenIClickOnTheEditButtonOfTheBusinessDetailsSection()
        {
            driver.FindElement(By.CssSelector("#business--details > header > a")).Click();
        }
        
        [When(@"I am taken to the Business Details page")]
        public void WhenIAmTakenToTheBusinessDetailsPage()
        {
            driver.FindElement(By.CssSelector("#progress--indicator > li.current--step > a")).GetAttribute("Business details");
        }

        [When(@"I tick the Other\(please describe\) box under the type of activate section")]
        public void WhenITickTheOtherPleaseDescribeBoxUnderTheTypeOfActivateSection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I tick on the Other\(please describe\) box in the Business Benefits")]
        public void WhenITickOnTheOtherPleaseDescribeBoxInTheBusinessBenefits()
        {
            ScenarioContext.Current.Pending();
        
        }
        
        [Then(@"I see the information I previously entered for Company Name")]
        public void ThenISeeTheInformationIPreviouslyEnteredForCompanyName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the information I previously entered for Companies House Registration Number")]
        public void ThenISeeTheInformationIPreviouslyEnteredForCompaniesHouseRegistrationNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the information I previously entered for SME or Large Enterprise")]
        public void ThenISeeTheInformationIPreviouslyEnteredForSMEOrLargeEnterprise()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the information I previously entered for Company Turnover")]
        public void ThenISeeTheInformationIPreviouslyEnteredForCompanyTurnover()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the information I previously entered for Number of Employees")]
        public void ThenISeeTheInformationIPreviouslyEnteredForNumberOfEmployees()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I make changes to the Company Name")]
        public void ThenIMakeChangesToTheCompanyName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I make changes to the Companies House Registration Number")]
        public void ThenIMakeChangesToTheCompaniesHouseRegistrationNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I make changes to the SME or Large Enterprise")]
        public void ThenIMakeChangesToTheSMEOrLargeEnterprise()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I make changes to Company Turnover")]
        public void ThenIMakeChangesToCompanyTurnover()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I make changes to the Number of Employees")]
        public void ThenIMakeChangesToTheNumberOfEmployees()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I click on Save and Continue")]
        public void ThenIClickOnSaveAndContinue()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I navigate back to the Preview Page from the Business Details Section")]
        public void ThenINavigateBackToThePreviewPageFromTheBusinessDetailsSection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"all the updated information for the Business Details section should be on the Preview page")]
        public void ThenAllTheUpdatedInformationForTheBusinessDetailsSectionShouldBeOnThePreviewPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I click on the Edit button of the project details section")]
        public void ThenIClickOnTheEditButtonOfTheProjectDetailsSection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am taken to the Project Details page")]
        public void ThenIAmTakenToTheProjectDetailsPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the previously ticked box in the type of activity section")]
        public void ThenISeeThePreviouslyTickedBoxInTheTypeOfActivitySection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the previously entered Project Title")]
        public void ThenISeeThePreviouslyEnteredProjectTitle()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the previously entered Project description")]
        public void ThenISeeThePreviouslyEnteredProjectDescription()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the previously selected Project start date")]
        public void ThenISeeThePreviouslySelectedProjectStartDate()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the previously selected Project end date")]
        public void ThenISeeThePreviouslySelectedProjectEndDate()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the previously ticked box in the Scottish Enterprixse support required section")]
        public void ThenISeeThePreviouslyTickedBoxInTheScottishEnterprixseSupportRequiredSection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a text field should appear to enter the other activate")]
        public void ThenATextFieldShouldAppearToEnterTheOtherActivate()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter some text in field")]
        public void ThenIEnterSomeTextInField()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I change the Project title")]
        public void ThenIChangeTheProjectTitle()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I change the project description")]
        public void ThenIChangeTheProjectDescription()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I change the project start date")]
        public void ThenIChangeTheProjectStartDate()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I change the project End date")]
        public void ThenIChangeTheProjectEndDate()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I tick another box in the Scottish Enterprise support required section")]
        public void ThenITickAnotherBoxInTheScottishEnterpriseSupportRequiredSection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I navigate back to the preview page from the Project Details Page")]
        public void ThenINavigateBackToThePreviewPageFromTheProjectDetailsPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"all the updated information for the project details should be on the Preview page")]
        public void ThenAllTheUpdatedInformationForTheProjectDetailsShouldBeOnThePreviewPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the text entered in the text field in the type of activate section should be on the Preview Page")]
        public void ThenTheTextEnteredInTheTextFieldInTheTypeOfActivateSectionShouldBeOnThePreviewPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        
        [Then(@"I click on the Edit button of the Project Output section")]
        public void ThenIClickOnTheEditButtonOfTheProjectOutputSection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am taken to the Project Output page")]
        public void ThenIAmTakenToTheProjectOutputPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can see the previous ticked box of the Business Benefits")]
        public void ThenICanSeeThePreviousTickedBoxOfTheBusinessBenefits()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I text field should appear\.")]
        public void ThenITextFieldShouldAppear_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I enter some text into the text field for other Business Benefits")]
        public void ThenIEnterSomeTextIntoTheTextFieldForOtherBusinessBenefits()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I navigate back to the preview page from the Project Output Page")]
        public void ThenINavigateBackToThePreviewPageFromTheProjectOutputPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the text entered in the business benefit text field should be on the Preview Page")]
        public void ThenTheTextEnteredInTheBusinessBenefitTextFieldShouldBeOnThePreviewPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I click on the Edit button on the External Consultants")]
        public void ThenIClickOnTheEditButtonOnTheExternalConsultants()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am taken to the External Consultants page")]
        public void ThenIAmTakenToTheExternalConsultantsPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I make changes to the External Consultants for consultant")]
        public void ThenIMakeChangesToTheExternalConsultantsForConsultant()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"click on save and continue")]
        public void ThenClickOnSaveAndContinue()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I navigate back to the preview page from the External Consultant Page")]
        public void ThenINavigateBackToThePreviewPageFromTheExternalConsultantPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the changes made on the External Consultant page can been seen on the Preiew Page")]
        public void ThenTheChangesMadeOnTheExternalConsultantPageCanBeenSeenOnThePreiewPage()
        {
            ScenarioContext.Current.Pending();
        }
        [Then(@"I see the Your Details section with Edit this section button")]
        public void ThenISeeTheYourDetailsSectionWithEditThisSectionButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see Business Details Section with Edit this section button")]
        public void ThenISeeBusinessDetailsSectionWithEditThisSectionButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see Project Details section with Edit this section button")]
        public void ThenISeeProjectDetailsSectionWithEditThisSectionButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see Project Outputs section with Edit this section button")]
        public void ThenISeeProjectOutputsSectionWithEditThisSectionButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see External Consultants section with Edit this section button")]
        public void ThenISeeExternalConsultantsSectionWithEditThisSectionButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see Project Output section with Edit this section button")]
        public void ThenISeeProjectOutputSectionWithEditThisSectionButton()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
