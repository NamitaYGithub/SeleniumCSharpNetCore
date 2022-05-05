Feature: FindPropertyForSale

A short summary of the feature

@tag1
Scenario Outline: Find property for the sale
	Given I launch the RightMove
	And I accept the cookies
	And I Select Sign In
	And I enter Email Address and password
	    | EmailAddress | Password |
	    |namitatest@yahoo.com|Password!123|    
    And I select SignIn button
	And I select the ViewMyRightMove window
	And I select Buy navbar
	And I select property for sale
	And I enter the location <Location>
	And select start search button
	And select the search radius <SearchRadius>
	And select the min price range <Minprice>
	And select the max price range <Maxprice>
	And select no. of beds <MaxnoOfBeds>
	And select the property type <PropertyType>
	And select the find properties button

	Examples: 
| Location                              | SearchRadius    | Minprice | Maxprice |MaxnoOfBeds  | PropertyType |
| Duston, Northampton, Northamptonshire | Within 20 miles | £50,000  | £70,000  |  3          | Houses       |


Scenario Outline: Mortgage Calculator
	Given I launch the RightMove
	And I accept the cookies
	And I Select Sign In
	And I enter Email Address and password
	    | EmailAddress | Password |
	    |namitatest@yahoo.com|Password!123|    
    And I select SignIn button
	And I select the ViewMyRightMove window
	And I select Buy navbar
	And I select mortgages navbar
	And I select calculate now button
	And I eneter deposit <Deposit>
	And I select next
	And I enter the annual income <AnnualIncome>
	And I select income next
	And I select mortgage term slider
	And I select term next button
	And I enter the interest rate <InterestRate>
	And I select caculate button

	Examples:
	| Deposit | AnnualIncome | InterestRate |
	| 50,000  | 83,000       |   1.5        |