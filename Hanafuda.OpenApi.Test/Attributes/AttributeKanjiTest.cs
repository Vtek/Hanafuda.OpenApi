using Hanafuda.OpenApi.Attributes;
using Hanafuda.OpenApi.Entities;
using NUnit.Framework;

namespace Hanafuda.OpenApi.Test.Attributes
{
    [TestFixture]
    public class AttributeKanjiTest
    {
        [Test]
        public void TestCtr()
        {
            var expected = new Kanji("Name", "Symbol");
            var actual = new KanjiAttribute("Name", "Symbol").Kanji;
            Assert.AreEqual(expected, actual);
        }
    }
}
