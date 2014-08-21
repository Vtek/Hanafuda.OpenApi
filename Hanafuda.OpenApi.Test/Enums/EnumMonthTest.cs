using Hanafuda.OpenApi.Entities;
using Hanafuda.OpenApi.Enums;
using Hanafuda.OpenApi.Extensions;
using NUnit.Framework;

namespace Hanafuda.OpenApi.Test.Enums
{
    [TestFixture]
    public class EnumMonthTest
    {
        [Test]
        public void TestKanjiAyame()
        {
            var expected = new Kanji("Ayame", "菖蒲");
            var actual = MonthEnum.Ayame.GetKanji();
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TestKanjiBotan()
        {
            var expected = new Kanji("Botan", "牡丹");
            var actual = MonthEnum.Botan.GetKanji();
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TestKanjiFuji()
        {
            var expected = new Kanji("Fuji", "藤");
            var actual = MonthEnum.Fuji.GetKanji();
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TestKanjiHagi()
        {
            var expected = new Kanji("Hagi", "萩");
            var actual = MonthEnum.Hagi.GetKanji();
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TestKanjiKiku()
        {
            var expected = new Kanji("Kiku", "菊");
            var actual = MonthEnum.Kiku.GetKanji();
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TestKanjiKiri()
        {
            var expected = new Kanji("Kiri", "桐");
            var actual = MonthEnum.Kiri.GetKanji();
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TestKanjiMatsu()
        {
            var expected = new Kanji("Matsu", "松");
            var actual = MonthEnum.Matsu.GetKanji();
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TestKanjiMomiji()
        {
            var expected = new Kanji("Momiji", "紅葉");
            var actual = MonthEnum.Momiji.GetKanji();
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TestKanjiSakura()
        {
            var expected = new Kanji("Sakura", "桜");
            var actual = MonthEnum.Sakura.GetKanji();
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TestKanjiSusuki()
        {
            var expected = new Kanji("Susuki", "薄");
            var actual = MonthEnum.Susuki.GetKanji();
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TestKanjiUme()
        {
            var expected = new Kanji("Ume", "梅");
            var actual = MonthEnum.Ume.GetKanji();
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TestKanjiYanagie()
        {
            var expected = new Kanji("Yanagie", "柳");
            var actual = MonthEnum.Yanagie.GetKanji();
            Assert.AreEqual(actual, expected);
        }
    }
}
