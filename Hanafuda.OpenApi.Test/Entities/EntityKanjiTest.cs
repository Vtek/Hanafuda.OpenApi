using Hanafuda.OpenApi.Entities;
using NUnit.Framework;

namespace Hanafuda.OpenApi.Test.Entities
{
    [TestFixture]
    public class EntityKanjiTest
    {
        [Test]
        public void TestEquals()
        {
            var current = new Kanji("Test", "Test");
            var otherObj = new object();
            var otherKanji = new Kanji("Test1", "Test");
            var equalKanji = new Kanji("Test", "Test");
            var thisKanji = current;

            Assert.IsTrue(current.Equals(equalKanji));
            Assert.IsTrue(current.Equals(thisKanji));
            Assert.IsFalse(current.Equals(null));
            Assert.IsFalse(current.Equals(otherObj));
            Assert.IsFalse(current.Equals(otherKanji));
        }
    }
}
