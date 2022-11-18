

namespace levelup
{
    public class GameController
    {
        public readonly string DEFAULT_CHARACTER_NAME = "Erin";
        public Character? character { get; set; }
        public GameMap? gameMap { get; set; }

        public record struct GameStatus(
            // TODO: Add other status data
            String characterName,
            Position currentPosition
        );

        // TODO: Ensure this AND CLI commands match domain model
        public enum DIRECTION
        {
            NORTH, SOUTH, EAST, WEST
        }

        GameStatus status = new GameStatus();

        public GameController()
        {
            status.characterName = DEFAULT_CHARACTER_NAME;
            //Set current position to a nonsense place until you figure out who should initialize
            status.currentPosition = new Position(-1,-1);
        }

        public void CreateCharacter(String name)
        {
            if (name != null && !name.Equals(""))
            {
                this.character = new Character(name);   
            }
            else
            {
                this.character = new Character(DEFAULT_CHARACTER_NAME);
            }
            this.status.characterName = character.Name;
        }

        public void StartGame()
        {
            // TODO: Implement startGame - Should probably create tiles and put the character
            // on them?
            // TODO: Should also update the game status?
            gameMap = new GameMap();
        }

        public GameStatus GetStatus()
        {
            return this.status;
        }

        public void Move(DIRECTION directionToMove)
        {
            //TODO: Implement move - should call something on another class
            //TODO: Should probably also update the game status
        }

        public void SetCharacterPosition(int x, int y)
        {
            //TODO: IMPLEMENT THIS TO SET CHARACTERS CURRENT POSITION -- exists to be testable
        }


    }
}