Feature: Project Details Page 

Scenario: Page is displayed
Given I am a logged in user
When I am on the Project Details page
Then I can see the progress indicator control
And I can see the Save & Go Back button
And I can see the Save & Continue button
And I can see the What type of activity section
And I can see the Project Title field
And I can see the Project Description field

Scenario: Help is displayed
Given I am completing an application
And I am on the Project Details page
When I focus on the What type of activity...? option set
Then the help text 'Tell us the type of activity that this project will involve. Select as many options as apply.' is displayed for the activity field
When I focus on the Project Title field
Then the help text 'Provide a short meaningful name for your project' is displayed for the project title field
When I focus on the Project Description field
Then the help text 'Describe the project in full in around 200 words. You should explain clearly how this project contributes to your business strategy' is displayed for the project description field
When I focus on the Project Timescale field
Then the help text 'The proposed start And finish dates of the project.' is displayed project timescale field
When I focus on the Why is Scottish Enterprise support...?  option set
Then the help text 'Tell us what difference Scottish Enterprise support will make to the project. Select as many options as apply.' is displayed why is SE support needed field

Scenario: Completing the form fields and moving to the next page
Given I am completing an application
And I am on the Project Details Page
And all mandatory form fields contain data
When I click on the Save & Continue button
Then the Project Outputs page is displayed

Scenario: Leaving any mandatory field blank
Given I am completing an application
And I am on the Project Details Page
And any mAndatory form field does not contain data
When I click on the Save & Continue button
Then I should receive an appropriate validation error message
And focus should return to first blank mAndatory form field
Then I should receive an appropriate validation error message

Scenario: Moving to the previous page
Given I am completing an application
And I am on the Project Details page
When I click on the Save & Go Back button
Then the Business Details page is displayed
And any previously entered data appears