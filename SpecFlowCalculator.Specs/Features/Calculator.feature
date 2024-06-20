Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator]($projectname$/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120
	
@mytag
Scenario: Subtract two numbers
	Given the first number is 40
	And the second number is 10
	When the two numbers are subtracted
	Then the result should be 30
	
@mytag
Scenario: Multiply two numbers
	Given the first number is 5
	And the second number is 4
	When the two numbers are multiplied
	Then the result should be 20
	
@mytag
Scenario: Divide two numbers
	Given the first number is 40
	And the second number is 10
	When the two numbers are divided
	Then the result should be 4

@mytag
Scenario: Add two numbers with the alternative way
	Given the first number is 50
	And the second number is 70
	When the two numbers are added the alternative way
	Then the result should be 120

@mytag
Scenario: Subtract two numbers with the alternative way
	Given the first number is 40
	And the second number is 10
	When the two numbers are subtracted the alternative way
	Then the result should be 30

@mytag
Scenario: Multiply two numbers with the alternative way
	Given the first number is 5
	And the second number is 4
	When the two numbers are multiplied the alternative way
	Then the result should be 20

@mytag
Scenario: Divide two numbers with the alternative way
	Given the first number is 40
	And the second number is 10
	When the two numbers are divided the alternative way
	Then the result should be 4