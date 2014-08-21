using System.Collections.Generic;
using Hanafuda.OpenApi.Enums;

namespace Hanafuda.OpenApi.Entities
{
    /// <summary>
    /// Define an base player class
    /// </summary>
    public abstract class AbstractPlayer
    {
        /// <summary>
        /// True if the player is Oya of the current game turn
        /// </summary>
        public bool IsOya { get; set; }

        /// <summary>
        /// Get or set the Player hand
        /// </summary>
        public IEnumerable<Card> Hand { get; set; }

        /// <summary>
        /// Get or set the Pile to stack card taken by the player
        /// </summary>
        public IEnumerable<Card> Pile { get; set; }

        /// <summary>
        /// Get or set the Score
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Get or set the Yakus made by the Player in the current game turn
        /// </summary>
        public IEnumerable<YakuEnum> Yakus { get; set; } 
    }
}
