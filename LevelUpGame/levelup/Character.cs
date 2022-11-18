
namespace levelup
{
    public class Character
    {
        public string? Name { get; set; }
        public Position? Position { get; set; }
        public GameMap? gameMap { get; set; }

        public Character(String name)
        {
            this.Name = name;
        }

        public void EnterMap(GameMap map)
        {
            this.gameMap = map;
            this.Position = map.startingPosition;
        }

        public void Move(GameController.DIRECTION direction)
        {
            this.Position = gameMap.CalculateNewPosition(this.Position, direction);
        }

    }
}