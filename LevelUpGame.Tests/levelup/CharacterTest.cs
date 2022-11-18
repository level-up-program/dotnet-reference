using levelup;
using NUnit.Framework;

namespace levelup
{
    [TestFixture]
    public class CharacterTest
    {
        private Character? testObj;
        string arbitraryName = "Arbitrary Name";

        [SetUp]
        public void SetUp()
        {
            testObj = new Character(arbitraryName);
        }

        [Test]
        public void CharacterHasNameWhenInitialized()
        {
            Assert.AreEqual(arbitraryName, testObj.Name);
        }

        
    }
}