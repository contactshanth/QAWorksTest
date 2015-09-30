Feature: ContactUsPage
  As an end user
  I want a contact us page
  So that I can find out more about QAWorks exciting services

@mytag
	Scenario Outline:  Valid Submission
	Given I am on the QAWorks <Site> and Click 
	Then Then I should be able to contact QAWorks with <name> and <email> the <message> information
	Examples:  
    | Site    | name		  | email			     | message								    |
    | Qaworks | j.Bloggs      | j.Bloggs@qaworks.com | please contact me  want to find out more |

	

