Feature: Registration
	As a user of the site 
	I want to register 
	So that I can use the site

@mytag
Scenario: Navigating to the Registration Page
	Given I Navigate to the site
	When i Click on registration button
	Then I am on the registration page


Scenario: Registration of users
	Given I Navigate to the site
	When i Click on registration button
	And I am on the registration page
	And I fill the form
	Then I am registered


