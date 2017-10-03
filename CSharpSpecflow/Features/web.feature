@pbi1234
@web
Feature: Sample Feature for web applications - Google
	In order to demonstrate the value of an open-source automation solution
	As a QA Automation Engineer
	I want to give an example of how to test using a feature file

	Scenario Outline: Test Scenario
      Given I am a user on Google
	  When I enter text "<searchString>" in the text field "Search" by "id" with selector "lst-ib"
      And I hit Enter by "id" with selector "lst-ib"
      Then I should be directed to "Google Search Results" page by "id" with selector "rcnt"
      And I should see value "<searchString>" in "search" field by "id" with selector "lst-ib"
      Examples:
        | searchString                           |
        | how wonderful is the Gherkin language? |

	Scenario Outline: Test Scenario 2
      Given I am a user on Google
	  When I enter text "<searchString>" in the text field "Search" by "id" with selector "lst-ib"
      And I hit Enter by "id" with selector "lst-ib"
      Then I should be directed to "Google Search Results" page by "id" with selector "rcnt"
      And I should see value "<searchString>" in "search" field by "id" with selector "lst-ib"
      Examples:
        | searchString   |
        | did I do that? |
