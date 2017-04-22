Feature: US582_ClaimSchedule

Scenario: page displays
Given I am logged in to my account
When I arrive at the Your claim schedule page
Then I can see a table with four claims listed
And I can see the Start claim button
And I can see four Claim details buttons
And I can see the What you will need for your claim block
And I can see three links to examples

Scenario: fields pulled from DB are correct
Given I am logged in to my account
When I arrive at the Your claim schedule page
Then I can see the following fields populated:
|Project Title                     | Claim Deadline    | Claim Title                                         |
|Marketing graduate placement      | March 2017        | quarterly salary for Scotgrad marketing assistant   |


Scenario: selecting Start claim
Given I am on the Your claim schedule page
When I click on Start claim
Then the Confirm claim amount page is displayed

Scenario: selecting any See example link
Given I am on the Your claim schedule page
When I click on any link to See example
Then the following page opens in a new window: https://www.scottish-enterprise.com/claims