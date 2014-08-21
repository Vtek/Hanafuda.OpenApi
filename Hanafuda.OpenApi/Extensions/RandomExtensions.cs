using System;

namespace Hanafuda.OpenApi.Extensions
{
    /// <summary>
    /// Random extensions
    /// </summary>
    static class RandomExtensions
    {
        /// <summary>
        /// Get a random boolean
        /// </summary>
        /// <param name="random">Extend random</param>
        /// <returns>A random boolean</returns>
        public static bool NextBool(this Random random)
        {
            return random.Next(2) == 1;
        }
    }
}
