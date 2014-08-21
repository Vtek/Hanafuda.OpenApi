using System;
using Hanafuda.OpenApi.Entities;

namespace Hanafuda.OpenApi.Attributes
{
    /// <summary>
    /// Define a Kanji
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
    public sealed class KanjiAttribute : Attribute
    {
        /// <summary>
        /// Kanji
        /// </summary>
        public Kanji Kanji { get; private set; }

        /// <summary>
        /// Create a new instance of KanjiAttribute
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="symbol">symbol</param>
        public KanjiAttribute(string name, string symbol)
        {
            Kanji = new Kanji(name, symbol);
        }
    }
}