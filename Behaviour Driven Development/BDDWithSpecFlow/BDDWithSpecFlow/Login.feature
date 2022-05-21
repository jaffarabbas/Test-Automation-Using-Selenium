Feature: Login

A short summary of the feature

@LoginTaq
Scenario: Open Login page and and login with username and password
   
	Given enter Username:
		  | username | jaffarabbas |
	And Enter Password:
		  | password | jaffarabbas |
	When when username and password entered Click login button
	Then Check welcome message and assert it
