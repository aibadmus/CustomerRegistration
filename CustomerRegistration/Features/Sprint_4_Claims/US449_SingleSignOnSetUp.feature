Feature: US449_SingleSignOnSetUp
	
Scenario:Log in button 
Given I am not logged in
When I view the client app
Then I can see a log in button

Scenario: Azure b2c login page
Given I am not logged in
When I click the login button
Then I am taken to the azure b2c login page

Scenario: Successfully Logged in
Given I am not logged in
And I am taken to the azure b2c login page
When I log in successfully via the azure B2C page
Then I returned to my original page, via the auth API
And a session is created which expires in 20 minutes

