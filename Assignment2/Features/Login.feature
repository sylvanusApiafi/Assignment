Feature: Login
As a registered user of Giftrete
I would like to log in
So that i can use the site

@mytag
Scenario: Login to the site
	Given I navigate to the site
    When I click on login link
	And I enter username
	And I enter password
	Then I am logged in to the site
