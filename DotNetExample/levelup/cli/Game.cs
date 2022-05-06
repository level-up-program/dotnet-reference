using Sharprompt;
namespace levelup.cli;
class Game
{
    static GameController gameController = new GameController();

    public enum Commands
    {
        Help,
        CreateCharacter,
        StartGame,
        Exit
    }

    public enum inGameCommands
    {
        Help,
        North,
        South,
        East,
        West,
        Exit
    }
    static void Main(string[] args)
    {
        Boolean gameStarted = false;
        while (!gameStarted)
        {
            var type = Prompt.Select<Commands>("Choose game command:");

            switch (type)
            {
                case Commands.CreateCharacter:
                    CreateCharacter();
                    break;
                case Commands.Exit:
                    EndGame();
                    break;
                case Commands.StartGame:
                    //TODO: Call startGame in gamecontroller
                    gameStarted = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }  
        }

        while (true)
        {
            var type = Prompt.Select<inGameCommands>("Choose game command:");

            switch (type)
            {
                case inGameCommands.Exit:
                    EndGame();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }  
        }
    }

    static void EndGame()
    {
        var answer = Prompt.Confirm("Do you want to exit?");
        if (answer == true) {
            //TODO: PRINT FINAL SUMMARY
            Console.WriteLine("You exit the mysterious world.");
            Environment.Exit(0);
        }
    }

    static void CreateCharacter() {
        var playerName = Prompt.Input<string>("What is your character's name?");
        gameController.createCharacter(playerName);
        var gameStatusPlayerName = gameController.getStatus().playerName;
        Console.WriteLine($"Your player, {gameStatusPlayerName}, has been created.");   
    }
}