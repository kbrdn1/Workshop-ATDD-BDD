Feature: Login user with username and password
  
  Background: 
    Given User is at home page
    
    Scenario: User logs in with valid username and password
        When I enter username "bee" and password "bug"
        And I click the login button
        Then I should see the home page
      
    Scenario: User logs in with invalid username and password
        When I enter username "bee" and password "bug"
        And I click the login button
        Then I should see an error message "Invalid credentials"