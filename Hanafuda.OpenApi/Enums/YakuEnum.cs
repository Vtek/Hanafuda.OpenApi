using Hanafuda.OpenApi.Attributes;

namespace Hanafuda.OpenApi.Enums
{
    /// <summary>
    /// Yaku
    /// </summary>
    public enum YakuEnum
    {
        /// <summary>
        /// 3 cards(20) no rainman
        /// </summary>
        [Kanji("Sankō", "三光")]
        [Score(5)]
        Sanko,

        /// <summary>
        /// 4 cards(20) no rainman
        /// </summary>
        [Kanji("Shikō", "四光")]
        [Score(8)]
        Shiko,

        /// <summary>
        /// 3 cards(20) and rainman
        /// </summary>
        [Kanji("Ame-Shikō", "雨四光")]
        [Score(7)]
        AmeShiko,

        /// <summary>
        /// 5 cards(20)
        /// </summary>
        [Kanji("Gokō", "五光")]
        [Score(10)]
        Goko,

        /// <summary>
        /// Boar, Deer, Butterflies
        /// </summary>
        [Kanji("Inoshikachō", "猪鹿蝶")]
        [Score(5)]
        Inoshikacho,

        /// <summary>
        /// 5 cards(10)
        /// </summary>
        [Kanji("Tane", "タネ")]
        [Score(1)]
        Tane,

        /// <summary>
        /// 3 poem ribbon
        /// </summary>
        [Kanji("Akatan", "赤タン")]
        [Score(5)]
        Akatan,

        /// <summary>
        /// 3 blue poem
        /// </summary>
        [Kanji("Aotan", "青タン")]
        [Score(5)]
        Aotan,

        /// <summary>
        /// 3 poem ribbon + 3 blue ribbon
        /// </summary>
        [Kanji("Akatan, Aotan no Chōfuku", "赤短・青短の重複")]
        [Score(10)]
        AkatanAotanNoChofuku,

        /// <summary>
        /// 5 cards(5)
        /// </summary>
        [Kanji("Tan", "タン")]
        [Score(1)]
        Tan,

        /// <summary>
        /// Moon, sake cup
        /// </summary>
        [Kanji("Tsukimi-zake", "月見酒")]
        [Score(5)]
        TsukimiZake,

        /// <summary>
        /// Curtain, sake cup
        /// </summary>
        [Kanji("Hanami-zake", "花見酒")]
        [Score(5)]
        HanamiZake,

        /// <summary>
        /// 10 cards(1)
        /// </summary>
        [Kanji("Kasu", "カス")]
        [Score(1)]
        Kasu,

        /// <summary>
        /// 9 cards(1), sake_cup
        /// </summary>
        [Kanji("Bake-fuda", "化け札")]
        [Score(1)]
        BakeFuda,

        /// <summary>
        /// 4 current month cards in pile
        /// </summary>
        [Kanji("Tsuki-fuda", "月札")]
        [Score(4)]
        TsukiFuda,

        /// <summary>
        /// 4 current month cards in hands or board on turn begin
        /// </summary>
        [Kanji("Teshi", "手四")]
        [Score(6)]
        Teshi,

        /// <summary>
        /// 4 month pair
        /// </summary>
        [Kanji("Kuttsuki", "くっつき")]
        [Score(6)]
        Kuttsuki,

        /// <summary>
        /// No card on draw, Oya win
        /// </summary>
        [Kanji("Oya-ken", "親権")]
        [Score(6)]
        OyaKen
    }
}
