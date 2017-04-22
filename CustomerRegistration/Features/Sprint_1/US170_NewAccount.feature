Feature: New customer registration

Background:
I want to start an application
I do not already have an online account

@Password not matching
Scenario: Password fields don't match

Given I want to start an application
And I do not already have an online account
When I provide the details on the Application form: New account page
|FirstName  | Surname    | EmailAddress                  | Password       | Confirmpassword|
|Simon      | Templer    | Jamsonjjpppj907@0088.co.uk    | Password123   |   WordPass123   |
And I click on the Enter a Password field
Then an error message should appear that the password doesn't match
And I update the password to match
|FirstName  | Surname    | EmailAddress                  | Password       | Confirmpassword|
|           |            |                               | Password123    |   Password123   |
And I click on the Register button
Then the Application form: Business Details page should appear
And I close browser

@Incorrect Email Details 
Scenario: The user provides incorrect details on the application form and clicks on register

Given I want to start an application
And I do not already have an online account
When I provide the details with an invalid email on the Application form: New account page
|FirstName  | Surname    | EmailAddress                   | Password      | Confirmpassword|
|Simon      | Templer    | JamesBond.co.uk                | Password123   |   Password123  |
And I click on the Register button
Then an error message should appear that email should be in the format
And I Update the email to the correct format
|FirstName  | Surname    | EmailAddress                   | Password      | Confirmpassword|
|           |            | James00bbkhBond@.co.uk            | Password123   |   Password123  |
And I click on the Register button
Then the Application form: Business Details page should appear
And I close browser


Scenario: The user provides details on the application form and clicks on register

Given I want to start an application
And I do not already have an online account
When I provide the details on the Application form: New account page
|FirstName  | Surname    | EmailAddress                  | Password       | Confirmpassword|
|Simon      | Templer    | James0047ondk06@scotent.co.uk    | Password123   |   Password123   |
And I click on the Register button
Then the Application form: Business Details page should appear
And I close browser