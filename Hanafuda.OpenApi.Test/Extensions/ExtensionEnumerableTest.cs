using Hanafuda.OpenApi.Enums;
using Hanafuda.OpenApi.Extensions;
using Hanafuda.OpenApi.Test.Extensions.Data;
using NUnit.Framework;
using System.Linq;

namespace Hanafuda.OpenApi.Test.Extensions
{
    [TestFixture]
    public class ExtensionEnumerableTest
    {
        [Test]
        public void TestHasTeshi()
        {
            var list = Yakus.GetHasTeshi();
            var actual = list.HasTeshi(MonthEnum.Ayame);
            var actualNot = list.HasTeshi(MonthEnum.Botan);
            Assert.IsTrue(actual);
            Assert.IsFalse(actualNot);
        }
       
        [Test]
        public void TestHasKuttsuki()
        {
            var list = Yakus.GetHasKuttsuki();
            var listNot = Yakus.GetNotHasKuttsuki();
            var actual = list.HasKuttsuki();
            var actualNot = listNot.HasKuttsuki();
            Assert.IsTrue(actual);
            Assert.IsFalse(actualNot);
        }

        [Test]
        public void TestHasSanko()
        {
            var list = Yakus.GetHasSanko();
            var listNot = Yakus.GetNotHasSanko();
            var actual = list.GetYakus(MonthEnum.Ayame);
            var actualNot = listNot.GetYakus(MonthEnum.Ayame);

            Assert.IsTrue(actual.Count() == 1);
            Assert.IsTrue(actual.Any(x => x == YakuEnum.Sanko));

            Assert.IsTrue(!actualNot.Any());
        }

        [Test]
        public void TestHasShiko()
        {
            var list = Yakus.GetHasShiko();
            var listNot = Yakus.GetNotHasShiko();
            var actual = list.GetYakus(MonthEnum.Ayame);
            var actualNot = listNot.GetYakus(MonthEnum.Ayame);

            Assert.IsTrue(actual.Count() == 1);
            Assert.IsTrue(actual.Any(x => x == YakuEnum.Shiko));

            Assert.IsTrue(actualNot.All(x => x != YakuEnum.Shiko));
        }

        [Test]
        public void TestHasAmeShiko()
        {
            var list = Yakus.GetHasAmeShiko();
            var listNot = Yakus.GetNotHasAmeShiko();
            var actual = list.GetYakus(MonthEnum.Ayame);
            var actualNot = listNot.GetYakus(MonthEnum.Ayame);

            Assert.IsTrue(actual.Count() == 1);
            Assert.IsTrue(actual.Any(x => x == YakuEnum.AmeShiko));

            Assert.IsTrue(actualNot.All(x => x != YakuEnum.AmeShiko));
        }

        [Test]
        public void TestHasGoko()
        {
            var list = Yakus.GetHasGoko();
            var actual = list.GetYakus(MonthEnum.Ayame);

            Assert.IsTrue(actual.Count() == 1);
            Assert.IsTrue(actual.Any(x => x == YakuEnum.Goko));
        }

        [Test]
        public void TestHasInoShikaCho()
        {
            var list = Yakus.GetHasInoShikaCho();
            var actual = list.GetYakus(MonthEnum.Ayame);

            Assert.IsTrue(actual.Count() == 1);
            Assert.IsTrue(actual.Any(x => x == YakuEnum.Inoshikacho));
        }

        [Test]
        public void TestHasTane()
        {
            var list = Yakus.GetHasTane();
            var actual = list.GetYakus(MonthEnum.Ayame);

            Assert.IsTrue(actual.Count() == 1);
            Assert.IsTrue(actual.Any(x => x == YakuEnum.Tane));
        }

        [Test]
        public void TestHasAkatan()
        {
            var list = Yakus.GetHasAkatan();
            var actual = list.GetYakus(MonthEnum.Ayame);

            Assert.IsTrue(actual.Count() == 1);
            Assert.IsTrue(actual.Any(x => x == YakuEnum.Akatan));
        }

        [Test]
        public void TestHasAotan()
        {
            var list = Yakus.GetHasAotan();
            var actual = list.GetYakus(MonthEnum.Ayame);

            Assert.IsTrue(actual.Count() == 1);
            Assert.IsTrue(actual.Any(x => x == YakuEnum.Aotan));
        }

        [Test]
        public void TestHasAkatanAotan()
        {
            var list = Yakus.GetHasAkatanAotan();
            var actual = list.GetYakus(MonthEnum.Ayame);

            Assert.IsTrue(actual.Count() == 4);
            Assert.IsTrue(actual.Any(x => x == YakuEnum.AkatanAotanNoChofuku || x == YakuEnum.Akatan || x == YakuEnum.Aotan || x == YakuEnum.Tan));
        }

        [Test]
        public void TestHasAkatanTan()
        {
            var list = Yakus.GetHasTan();
            var actual = list.GetYakus(MonthEnum.Ayame);

            Assert.IsTrue(actual.Count() == 1);
            Assert.IsTrue(actual.Any(x => x == YakuEnum.Tan));
        }

        [Test]
        public void TestHasTsukimiZake()
        {
            var list = Yakus.GetHasTsukimiZake();
            var actual = list.GetYakus(MonthEnum.Ayame);

            Assert.IsTrue(actual.Count() == 1);
            Assert.IsTrue(actual.Any(x => x == YakuEnum.TsukimiZake));
        }

        [Test]
        public void TestHasHanamiZake()
        {
            var list = Yakus.GetHasHanamiZake();
            var actual = list.GetYakus(MonthEnum.Ayame);

            Assert.IsTrue(actual.Count() == 1);
            Assert.IsTrue(actual.Any(x => x == YakuEnum.HanamiZake));
        }

        [Test]
        public void TestHasKasu()
        {
            var list = Yakus.GetHasKasu();
            var actual = list.GetYakus(MonthEnum.Ayame);

            Assert.IsTrue(actual.Count() == 1);
            Assert.IsTrue(actual.Any(x => x == YakuEnum.Kasu));
        }

        [Test]
        public void TestHasBakeFuda()
        {
            var list = Yakus.GetHasBakeFuda();
            var actual = list.GetYakus(MonthEnum.Ayame);

            Assert.IsTrue(actual.Count() == 1);
            Assert.IsTrue(actual.Any(x => x == YakuEnum.BakeFuda));
        }

        [Test]
        public void TestHasTsukiFuda()
        {
            var list = Yakus.GetHasTsukiFuda();
            var actual = list.GetYakus(MonthEnum.Matsu);

            Assert.IsTrue(actual.Count() == 1);
            Assert.IsTrue(actual.Any(x => x == YakuEnum.TsukiFuda));
        }
    }
}
