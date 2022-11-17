Feature: Move in a direction
    I want to move my character. If they attempt tomove past a boundary, the move results in no change in position.

@acceptance 
    Scenario Outline: Move in a direction
        Given the character starts at position with XCoordinates <startingPositionX>
            And starts at YCoordinates <startingPositionY>
            And the turn count is <turnCountBefore>
            And the player choses to move in <direction>
        When the character moves
        Then the character is now at position with XCoordinates <endingPositionX>
            And YCoordinates <endingPositionY>
            And the new turn count is <turnCountAfter>
        Examples:
            | startingPositionX | startingPositionY | turnCountBefore | direction | endingPositionX | endingPositionY | turnCountAfter |
            | 0                 | 0                 | 103             | NORTH     | 0               | 1               | 104            |
            | 0                 | 0                 | 32              | SOUTH     | 0               | 0               | 33             |
            | 0                 | 0                 | 27              | WEST      | 0               | 0               | 28             |
            | 5                 | 7                 | 409             | EAST      | 6               | 7               | 408            |
            | 5                 | 3                 | 17              | WEST      | 4               | 3               | 18             |
            | 9                 | 3                 | 10              | WEST      | 8               | 3               | 10             |
            | 9                 | 3                 | 1               | EAST      | 9               | 3               | 2              |
            | 3                 | 9                 | 99              | NORTH     | 3               | 9               | 100            |
            | 3                 | 9                 | 18              | SOUTH     | 3               | 8               | 19             |