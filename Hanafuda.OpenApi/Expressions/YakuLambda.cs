using Hanafuda.OpenApi.Entities;
using Hanafuda.OpenApi.Enums;
using System;

namespace Hanafuda.OpenApi.Expressions
{
    /// <summary>
    /// Yaku Lambda
    /// </summary>
    public static class YakuLambda
    {
        /// <summary>
        /// Normal card lambda
        /// </summary>
        public static Func<Card, bool> Normal
        {
            get { return x => x.IsNormal; }
        }

        /// <summary>
        /// Animal card lambda
        /// </summary>
        public static Func<Card, bool> Animal
        {
            get { return x => x.IsAnimal; }
        }

        /// <summary>
        /// Ribbon card lambda
        /// </summary>
        public static Func<Card, bool> Ribbon
        {
            get { return x => x.IsRibbon; }
        }

        /// <summary>
        /// Special card lambda
        /// </summary>
        public static Func<Card, bool> Special
        {
            get { return x => x.IsSpecial; }
        }

        /// <summary>
        /// NoRainMan special card lambda
        /// </summary>
        public static Func<Card, bool> NoRainMan
        {
            get { return x => x.IsSpecial && x.Special != SpecialEnum.Rainman; }
        }

        /// <summary>
        /// RainMan special card lambda
        /// </summary>
        public static Func<Card, bool> RainMan
        {
            get { return x => x.IsSpecial && x.Special == SpecialEnum.Rainman; }
        }

        /// <summary>
        /// Sakecup animal card lambda
        /// </summary>
        public static Func<Card, bool> SakeCup
        {
            get { return x => x.IsAnimal && x.Animal == AnimalEnum.SakeCup; }
        }

        /// <summary>
        /// Curtain special card lambda
        /// </summary>
        public static Func<Card, bool> Curtain
        {
            get { return x => x.IsSpecial && x.Special == SpecialEnum.Curtain; }
        }

        /// <summary>
        /// Moon special card lambda
        /// </summary>
        public static Func<Card, bool> Moon
        {
            get { return x => x.IsSpecial && x.Special == SpecialEnum.Moon; }
        }

        /// <summary>
        /// Poem ribbon card lambda
        /// </summary>
        public static Func<Card, bool> Poem
        {
            get { return x => x.IsRibbon && x.Ribbon == RibbonEnum.Poem; }
        }

        /// <summary>
        /// Blue ribbon card lambda
        /// </summary>
        public static Func<Card, bool> Blue
        {
            get { return x => x.IsRibbon && x.Ribbon == RibbonEnum.Blue; }
        } 

        /// <summary>
        /// Inoshikacho animal card lambda
        /// </summary>
        public static Func<Card, bool> Inoshikacho
        {
            get { return x => x.Animal == AnimalEnum.Boar || x.Animal == AnimalEnum.Butterflies || x.Animal == AnimalEnum.Deer; }
        }
    }
}
