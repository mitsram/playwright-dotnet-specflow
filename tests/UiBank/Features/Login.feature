Feature: Login
    As a user, I want log in into UiBank, so that I can access my accounts

    Scenario: Successful login
        Given I am on the login page
        When I log in with valid credentials
        Then I should see my accounts dashboard
