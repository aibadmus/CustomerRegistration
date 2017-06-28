Feature: UserStory462
	
Scenario: Business Details page is displayed
When I am on the Business details page
Then I can see the progress indicator control
And I can see the Save And continue button
And I can see the Business name field
And I can see the Companies House registration number field
And I can see the SME radio button option
And I can see the Large enterprise radio button option
And I can see the Yes radio button to the De minimis question
And I can see the No radio button to the De minimis question
And I close the browser

Scenario: Help is displayed
When I am on the Business details page
Then the help text is displayed under the Company name question
Then the help text is displayed under the Company registration number question
Then I see the Companies House Website Link
Then the help text is displayed under the SME question
Then the help text is displayed under the De minimis question
And I close the browser


Scenario: Answering no to the de minimis question
When I am on the Business details page
When I select NO on the de minimis question
Then a check box appears with the following label: I confirm that I haven't received any de minimis aid in my last 3 financial years.
And I close the browser

Scenario: Answering yes to the de minimis question
When I am on the Business details page
And I have answered YES to the de minimis question
Then I see Type of de minimis table drop down option
Then I see Financial Year table drop down option
Then I see Amount text field
And I close the browser

Scenario: Adding additional rows to the de minimis table
When I am on the Business details page
And I have answered YES to the de minimis question
When I click on the Add more rows button
Then an additional data entry row is added to the bottom of the table
And I close the browser

Scenario: Removing rows to the de minimis table
When I am on the Business details page
And I have answered YES to the de minimis question
When I click on the Add more rows button
When I click on the button Delete row
Then the row I am on is removed from the table
And I close the browser

Scenario: Clicking on the Companies House website link
When I am on the Business details page
When I click on the Companies House website link
Then the companies house website opens in a new browser tab: https://beta.companieshouse.gov.uk/
And I close the browser

Scenario: clicking on the European Currency Conversion tool link
When I am on the Business details page
And I have answered YES to the de minimis question
When I click on the European Currency Conversion Tool link
Then the European Commission currency conversion website opens in a new browser tab : http://ec.europa.eu/budget/contracts_grants/info_contracts/inforeuro/index_en.cfm
And I close the browser


Scenario: Completing the form fields And moving to the next page
When I am on the Business details page
And I enter the mandatory fields on the Business Details page
| BusinessName |CompanyRegNo |
| QATest@2Cool | SC12345     |
And I select the SME radio button
And I have answered YES to the de minimis question
And I select a Type of De Minimis
And I select the De Minimis Financial Year
And I enter the De Minimis Amount
When I click on the Save and Continue button
Then the Project details page is displayed
And I close the browser

Scenario: Leaving any mandatory field blank
When I am on the Business details page
When I click on the Save and Continue button
Then I should receive an appropriate validation error message
And focus should return to first blank mandatory form field
And I close the browser
