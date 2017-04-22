Feature: US588_ConfirmationOfSubmission


Scenario: page is displayed
Given I am making a claim
When I arrive at the Claim confirmation page
Then I can see the page content
And I can see the three blank content boxes
And I can see a contact name, email address And phone number

Scenario: fields pulled from DB are correct
Given I am logged in to my account
When I arrive at the Claim confirmation page
Then I can see the following fields populated:
| PROJECT TITLE                     | CLAIM DEADLINE |
| Marketing graduate placement 2017 | March 2017     |