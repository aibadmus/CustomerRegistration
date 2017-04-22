Feature: US583_ConfirmClaimAmount
	

	Scenario: page is displayed
Given I am making a claim
When I arrive at the Confirm claim amount page
Then I can see the page content
And I can see a yes/no question
And I can see the Back to claim schedule button
And I can see the Save And continue button

Scenario: fields pulled from DB are correct
Given I am logged in to my account
When I arrive at the Confirm claim amount page
Then I can see the following fields populated:

| PROJECT TITLE                | CLAIM_DEADLINE | CLAIM_TITLE                                       | TOTAL COST | INT RATE | COST                                              | CLAIM                                                   |
| Marketing graduate placement | March 2017     | quarterly salary for Scotgrad marketing assistant | 4,500      | 30%      | EITHER 4,500 OR the new value entered by the user | EITHER 1,350 OR the new value entered by the user x 0.3 |



Scenario: answering no to the question
Given that I am on the Confirm claim amount page
When I answer 'no' to the question
Then a text box drops down for me to enter an amount
And a multi-line text box drops down for me to enter a comment

Scenario: entering a monetary amount
Given that I am on the Confirm claim amount page
And I have answered 'no' to the question
When I enter a monetary amount in the first text box
Then the revised claim amount displays as 30% of the amount I entered

Scenario: moving to the previous page
Given I am on the Confirm claim amount page
And I have completed all mAndatory fields on the page
When I click on the Back to claim schedule button
Then the Your claim schedule page is displayed

Scenario: leaving any mAndatory field blank
Given I am on the Confirm claim amount page
And any mAndatory form field does not contain data
When I click on the Save changes button
Then I should receive an appropriate validation error message
And focus should return to first blank mAndatory form field

Scenario: the user has changed the claim amount
Given I am on the Confirm claim amount page
And I have answered no to the question
When I enter a new value in the claim amount box
Then the value of my claim amount is displayed alongside

Scenario: moving to the next page
Given I am on the Confirm claim amount page
When I select Save And continue
Then the Confirm claim details page is displayed