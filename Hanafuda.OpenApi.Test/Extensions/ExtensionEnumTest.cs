using Hanafuda.OpenApi.Entities;
using Hanafuda.OpenApi.Extensions;
using Hanafuda.OpenApi.Test.Extensions.Data;
using NUnit.Framework;

namespace Hanafuda.OpenApi.Test.Extensions
{
    [TestFixture]
    public class ExtensionEnumTest
    {
        [Test]
        public void TestGetKanji()
        {
            var expected = new Kanji("Name", "Symbol");
            var actual = TestEnum.WithKanji.GetKanji();
            var actualNull = TestEnum.WithoutKanji.GetKanji();

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
            Assert.IsNull(actualNull);
        }

        [Test]
        public void TestGetScore()
        {
            const byte expected = 1;
            var actual = TestEnum.WithScore.GetScore();
            var actualNull = TestEnum.WithoutKanji.GetScore();

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
            Assert.IsNull(actualNull);
        }
    }
}
