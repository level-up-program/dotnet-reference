namespace levelup
{
    public class GameController
    {
        public readonly string DEFAULT_PLAYER_NAME = "Player";

        public record struct GameResults(
            String playerName
        //TODO: Add other game result needs
        );

        GameResults status = new GameResults();

        public GameResults getStatus()
        {
            return this.status;
        }

        public void createCharacter(String playerName)
        {
            if (!playerName.Equals(""))
            {
                this.status.playerName = playerName;
            }
            else
            {
                this.status.playerName = DEFAULT_PLAYER_NAME;
            }
        }

    }
}