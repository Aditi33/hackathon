Feature: InsertCustomer
	In order to store data
	As an admin
	I want to store customer data with can be access from anywhere

@mytag
Scenario: Passing valid customer details to Web API
	Given there is no blob present for this ID
	| Id  | Name  | ContactNumber | EmailAddress |
	| 101 | Megha | 5829631470    | mabc@g.com   |
	When I send customer data to Web API
	| Id  | Name  | ContactNumber | EmailAddress |
	| 101 | Megha | 5829631470    | mabc@g.com   |
	Then customer blob should be created
	| Id  | Name  | ContactNumber | EmailAddress |
	| 101 | Megha | 5829631470    | mabc@g.com   |

	