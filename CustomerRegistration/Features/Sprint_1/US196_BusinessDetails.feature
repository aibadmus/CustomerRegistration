Feature: Business Details page content

Scenario: Page is displayed
Given I am a logged in user
When I am on the Business Details page
Then I can see the progress indicator control
And I can see the Save & Go Back button
And I can see the Save &Continue button
And I can see the Company name field
And I can see the Companies House Registration Number field
And I can see the SME field
And I can see the Company Turnover field
And I can see the Number of Employees field
And I close business details page

Scenario: Help information is displayed
Given I am a logged in user
And I am on the Business Details page
When I focus on the Company Name field
Then the help text 'The name your company is registered as at Companies House' is displayed
When I focus on the Companies House registration number field
Then the help info for registration number text 'The registration number of your business can be found on the Companies House website' is displayed
When I focus on the Is the company an SME field
Then the help text for SME 'An SME is an enterprise which employ fewer than 250 persons And which has an annual turnover not exceeding 50 million euro, And/or an annual balance sheet total not exceeding 43 million euro And is independent. An independent enterprise:  no more than 25% of the capital or voting rights are owned by one or more enterprises which fall outside the SME definition.' is displayed
When I focus on the Company Turnover field
Then the help info for  Company Turnover text 'The total global turnover of your business at its latest financial year end in pounds sterling.' is displayed
When I focus on the Number of employees field
Then the help info of Number of employee text 'Total global full time equivalent job numbers at latest financial year end.' is displayed
And I close business details page


Scenario: entering incompatible data in any form field
Given I am a logged in user
And I am on the Business Details page
When I enter incompatible characters in any form field
|CompanyName  | CompanyRegNo    |     CompanyTurnover | NumberofEmployees |
|Mycompany    | SC00123         |                     |                   |
And I click on the Save & Continue button
Then I should receive an appropriate validation error message for the company Turnover details
Then I should receive an appropriate validation error message for the Number of Employee
And I close business details page

Scenario: completing the form fields and moving to the next page
Given I am a logged in user
And I am on the Business Details page
And I select the SME radio button
And all mandatory form fields contain data
|CompanyName  | CompanyRegNo    |     CompanyTurnover | NumberofEmployees |
|Mycompany12   | SC0012345        |        1000         |       50          |
When I click on the Save & Continue button
Then the Project Details page is displayed
And I close business details page

Scenario: leaving any mandatory field blank
Given I am a logged in user
And I am on the Business Details page
And any mAndatory form field does not contain data
When I click on the Save & Continue button
Then I should receive an appropriate validation error message
And focus should return to first blank mandatory form field
Then I should receive an appropriate validation error message

Scenario: moving to the previous page
Given I am a logged in user
And I am on the Business Details page
And I select the SME radio button
And all mandatory form fields contain data
|CompanyName  | CompanyRegNo    |     CompanyTurnover | NumberofEmployees |
|Mycompany12  | SC0012345       |        1000         |       50          |
When I click on the Save & Go Back button
Then the Your Details page is displayed