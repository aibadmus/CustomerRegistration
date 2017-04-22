Feature: US466_ExternalConsult
	
Scenario: Page is displayed
Given I am completing an application
When I am on the External consultants page
Then I can see the progress indicator control
And I can see the Save And continue button
And I can see the Save And go back button
And I can see the Are you using external consultants...? question

Scenario: Help is displayed
Given I am completing an application
When I am on the External consultants page
Then the help text 'An external consultant is someone not employed by you who you pay to carry out the work for you.' is displayed under the first question

Scenario: Answering 'no' to the first question
Given I am on the External consultants page
When I select 'no' for the first question
Then the following message appears: 'Thank you. You can continue to the next page.'

Scenario: Answering 'yes' to the first question
Given I am on the External consultants page
When I select 'yes' for the first question
Then the question: 'Did you get competitive quotes for this work?' appears

Scenario: Answering 'no' to the competitive quotes question
Given I am on the External consultants page
And I have answered 'yes' to the first question
When I answer 'no' to the question 'Did you get competitive quotes...'
Then I see 'Please tell us why you didn't get competitive quotes' text box
And the question 'Do any third parties have a declared interest in this project?' appears

Scenario: Answering 'yes' to the competitive quotes question
Given I am on the External consultants page
And I have answered 'yes' to the first question
When I answer 'yes' to the question 'Did you get competitive quotes...'
Then an option to upload files appears
And  the question 'Do any third parties have a declared interest in this project?' appears

Scenario: uploading a file
Given I am on the External consultants page
And I have answered 'yes' to the first question
And I have answered 'yes' to the question 'Did you get competitive quotes...'
When I click Choose file
Then a dialogue box appears
And I can choose a file to upload from my computer
And I can see the file name of the file I have uploaded on the page

Scenario: removing an uploaded file
Given I am on External consultants page
And I have answered 'yes' to the first question
And I have answered 'yes' to the question 'Did you get competitive quotes...'
And I have uploaded a file
When I click on Remove file
Then a dialogue appears asking me to confirm the file removal
And  I can click OK to remove the file
And the file name of the file I have removes no longer appears on the page

Scenario: answering 'yes' to the declared interest question
Given I am on the External consultants page
And I have answered 'yes' to the first question
And I have answered 'no' or 'yes' to the 'Did you get competitive quotes...' question
When I answer 'yes' to the declared interest question
Then a text box appears with the following label: ' Please give us details about this conflict of interest'

Scenario: entering incompatible data in any form field
Given I am on the External consultants page
When I enter incompatible characters in any form field
Then I should receive an appropriate validation error message

Scenario: completing the form fields And moving to the next page
Given I am on the External consultants page
And all mAndatory form fields contain data
When I click on the Save And continue button
Then the Preview page is displayed

Scenario: leaving any mAndatory field blank
Given I am on the External consultants page
And any mAndatory form field does not contain data
When I click on the Save And continue button
Then I should receive an appropriate validation error message
And focus should return to first blank mAndatory form field

Scenario: moving to the previous page
Given I am on the External consultants page
When I click on the Save And go back button
Then the Project outputs page is displayed