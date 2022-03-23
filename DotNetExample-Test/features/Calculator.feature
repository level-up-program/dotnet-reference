Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
    In order to avoid silly mistakes
    As a math novice
    I *want* to be told the **sum** of **two** numbers

@mytag 
Scenario: Add two numbers
    Given the first number is 50
    And the second number is 70
    When the two numbers are added
    Then the result should be 120