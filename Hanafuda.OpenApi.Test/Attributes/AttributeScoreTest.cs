using Hanafuda.OpenApi.Attributes;
using NUnit.Framework;

namespace Hanafuda.OpenApi.Test.Attributes
{
    [TestFixture]
    public class AttributeScoreTest
    {
        [Test]
        public void TestCtr()
        {
            const byte expected = 1;
            var actual = new ScoreAttribute(1).Score;
            Assert.AreEqual(expected, actual);
        }
    }
}
