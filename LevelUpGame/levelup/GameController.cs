

namespace levelup
{
    public class GameController
    {
        // TODO: If your stakeholder wants to call this CHARACTER, change var name for
        // low representational gap
        public readonly string DEFAULT_CHARACTER_NAME = "Erin";

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

        // Pre-implemented to demonstrate ATDD
        // TODO: Update this if it does not match your design
        public void CreateCharacter(String name)
        {
            if (name != null && !name.Equals(""))
            {
                this.status.characterName = name;
            }
            else
            {
                this.status.characterName = DEFAULT_CHARACTER_NAME;
            }
        }

        public void StartGame()
        {
            // TODO: Implement startGame - Should probably create tiles and put the character
            // on them?
            // TODO: Should also update the game status?
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