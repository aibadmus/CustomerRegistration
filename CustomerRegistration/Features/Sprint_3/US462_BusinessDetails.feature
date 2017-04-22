Feature: UserStory462
	
Scenario: Page is displayed
//Given I am completing an application
When I am on the Business details page
Then I can see the progress indicator control
And I can see the Save And continue button
And I can see the Business name field
And I can see the Companies House registration number field
And I can see the SME radio button option
And I can see the Large enterprise radio button option
And I can see the Yes radio button to the De minimis question
And I can see the No radio button to the De minimis question

#
#Scenario: Help is displayed
#Given I am completing an application
#When I am on the Business details page
#Then the help text 'The name of your company as registered at Companies House.' is displayed under the Company name question
#And the help text 'You can find your unique 10 digit number on the Companies House website.' is displayed under the Company registration number question
#And the help text 'You're an SME if you have fewer than 250 employees with an annual turnover of less than EURO 50m And are independent. You're independent as long as no large enterprise(s) own more than 25% of your capital or voting rights.' is displayed under the SME question
#And the help text 'De minimis aid is a type of public sector funding. You're notified in writing if awarded this type of aid. You need to tell us about de minimis aid as there's a limit to the funding you can get over a 3-year period.' is displayed under the de minimis question
#
#Scenario: Answering no to the de minimis question
#Given I am on the Business details page
#When I select 'no' on the de minimis question
#Then a check box appears with the following label: I confirm that I haven't received any de minimis aid in my last 3 financial years.
#
#Scenario: Answering yes to the de minimis question
#Given I am on the Business details page
#When I select 'yes' on the de minimis question
#Then I see Type of de minimis table drop down option
#Then I see Financial Year table drop down option
#Then I see Amount text field
#
#Scenario: Adding additional rows to the de minimis table
#Given I am on the Business details page
#And I have answered 'yes' to the de minimis question
#When I click on the button Add more rows
#Then an additional data entry row is added to the bottom of the table
#
#Scenario: Removing rows to the de minimis table
#Given I am on the Business details page
#And I have answered 'yes' to the de minimis question
#And I have clicked on the button Add more rows
#When I click on the button Delete row
#Then the row I am on is removed from the table
#
#Scenario: Clicking on the Companies House website link
#Given I am on the Business details page
#When I click on the link 'Companies House website'
#Then a new window opens
#And the following page is displayed in the new window: https://beta.companieshouse.gov.uk/
#
#Scenario: clicking on the European Currency Conversion tool link
#Given I am on the Business details page
#When I click on the link 'European Currency Conversion tool'
#Then a new window opens
#And the following page is displayed in the new window: http://ec.europa.eu/budget/contracts_grants/info_contracts/inforeuro/index_en.cfm
#
#Scenario: Entering incompatible data in any form field
#Given I am on the Business details page
#When I enter incompatible characters in any form field
#Then I should receive an appropriate validation error message
#
#Scenario: Completing the form fields And moving to the next page
#Given I am on the Business details page
#And all mAndatory form fields contain data
#When I click on the Save And continue button
#Then the Project details page is displayed
#
#Scenario: Leaving any mandatory field blank
#Given I am on the Business details page
#And any mandatory form field does not contain data
#When I click on the Save And continue button
#Then I should receive an appropriate validation error message
#And focus should return to first blank mAndatory form field
