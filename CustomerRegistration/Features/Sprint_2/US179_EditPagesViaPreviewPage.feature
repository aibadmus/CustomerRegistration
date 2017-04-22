Feature: Edit Pages Via Preview Page


@Preview Page content
Scenario: Sections on the preview page
Given I am on the Preview page of my application
Then I see the Your Details section with Edit this section button
Then I see Business Details Section with Edit this section button
Then I see Project Details section with Edit this section button
Then I see Project Outputs section with Edit this section button
Then I see External Consultants section with Edit this section button


@Business Details page
Scenario: Editing the Business Details section
Given I am completing an application form
And I am on the Application form: Preview Your Submission page
Then I see Business Details Section with Edit this section button
When I click on the Edit button of the Business Details section
And I am taken to the Business Details page
Then I see the information I previously entered for Company Name
Then I see the information I previously entered for Companies House Registration Number 
Then I see the information I previously entered for SME or Large Enterprise 
Then I see the information I previously entered for Company Turnover 
Then I see the information I previously entered for Number of Employees
And I make changes to the Company Name
And I make changes to the Companies House Registration Number 
And I make changes to the SME or Large Enterprise
And I make changes to Company Turnover
And I make changes to the Number of Employees
And I click on Save and Continue
And I navigate back to the Preview Page from the Business Details Section
Then all the updated information for the Business Details section should be on the Preview page


@Project Details Page
Scenario: Editing the Project Details Page
Given I am completing an application form 
And I am on the Application form: Preview Your Submission page
Then I see Project Details section with Edit this section button
And I click on the Edit button of the project details section
And I am taken to the Project Details page
Then I see the previously ticked box in the type of activity section
Then I see the previously entered Project Title
Then I see the previously entered Project description
Then I see the previously selected Project start date 
Then I see the previously selected Project end date 
Then I see the previously ticked box in the Scottish Enterprixse support required section
When I tick the Other(please describe) box under the type of activate section
Then a text field should appear to enter the other activate
And I enter some text in field
And I change the Project title
And I change the project description
And I change the project start date
And I change the project End date
And I tick another box in the Scottish Enterprise support required section
And I click on Save and Continue
And I navigate back to the preview page from the Project Details Page
Then all the updated information for the project details should be on the Preview page
Then the text entered in the text field in the type of activate section should be on the Preview Page


@Project Outputs Page
Scenario: Editing the Project Output Page
Given I am completing an application form 
And I am on the Application form: Preview Your Submission page
Then I see Project Output section with Edit this section button
And I click on the Edit button of the Project Output section
And I am taken to the Project Output page
And I can see the previous ticked box of the Business Benefits
When I tick on the Other(please describe) box in the Business Benefits 
Then I text field should appear.
And I enter some text into the text field for other Business Benefits 
And I click on Save and Continue
And I navigate back to the preview page from the Project Output Page 
Then the text entered in the business benefit text field should be on the Preview Page 


@External Consultant
Scenario: Editing the External Consultant
Given I am completing an application form 
And I am on the Application form: Preview Your Submission page
Then I see External Consultants section with Edit this section button
And I click on the Edit button on the External Consultants
Then I am taken to the External Consultants page 
And I make changes to the External Consultants for consultant
And click on save and continue
And I navigate back to the preview page from the External Consultant Page
Then the changes made on the External Consultant page can been seen on the Preiew Page 