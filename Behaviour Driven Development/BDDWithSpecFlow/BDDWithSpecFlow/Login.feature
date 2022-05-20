Feature: Login

A short summary of the feature

@LoginTaq
Scenario: Open Login page and and login with username and password
	Given Enter Username "jaffarabbas"
	And Enter Passowrd "jaffarabbas"
	When When username and password entered Click login button
	Then check welcome message and assert it
