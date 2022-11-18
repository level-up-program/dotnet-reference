using levelup;
using NUnit.Framework;

namespace levelup
{
    [TestFixture]
    public class GameControllerTest
    {
        private GameController? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameController();
        }

        [Test]
        public void IsGameResultInitialized()
        {
            #pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsNotNull(testObj.GetStatus());
        }

        [Test]
        public void CreateCharacterInitsChar()
        {
            testObj.CreateCharacter("ARBITRARY NAME");
            Assert.AreEqual("ARBITRARY NAME", testObj.character.Name);
            Assert.AreEqual("ARBITRARY NAME", testObj.GetStatus().characterName);
        }

        [Test]
        public void StartGameCreatesMap()
        {
            testObj.StartGame();
            Assert.NotNull(testObj.gameMap);
        }

        [Test]
        public void StartGameEntersMapAndUpdatesStatus() 
        {
            FakeGameMap fakeMap = new FakeGameMap();
            testObj.gameMap = fakeMap;
            testObj.StartGame();
            Assert.AreEqual(fakeMap.startingPosition.x, testObj.GetStatus().currentPosition.x);
            Assert.AreEqual(fakeMap.startingPosition.y, testObj.GetStatus().currentPosition.y);
        }
    }
}