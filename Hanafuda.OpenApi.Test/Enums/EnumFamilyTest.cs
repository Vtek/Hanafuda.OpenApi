using Hanafuda.OpenApi.Enums;
using Hanafuda.OpenApi.Extensions;
using NUnit.Framework;

namespace Hanafuda.OpenApi.Test.Enums
{
    [TestFixture]
    public class EnumFamilyTest
    {
        [Test]
        public void TestScoreAnimal()
        {
            const int expected = 10;
            var actual = FamilyEnum.Animal.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreNormal()
        {
            const int expected = 1;
            var actual = FamilyEnum.Normal.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreRibbon()
        {
            const int expected = 5;
            var actual = FamilyEnum.Ribbon.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreSpecial()
        {
            const int expected = 20;
            var actual = FamilyEnum.Special.GetScore();
            Assert.AreEqual(expected, actual);
        }
    }
}
