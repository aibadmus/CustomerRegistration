Feature: US586_ClaimSummary
	

Scenario: page is displayed
Given I am making a claim
When I arrive at the Claim summary page
Then I can see the page content
And I can see the Save And go back button
And I can see the Save And exit claim button
And I can see the Save And continue button

Scenario: fields pulled from DB are correct
Given I am logged in to my account
When I arrive at the Claim summary page
Then I can see the following fields populated:
| PROJECT TITLE                     | CLAIM DEADLINE | CLAIM TITLE                                       | COST                                              | CLAIM                                                   |
| Marketing graduate placement 2017 | March 2017     | Quarterly salary for Scotgrad marketing assistant | EITHER 4,500 OR the new value entered by the user | EITHER 1,350 OR the new value entered by the user x 0.3 |

Scenario:  seeing previously edited amounts
Given I am making a claim
And I have previously edited the claim amount for this claim
When I arrive at the Claim summary page
Then I can see the amount that I have edited has been changed.

Scenario: seeing previously uploaded files
Given I am making a claim
And I have previously uploaded claims evidence for this claim
When I arrive at the Claim summary page
Then I can see the files I have previously uploaded listed on the page in the correct sections

Scenario: seeing previously entered supporting information
Given I am making a claim
And I have previously entered additional supporting information
When I arrive at the Claim summary page
Then I can see the text I have previously entered in the Additional information section

Scenario: moving to the previous page
Given I am on the Claim summary page
When I click on the Save And go back button
Then the Upload your evidence page is displayed

Scenario: selecting Save And exit claim
Given I am on the Claim summary page
When I select Save And exit claim
Then the Claim schedule page is displayed

Scenario: moving to the next page
Given I am on the Claim summary page
And I have checked the confirmation of evidence check box
When I select Save And continue
Then the Claim declaration page is displayed