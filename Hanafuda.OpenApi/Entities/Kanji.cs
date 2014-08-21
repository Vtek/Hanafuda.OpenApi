
namespace Hanafuda.OpenApi.Entities
{
    /// <summary>
    /// Kanji entity
    /// </summary>
    public sealed class Kanji
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Symbol
        /// </summary>
        public string Symbol { get; private set; }

        /// <summary>
        /// Create a new instance of Kanji
        /// </summary>
        /// <param name="name">Name of the Kanji</param>
        /// <param name="symbol">Symbol of Kanji</param>
        public Kanji(string name, string symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        /// <summary>
        /// True if the kanji object is equal to the instance of kanji
        /// </summary>
        /// <param name="kanji">kanji to test</param>
        /// <returns>True if the kanji object is equal</returns>
        private bool Equals(Kanji kanji)
        {
            return Name == kanji.Name &&
                   Symbol == kanji.Symbol;
        }

        /// <summary>
        /// True if the object is equal to an other instance of object
        /// </summary>
        /// <param name="obj">obj to test</param>
        /// <returns>True if the object is equal to an other instance of object</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;
            return obj is Kanji && Equals((Kanji)obj);
        }

        /// <summary>
        /// Hashcode
        /// </summary>
        /// <returns>Hashcode</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return (Name != null ? Name.GetHashCode() : 0) *
                       (Symbol != null ? Symbol.GetHashCode() : 0);
            }
        }
    }
}
