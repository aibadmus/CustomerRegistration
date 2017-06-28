Feature: UserStory463

@Project Details Displayed information
Scenario: Project Details page is Displayed
Given I am on the Project details page
Then the Project Details page is displayed as the current step on the progess indicator
And I can see the Save And continue button
And I can see the Save And go back button
And I can see the Project title text box
And I can see the Project description text box
And I can see an option to upload supporting documents
And I can see the Project start date field
And I can see the Project duration section

@Upload a Project Details File
Scenario: uploading a file
Given I am on the Project details page
When I upload a file
Then I can see the file name of the file I have uploaded on the page

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
#And any mandatory form field does not contain data
#When I click on the Save and Continue button
#Then I should receive an appropriate validation error message
#And all mandatory form fields contain data
#| ProjectTitle               | ProjectDescription                     |
#| My project Title is Simple |You can enter a project description up to 1000. |
#When I click on the Save And go back button
#Then the Business details page is displayed
#When I click on the Save and Continue button
#Then the Project outputs page is displayed