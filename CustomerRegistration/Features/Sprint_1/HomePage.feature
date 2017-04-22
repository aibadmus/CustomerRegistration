Feature: Register a new User

@DisplayPage
Scenario: Page is displayed
Given I am a new user
And I am not logged in
When I am on the Apply for Domestic Market Development Support page
Then I can see the page content
And I can see the Start New Application button
When I click on the Start New Application button
Then the Application form: New Account page is displayed
And I close browser