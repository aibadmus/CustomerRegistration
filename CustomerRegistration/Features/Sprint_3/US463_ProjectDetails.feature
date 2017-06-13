Feature: UserStory463

Scenario: Project Details page is Displayed
When I am on the Project details page
Then the Project Details page is displayed as the current step on the progess indicator
And I can see the Save And continue button
And I can see the Save And go back button
And I can see the Project title text box
And I can see the Project description text box
And I can see an option to upload supporting documents
And I can see the Project start date field
And I can see the Project duration options question

#Scenario: Help is displayed
#When I am on the Project details page
#Then the help text 'Choose a short title that describes your project. 100 characters is about 20 words.' is displayed under the Project title question
#And the help text 'Explain how your project contributes to your business strategy And benefits your company. 1000 characters is around 200 words.' is displayed under the Project description question
#And the help text 'Example documents include your project plan, marketing strategy or sales forecast. Each file size should not be more than 10 MB.' is displayed under the document upload question
#And the help text 'Tell us When you'd like to start the project. Please note that the project can't start until we've approved your application.' is displayed under the Project start date question
#And the help text 'Please tell us how long you think the project will take.' is displayed under the Project duration question
#
#Scenario: uploading a file
#Given I am on the Project details page
#When I click Choose file
#Then a dialogue box appears
#And I can choose a file to upload from my computer
#And I can see the file name of the file I have uploaded on the page
#
#Scenario: removing an uploaded file
#Given I am on the Project details page
#And I have uploaded a file
#When I click on Remove file
#Then a dialogue appears asking me to confirm the file removal
#And  I can click OK to remove the file
#And the file name of the file I have removes no longer appears on the page
#
#Scenario: completing the form fields And moving to the next page
#Given I am on the Project details page
#And all mandatory form fields contain data
#When I click on the Save And continue button
#Then the Project outputs page is displayed
#
#Scenario: leaving any mAndatory field blank
#Given I am on the Project Details Page
#And any mAndatory form field does not contain data
#When I click on the Save And continue button
#Then I should receive an appropriate validation error message
#And focus should return to first blank mAndatory form field
#
#Scenario: moving to the previous page
#Given I am on the Project details page
#When I click on the Save And go back button
#Then the Business details page is displayed