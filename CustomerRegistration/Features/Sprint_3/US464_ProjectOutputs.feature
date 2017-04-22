Feature: US464_ProjectOutputs
	
Scenario: Page is displayed
Given I am completing an application
When I am on the Project outputs page
Then I can see the progress indicator control
And I can see the Save And continue button
And I can see the Save And go back button
And I can see the Business benefits text box
And I can see the Turnover question
And I can see the International revenue question
And I can see the Staff question
And I can see the High value jobs question
And I can see the Safeguarding question
And I can see the Savings question

Scenario: Help is displayed
Given I am completing an application
When I am on the Project outputs page
Then the help text 'Please tell us the business benefits of the project. This could be a new or improved product, service or process; improved leadership or management capability; improved ICT or other infrastructure; new markets entered; improved knowledge; efficiency gains. 1000 characters is around 200 words.' is displayed under the Business benefits question
And the help text 'Please give us information as a direct result of your business in ScotlAnd And not your business as a whole. Tell us what you think the impact will be in years 1, 2 And 3.' is displayed under the heading Long term benefits of this project
And the help text 'High value jobs are jobs with a salary more than £36,321 per annum.' is displayed under the High value jobs question

Scenario: selecting 'yes' to the turnover question
Given I am on the Project outputs page
When I select 'yes' to the turnover question
Then a text box appears with the label Turnover for last financial year
And a text box appears with the label Year 1
And a text box appears with the label Year 2
And a text box appears with the label Year 3

Scenario: selecting 'yes' to the international revenue question
Given I am on the Project outputs page
When I select 'yes' to the international revenue question
Then a text box appears with the label Current international revenue
And a text box appears with the label Year 1
And a text box appears with the label Year 2
And a text box appears with the label Year 3

Scenario: selecting 'yes' to the creating more jobs question
Given I am on the Project outputs page
When I select 'yes' to the jobs question
Then a text box appears with the label Year 1
And a text box appears with the label Year 2
And a text box appears with the label Year 3

Scenario: selecting 'yes' to the high value jobs question
Given I am on the Project outputs page
When I select 'yes' to the high value jobs question
Then a text box appears with the label Current number of high value jobs
And a text box appears with the label Year 1
And a text box appears with the label Year 2
And a text box appears with the label Year 3

Scenario: selecting 'yes' to the safeguarding jobs question
Given I am on the Project outputs page
When I select 'yes' to the safeguarding jobs question
Then a text box appears with the label Year 1
And a text box appears with the label Year 2
And a text box appears with the label Year 3

Scenario: selecting 'yes' to the savings question
Given I am on the Project outputs page
When I select 'yes' to the savings question
Then a text box appears with the label Year 1
And a text box appears with the label Year 2
And a text box appears with the label Year 3

Scenario: entering incompatible data in any form field
Given I am on the Project outputs page
When I enter incompatible characters in any form field
Then I should receive an appropriate validation error message

Scenario: completing the form fields And moving to the next page
Given I am on the Project outputs page
And all mAndatory form fields contain data
When I click on the Save And continue button
Then the External consultants page is displayed

Scenario: leaving any mAndatory field blank
Given I am on the Project outputs Page
And any mAndatory form field does not contain data
When I click on the Save And continue button
Then I should receive an appropriate validation error message
And focus should return to first blank mAndatory form field

Scenario: moving to the previous page
Given I am on the Project outputs page
When I click on the Save And go back button
Then the Project details page is displayed