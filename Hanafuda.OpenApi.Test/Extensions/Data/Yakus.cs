using Hanafuda.OpenApi.Entities;
using Hanafuda.OpenApi.Enums;
using System.Collections.Generic;
using NUnit.Framework;

namespace Hanafuda.OpenApi.Test.Extensions.Data
{
    public static class Yakus
    {
        public static IEnumerable<Card> GetHasTeshi()
        {
            return new List<Card>
            {
                new Card(1, FamilyEnum.Animal, MonthEnum.Ayame),
                new Card(2, FamilyEnum.Normal, MonthEnum.Ayame),
                new Card(3, FamilyEnum.Ribbon, MonthEnum.Ayame),
                new Card(4, FamilyEnum.Special, MonthEnum.Ayame)
            };
        }

        public static IEnumerable<Card> GetHasKuttsuki()
        {
            return new List<Card>
            {
                new Card(1, FamilyEnum.Animal, MonthEnum.Ayame),
                new Card(2, FamilyEnum.Normal, MonthEnum.Ayame),
                new Card(3, FamilyEnum.Ribbon, MonthEnum.Botan),
                new Card(4, FamilyEnum.Special, MonthEnum.Botan),
                new Card(5, FamilyEnum.Ribbon, MonthEnum.Fuji),
                new Card(6, FamilyEnum.Special, MonthEnum.Fuji),
                new Card(7, FamilyEnum.Ribbon, MonthEnum.Hagi),
                new Card(8, FamilyEnum.Special, MonthEnum.Hagi)
            };
        }

        public static IEnumerable<Card> GetNotHasKuttsuki()
        {
            return new List<Card>
            {
                new Card(1, FamilyEnum.Animal, MonthEnum.Ayame),
                new Card(2, FamilyEnum.Normal, MonthEnum.Ayame),
                new Card(3, FamilyEnum.Ribbon, MonthEnum.Botan),
                new Card(4, FamilyEnum.Special, MonthEnum.Botan),
                new Card(5, FamilyEnum.Ribbon, MonthEnum.Fuji),
                new Card(6, FamilyEnum.Special, MonthEnum.Fuji),
                new Card(7, FamilyEnum.Ribbon, MonthEnum.Hagi),
                new Card(8, FamilyEnum.Special, MonthEnum.Kiku)
            };
        }

