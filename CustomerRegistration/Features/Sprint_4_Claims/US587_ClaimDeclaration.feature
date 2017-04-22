Feature: US587
	

Scenario: the page is displayed
Given I am completing a claim
When I arrive at the Claim declaration page
Then I can see the page content
And I can see a confirmation checkbox
And I can see the Save And go back button
And I can see the Submit your claim button

Scenario: fields pulled from DB are correct
Given I am logged in to my account
When I arrive at the Claim declaration page
Then I can see the following fields populated:
| PROJECT TITLE                | CLAIM DEADLINE |
| Marketing graduate placement | March 2017     |


Scenario: moving to the next page
Given that I am on the Claim declaration page
And I have completed checked the confirmation checkbox
When I click on the Submit your claim button
Then the Claim confirmation page is displayed

Scenario: moving to the previous page
Given that I am on the Claim declaration page
When I click on the Save And go back button
Then the Claim summary page is displayed

Scenario: not checking the checkbox
Given I am on the Claim declaration page
And I have not checked the confirmation checkbox
When I click on the Submit your claim button
Then I should receive an appropriate validation error message