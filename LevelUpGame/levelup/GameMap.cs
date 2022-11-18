
namespace levelup
{
    public class GameMap
    {
        public Position[,]? positions;
        public Position? startingPosition;

        public GameMap()
        {
            CreatePositions();
        }

        private void CreatePositions()
        {
           positions = new Position[10,10];
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Position pos = new Position(x, y);
                    positions[x,y] = pos;
                }
            }
            startingPosition = positions[0,0];
        }

        public Position CalculateNewPosition(Position currentPosition, GameController.DIRECTION direction)
        {
            if(direction == GameController.DIRECTION.EAST)
            {
                return new Position(currentPosition.x + 1, currentPosition.y);
            }
            return null;
        }



    }
}