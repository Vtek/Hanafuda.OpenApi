using Hanafuda.OpenApi.Attributes;
using Hanafuda.OpenApi.Entities;
using System;
using System.Reflection;

namespace Hanafuda.OpenApi.Extensions
{
    /// <summary>
    /// Hanafuda entities extension
    /// </summary>
    public static class EnumExtension
    {
        /// <summary>
        /// Get the name
        /// </summary>
        /// <param name="value">Enumeration</param>
        /// <returns>Kanji</returns>
        public static Kanji GetKanji(this Enum value)
        {
            var attribute = value
                .GetType()
                .GetField(value.ToString())
                .GetCustomAttribute<KanjiAttribute>();

            return attribute == null ? null : attribute.Kanji;
        }

        /// <summary>
        /// Get the score of an enum value
        /// </summary>
        /// <param name="value">The enumeration</param>
        /// <returns>Score value</returns>
        public static byte? GetScore(this Enum value)
        {
            var attribute =  value
                .GetType()
                .GetField(value.ToString())
                .GetCustomAttribute<ScoreAttribute>();

            return attribute == null ? new byte?() : attribute.Score;
        }
    }
}