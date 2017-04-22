using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1.Step_Definitions.Sprint_4_Claims
{
    [Binding]
    public class US588_ConfirmationOfSubmissionSteps
    {
        [When(@"I arrive at the Claim confirmation page")]
        public void WhenIArriveAtTheClaimConfirmationPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can see the three blank content boxes")]
        public void ThenICanSeeTheThreeBlankContentBoxes()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can see a contact name, email address And phone number")]
        public void ThenICanSeeAContactNameEmailAddressAndPhoneNumber()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
