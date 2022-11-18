using levelup;
using NUnit.Framework;

namespace levelup
{
    [TestFixture]
    public class GameMapTest
    {
        private GameMap? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameMap();
        }

        [Test]
        public void TestMapCreatesPositionsWhenInitialized()
        {
            Assert.NotNull(testObj.positions);
            Assert.AreEqual(100, testObj.positions.Length);
            Position samplePosition = testObj.positions[4,3];
            Assert.AreEqual(4, samplePosition.x);
            Assert.AreEqual(3, samplePosition.y);
            Assert.NotNull(testObj.startingPosition);
        }

        [Test]
        public void TestCalcPositionInCenterOfBoard()
        {
            Position startPos = testObj.positions[3,4];
            Position newPos = testObj.CalculateNewPosition(startPos, GameController.DIRECTION.EAST);
            Assert.AreEqual(4, newPos.x);
            Assert.AreEqual(4, newPos.y);
        }

       
    }
}