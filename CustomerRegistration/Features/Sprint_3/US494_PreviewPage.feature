Feature: US494_PreviewPage
	
Scenario: seeing the preview page
Given I have completed an application form
When I am on the Application form: Preview your submission page
Then I can see the Business details section
And I can see the Project details section
And I can see the Project outputs section
And I can see the External consultants section

Scenario: editing the Business details section
Given I have completed an application form
And I am on the Application form: Preview your submission page
When I click on the Edit this section button of the Business details section
Then I am taken to the Business details page
And all data I have entered is prepopulated
And I am able to edit any form field

Scenario: saving edited fields in the Business details section
Given I have completed an application form
And I have reached the Preview your submission page
And I have clicked on the Edit this section button for the Business details page
Then I can see my changes on the Preview your submission page

Scenario: editing the Project details section
Given I have completed an application form
And I am on the Application form: Preview your submission page
When I click on the Edit this section button of the Project details section
Then I am taken to the Project details page
And all data I have entered is prepopulated
And I am able to edit any form field

Scenario: saving edited fields in the Project details section
Given I have completed an application form
And I have reached the Preview your submission page
And I have clicked on the Edit this section button for the Project details section 
And I have edited one or more form fields on the Project details page
When I click on Save And continue to reach the Preview your submission page
Then I can see my changes on the Preview your submission page

Scenario: editing the Project outputs section
Given I have completed an application form
And I am on the Application form: Preview your submission page
When I click on the Edit this section button of the Project outputs section
Then I am taken to the Project outputs page
And all data I have entered is prepopulated
And I am able to edit any form field

Scenario: saving edited fields in the Project outputs section
Given I have completed an application form
And I have reached the Preview your submission page
And I have clicked on the Edit this section button for the Project outputs section 
And I have edited one or more form fields on the Project outputs page
When I click on Save And continue to reach the Preview your submission page
Then I can see my changes on the Preview your submission page

Scenario: editing the External consultants section
Given I have completed an application form
And I am on the Application form: Preview your submission page
When I click on the Edit this section button of the External consultants section
Then I am taken to the External consultants page
And all data I have entered is prepopulated
And I am able to edit any form field

Scenario: saving edited fields in the External consultants section
Given I have completed an application form
And I have reached the Preview your submission page
And I have clicked on the Edit this section button for the External consultants section 
And I have edited one or more form fields on the External consultants page
When I click on Save And continue to reach the Preview your submission page
Then I can see my changes on the Preview your submission page

Scenario: moving to the next page
Given I am on the Preview Your Submission page
When I click on the Declaration & Submit button
Then the Declaration And Submission page appears