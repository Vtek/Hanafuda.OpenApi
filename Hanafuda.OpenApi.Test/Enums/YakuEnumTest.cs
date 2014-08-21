using Hanafuda.OpenApi.Entities;
using Hanafuda.OpenApi.Enums;
using Hanafuda.OpenApi.Extensions;
using NUnit.Framework;

namespace Hanafuda.OpenApi.Test.Enums
{
    [TestFixture]
    public class YakuEnumTest
    {
        [Test]
        public void TestKanjiAkatan()
        {
            var expected = new Kanji("Akatan", "赤タン");
            var actual = YakuEnum.Akatan.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreAkatan()
        {
            const byte expected = 5;
            var actual = YakuEnum.Akatan.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiAkatanAotanNoChofuku()
        {
            var expected = new Kanji("Akatan, Aotan no Chōfuku", "赤短・青短の重複");
            var actual = YakuEnum.AkatanAotanNoChofuku.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreAkatanAotanNoChofuku()
        {
            const byte expected = 10;
            var actual = YakuEnum.AkatanAotanNoChofuku.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiAmeShiko()
        {
            var expected = new Kanji("Ame-Shikō", "雨四光");
            var actual = YakuEnum.AmeShiko.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreAmeShiko()
        {
            const byte expected = 7;
            var actual = YakuEnum.AmeShiko.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiAotan()
        {
            var expected = new Kanji("Aotan", "青タン");
            var actual = YakuEnum.Aotan.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreAotan()
        {
            const byte expected = 5;
            var actual = YakuEnum.Aotan.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiBakeFuda()
        {
            var expected = new Kanji("Bake-fuda", "化け札");
            var actual = YakuEnum.BakeFuda.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreBakeFuda()
        {
            const byte expected = 1;
            var actual = YakuEnum.BakeFuda.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiGoko()
        {
            var expected = new Kanji("Gokō", "五光");
            var actual = YakuEnum.Goko.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreGoko()
        {
            const byte expected = 10;
            var actual = YakuEnum.Goko.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiHanamiZake()
        {
            var expected = new Kanji("Hanami-zake", "花見酒");
            var actual = YakuEnum.HanamiZake.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreHanamiZake()
        {
            const byte expected = 5;
            var actual = YakuEnum.HanamiZake.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiInoshikacho()
        {
            var expected = new Kanji("Inoshikachō", "猪鹿蝶");
            var actual = YakuEnum.Inoshikacho.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreInoshikacho()
        {
            const byte expected = 5;
            var actual = YakuEnum.Inoshikacho.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiKasu()
        {
            var expected = new Kanji("Kasu", "カス");
            var actual = YakuEnum.Kasu.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreKasu()
        {
            const byte expected = 1;
            var actual = YakuEnum.Kasu.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiKuttsuki()
        {
            var expected = new Kanji("Kuttsuki", "くっつき");
            var actual = YakuEnum.Kuttsuki.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreKuttsuki()
        {
            const byte expected = 6;
            var actual = YakuEnum.Kuttsuki.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiOyaKen()
        {
            var expected = new Kanji("Oya-ken", "親権");
            var actual = YakuEnum.OyaKen.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreOyaKen()
        {
            const byte expected = 6;
            var actual = YakuEnum.OyaKen.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiSanko()
        {
            var expected = new Kanji("Sankō", "三光");
            var actual = YakuEnum.Sanko.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreSanko()
        {
            const byte expected = 5;
            var actual = YakuEnum.Sanko.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiShiko()
        {
            var expected = new Kanji("Shikō", "四光");
            var actual = YakuEnum.Shiko.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreShiko()
        {
            const byte expected = 8;
            var actual = YakuEnum.Shiko.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiTan()
        {
            var expected = new Kanji("Tan", "タン");
            var actual = YakuEnum.Tan.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreTan()
        {
            const byte expected = 1;
            var actual = YakuEnum.Tan.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiTane()
        {
            var expected = new Kanji("Tane", "タネ");
            var actual = YakuEnum.Tane.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreTane()
        {
            const byte expected = 1;
            var actual = YakuEnum.Tane.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiTeshi()
        {
            var expected = new Kanji("Teshi", "手四");
            var actual = YakuEnum.Teshi.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreTeshi()
        {
            const byte expected = 6;
            var actual = YakuEnum.Teshi.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiTsukiFuda()
        {
            var expected = new Kanji("Tsuki-fuda", "月札");
            var actual = YakuEnum.TsukiFuda.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreTsukiFuda()
        {
            const byte expected = 4;
            var actual = YakuEnum.TsukiFuda.GetScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestKanjiTsukimiZake()
        {
            var expected = new Kanji("Tsukimi-zake", "月見酒");
            var actual = YakuEnum.TsukimiZake.GetKanji();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestScoreTsukimiZake()
        {
            const byte expected = 5;
            var actual = YakuEnum.TsukimiZake.GetScore();
            Assert.AreEqual(expected, actual);
        }
    }
}