        public static IEnumerable<Card> GetHasSanko()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Matsu, SpecialEnum.Crane),
                new Card(2, MonthEnum.Sakura, SpecialEnum.Curtain),
                new Card(3, MonthEnum.Susuki, SpecialEnum.Moon)
            };
        }

        public static IEnumerable<Card> GetNotHasSanko()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Matsu, SpecialEnum.Crane),
                new Card(2, MonthEnum.Yanagie, SpecialEnum.Rainman),
                new Card(3, MonthEnum.Kiri, SpecialEnum.Phenix)
            };
        }

        public static IEnumerable<Card> GetHasShiko()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Matsu, SpecialEnum.Crane),
                new Card(2, MonthEnum.Sakura, SpecialEnum.Curtain),
                new Card(3, MonthEnum.Susuki, SpecialEnum.Moon),
                new Card(4, MonthEnum.Kiri, SpecialEnum.Phenix)
            };
        }

        public static IEnumerable<Card> GetNotHasShiko()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Matsu, SpecialEnum.Crane),
                new Card(2, MonthEnum.Susuki, SpecialEnum.Moon),
                new Card(3, MonthEnum.Yanagie, SpecialEnum.Rainman),
                new Card(4, MonthEnum.Kiri, SpecialEnum.Phenix)
            };
        }

        public static IEnumerable<Card> GetHasAmeShiko()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Matsu, SpecialEnum.Crane),
                new Card(2, MonthEnum.Sakura, SpecialEnum.Curtain),
                new Card(3, MonthEnum.Yanagie, SpecialEnum.Rainman),
                new Card(4, MonthEnum.Kiri, SpecialEnum.Phenix)
            };
        }

        public static IEnumerable<Card> GetNotHasAmeShiko()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Matsu, SpecialEnum.Crane),
                new Card(2, MonthEnum.Susuki, SpecialEnum.Moon),
                new Card(3, MonthEnum.Sakura, SpecialEnum.Curtain),
                new Card(4, MonthEnum.Kiri, SpecialEnum.Phenix)
            };
        }

        public static IEnumerable<Card> GetHasGoko()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Matsu, SpecialEnum.Crane),
                new Card(2, MonthEnum.Sakura, SpecialEnum.Curtain),
                new Card(3, MonthEnum.Susuki, SpecialEnum.Moon),
                new Card(4, MonthEnum.Yanagie, SpecialEnum.Rainman),
                new Card(5, MonthEnum.Kiri, SpecialEnum.Phenix)
            };
        }

        public static IEnumerable<Card> GetHasInoShikaCho()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Momiji, AnimalEnum.Deer),
                new Card(2, MonthEnum.Hagi, AnimalEnum.Boar),
                new Card(3, MonthEnum.Botan, AnimalEnum.Butterflies),
            };
        }

        public static IEnumerable<Card> GetHasTane()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Ume, AnimalEnum.BushWarbler),
                new Card(2, MonthEnum.Fuji, AnimalEnum.Cuckoo),
                new Card(3, MonthEnum.Ayame, AnimalEnum.Iris),
                new Card(4, MonthEnum.Botan, AnimalEnum.Butterflies),
                new Card(5, MonthEnum.Hagi, AnimalEnum.Boar)
            };
        }

        public static IEnumerable<Card> GetHasAkatan()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Ume, RibbonEnum.Poem),
                new Card(2, MonthEnum.Sakura, RibbonEnum.Poem),
                new Card(3, MonthEnum.Matsu, RibbonEnum.Poem)
            };
        }

        public static IEnumerable<Card> GetHasAotan()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Botan, RibbonEnum.Blue),
                new Card(2, MonthEnum.Kiku, RibbonEnum.Blue),
                new Card(3, MonthEnum.Momiji, RibbonEnum.Blue)
            };
        }

        public static IEnumerable<Card> GetHasAkatanAotan()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Ume, RibbonEnum.Poem),
                new Card(2, MonthEnum.Sakura, RibbonEnum.Poem),
                new Card(3, MonthEnum.Matsu, RibbonEnum.Poem),
                new Card(4, MonthEnum.Botan, RibbonEnum.Blue),
                new Card(5, MonthEnum.Kiku, RibbonEnum.Blue),
                new Card(6, MonthEnum.Momiji, RibbonEnum.Blue)
            };
        }

        public static IEnumerable<Card> GetHasTan()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Ume, RibbonEnum.Poem),
                new Card(2, MonthEnum.Sakura, RibbonEnum.Poem),
                new Card(4, MonthEnum.Botan, RibbonEnum.Blue),
                new Card(5, MonthEnum.Kiku, RibbonEnum.Blue),
                new Card(6, MonthEnum.Hagi, RibbonEnum.Red)
            };
        }

        public static IEnumerable<Card> GetHasTsukimiZake()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Kiku, AnimalEnum.SakeCup),
                new Card(2, MonthEnum.Susuki, SpecialEnum.Moon)
            };
        }

        public static IEnumerable<Card> GetHasHanamiZake()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Kiku, AnimalEnum.SakeCup),
                new Card(2, MonthEnum.Sakura, SpecialEnum.Curtain)
            };
        }

        public static IEnumerable<Card> GetHasKasu()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Matsu),
                new Card(2, MonthEnum.Matsu),
                new Card(3, MonthEnum.Ume),
                new Card(4, MonthEnum.Ume),
                new Card(5, MonthEnum.Sakura),
                new Card(6, MonthEnum.Sakura),
                new Card(7, MonthEnum.Fuji),
                new Card(8, MonthEnum.Fuji),
                new Card(9, MonthEnum.Ayame),
                new Card(10, MonthEnum.Ayame)
            };
        }

        public static IEnumerable<Card> GetHasBakeFuda()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Matsu),
                new Card(2, MonthEnum.Matsu),
                new Card(3, MonthEnum.Ume),
                new Card(4, MonthEnum.Ume),
                new Card(5, MonthEnum.Sakura),
                new Card(6, MonthEnum.Sakura),
                new Card(7, MonthEnum.Fuji),
                new Card(8, MonthEnum.Fuji),
                new Card(9, MonthEnum.Ayame),
                new Card(10, MonthEnum.Kiku, AnimalEnum.SakeCup)
            };
        }

        public static IEnumerable<Card> GetHasTsukiFuda()
        {
            return new List<Card>
            {
                new Card(1, MonthEnum.Matsu),
                new Card(2, MonthEnum.Matsu),
                new Card(3, MonthEnum.Matsu, RibbonEnum.Poem),
                new Card(4, MonthEnum.Matsu, SpecialEnum.Crane)
            };
        }
    }
}
