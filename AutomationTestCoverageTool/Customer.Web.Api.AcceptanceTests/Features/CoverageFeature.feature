Feature: CoverageFeature	
	To get InsertCustomerFeature code Coverage
	I want to Execute Unit Test Cases

@mytag
Scenario: Passing valid customer details to Web API
	Given InsertCustomerFeature 
	| Id  | Name  | ContactNumber | EmailAddress |
	| 101 | Megha | 5829631470    | mabc@g.com   |
	When Code Coverage Required
	Then Execute UnitTestCases

	
