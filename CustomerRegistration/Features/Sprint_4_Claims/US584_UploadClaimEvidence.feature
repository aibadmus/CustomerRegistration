Feature: US584_UploadClaimEvidence
	

	Scenario: page is displayed
Given I am making a claim
When I arrive at the Upload your evidence page
Then I can see the page content
And I can see multiple upload options
And I can see a multi-line text box
And I can see the Save And go back button
And I can see the Save And exit claim button
And I can see the Save And continue button

Scenario: fields pulled from DB are correct
Given I am logged in to my account
When I arrive at the Upload your evidence page
Then I can see the following fields populated:
| PROJECT_TITLE                | CLAIM DEADLINE | CLAIM TITLE                                       | INT RATE |
| Marketing graduate placement | March 2017     | quarterly salary for Scotgrad marketing assistant | 30%      |


Scenario: uploading a file
Given I am on the Upload your evidence page
When I click Choose file
Then a dialogue box appears
And I can choose a file to upload from my computer
And I can see the file name of the file I have uploaded on the page

Scenario: removing an uploaded file
Given I am on the Upload your evidence page
And I have uploaded a file
When I click on Remove file
Then a dialogue appears asking me to confirm the file removal
And  I can click OK to remove the file
And the file name of the file I have removes no longer appears on the page

Scenario: moving to the previous page
Given I am on the Upload your evidence page
When I click on the Save And go back button
Then the Confirm claim details page is displayed

Scenario: selecting Save And exit claim
Given I am on the Upload your evidence page
When I select Save And exit claim
Then the Claim schedule page is displayed

Scenario: moving to the next page
Given I am on the Upload your evidence page
When I select Save And continue
Then the Claim summary page is displayed