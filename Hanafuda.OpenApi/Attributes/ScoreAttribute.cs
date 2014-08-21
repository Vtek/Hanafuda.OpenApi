using System;

namespace Hanafuda.OpenApi.Attributes
{
    /// <summary>
    /// Define a score
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
    public sealed class ScoreAttribute : Attribute
    {
        /// <summary>
        /// Score
        /// </summary>
        public byte Score { get; private set; }

        /// <summary>
        /// Create a new instance of a ScoreAttribute
        /// </summary>
        /// <param name="score">Score</param>
        public ScoreAttribute(byte score)
        {
            Score = score;
        }
    }
}
