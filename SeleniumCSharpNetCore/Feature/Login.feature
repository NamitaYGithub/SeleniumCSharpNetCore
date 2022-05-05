Feature: Login

		

@mytag
Scenario Outline: Login to the RightMove
	Given I launch the RightMove
	And I accept the cookies
	And I Select Sign In
	And I enter Email Address and password
	    | EmailAddress | Password |
	    |namitatest@yahoo.com|Password!123|    
    And I select SignIn button
	
	
	




