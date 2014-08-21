using Hanafuda.OpenApi.Attributes;
using System;

namespace Hanafuda.OpenApi.Enums
{
    /// <summary>
    /// Months
    /// </summary>
    [Flags]
    public enum MonthEnum
    {
        [Kanji("Matsu", "松")]
        Matsu = 0,

        [Kanji("Ume", "梅")]
        Ume = 1,

        [Kanji("Sakura", "桜")]
        Sakura = 2,

        [Kanji("Fuji", "藤")]
        Fuji = 4,

        [Kanji("Ayame", "菖蒲")]
        Ayame = 8,

        [Kanji("Botan", "牡丹")]
        Botan = 16,

        [Kanji("Hagi", "萩")]
        Hagi = 32,

        [Kanji("Susuki", "薄")]
        Susuki = 64,

        [Kanji("Kiku", "菊")]
        Kiku = 128,

        [Kanji("Momiji", "紅葉")]
        Momiji = 254,

        [Kanji("Yanagie", "柳")]
        Yanagie = 512,

        [Kanji("Kiri", "桐")]
        Kiri = 1024
    }
}

