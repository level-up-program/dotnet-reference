Feature: Game
![Gamer](./gamerErin.png)
    I want to create a new custom character, setting their name

@acceptance 
Scenario Outline: Set player name
    Character creation is currently split to be very simple: the only customization is setting the name.

    Given the player's name is "<playerNameInput>"
    When the player sets their name
    Then the Game sets the player's name to "<playerNameOutput>"
    Examples:

        | playerNameInput | playerNameOutput |  
        | Erin            | Erin             |
        |                 | Player           |