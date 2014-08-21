using Hanafuda.OpenApi.Entities;
using Hanafuda.OpenApi.Enums;
using NUnit.Framework;

namespace Hanafuda.OpenApi.Test.Entities
{
    [TestFixture]
    public class EntityCardTest
    {
        [Test]
        public void TestEquals()
        {
            var current = new Card(1, FamilyEnum.Normal, MonthEnum.Ayame);
            var otherObj = new object();
            var otherCard = new Card(1, FamilyEnum.Normal, MonthEnum.Sakura);
            var equalCard = new Card(1, FamilyEnum.Normal, MonthEnum.Ayame);
            var thisCard = current;

            Assert.IsTrue(current.Equals(equalCard));
            Assert.IsTrue(current.Equals(thisCard));
            //Assert.IsFalse(current.Equals(null));
            Assert.IsFalse(current.Equals(otherObj));
            Assert.IsFalse(current.Equals(otherCard));
        }
    }
}
