Feature: US641_ConfirmClaimDetails
	

Scenario: page is displayed
Given I am making a claim
When I arrive at the Confirm claim details page
Then I can see a summary box
And I can see the Project title
And I can see the Claim period
And I can see the Claim deadline
And I can see the Cost to business
And I can see the Claim amount

Scenario: fields pulled from DB are correct
Given I am logged in to my account
When I arrive at the Confirm claim details page
Then I can see the following fields populated:
| PROJECT_TITLE                     | CLAIM DEADLINE | CLAIM TITLE                                       | TOTAL COST | INT RATE | CLAIM PERIOD START | CLAIM PERIOD END | COST                                              | CLAIM                                                   |
| Marketing graduate placement 2017 | March 2017     | Quarterly salary for Scotgrad marketing assistant | 4,500      | 30%      | Dec 2016           | Feb 2017         | EITHER 4,500 OR the new value entered by the user | EITHER 1,350 OR the new value entered by the user x 0.3 |

Scenario: moving to the previous page
Given I am on the Confirm claim details page
When I click on the Save And go back button
Then the Confirm claim amount page is displayed

Scenario: selecting Save And exit claim
Given I am on the Confirm claim details page
When I select Save And exit claim
Then the Claim schedule page is displayed

Scenario: moving to the next page
Given I am on the Confirm claim details page
When I select Save And continue
Then the Upload your evidence page is displayed