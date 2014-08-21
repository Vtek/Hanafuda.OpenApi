using System;
using Hanafuda.OpenApi.Enums;

namespace Hanafuda.OpenApi.Entities
{
    /// <summary>
    /// Define a card
    /// </summary>
    [Serializable]
    public sealed class Card
    {
        /// <summary>
        /// Card identity
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Card family
        /// </summary>
        public FamilyEnum Family { get; private set; }

        /// <summary>
        /// Card month
        /// </summary>
        public MonthEnum Month { get; private set; }

        /// <summary>
        /// Ribbon type of the card
        /// </summary>
        public RibbonEnum? Ribbon { get; private set; }

        /// <summary>
        /// Animal type of the card
        /// </summary>
        public AnimalEnum? Animal { get; private set; }

        /// <summary>
        /// Special type of the card
        /// </summary>
        public SpecialEnum? Special { get; private set; }

        /// <summary>
        /// True if card is Ribbon
        /// </summary>
        public bool IsRibbon
        {
            get { return Ribbon.HasValue; }
        }

        /// <summary>
        /// True if card is Animal
        /// </summary>
        public bool IsAnimal
        {
            get { return Animal.HasValue; }
        }

        /// <summary>
        /// True if card is Special
        /// </summary>
        public bool IsSpecial
        {
            get { return Special.HasValue; }
        }

        /// <summary>
        /// true if card is Normal
        /// </summary>
        public bool IsNormal
        {
            get { return !Special.HasValue && !Ribbon.HasValue && !Animal.HasValue; }
        }

        /// <summary>
        /// Create a new instance of a normal Card
        /// </summary>
        /// <param name="id">Identity of the card</param>
        /// <param name="family">Card family</param>
        /// <param name="month">Card month</param>
        public Card(int id, FamilyEnum family, MonthEnum month)
        {
            Id = id;
            Family = family;
            Month = month;
        }

        /// <summary>
        /// Create a new instance of a normal Card
        /// </summary>
        /// <param name="id">Identity of the card</param>
        /// <param name="month">Card month</param>
        public Card(int id, MonthEnum month)
            :this(id, FamilyEnum.Normal, month)
        {
            
        }

        /// <summary>
        /// Create a new instance of a ribbon Card
        /// </summary>
        /// <param name="id">Identity of the card</param>
        /// <param name="month">Card month</param>
        /// <param name="ribbon">Ribbon type</param>
        public Card(int id, MonthEnum month, RibbonEnum ribbon)
            :this(id, FamilyEnum.Ribbon, month)
        {
            Ribbon = ribbon;
        }

        /// <summary>
        /// Create a new instance of an animal Card
        /// </summary>
        /// <param name="id">Identity of the card</param>
        /// <param name="month">Card month</param>
        /// <param name="animal">Animal type</param>
        public Card(int id, MonthEnum month, AnimalEnum animal)
            : this(id, FamilyEnum.Animal, month)
        {
            Animal = animal;
        }

        /// <summary>
        /// Create a new instance of a special Card
        /// </summary>
        /// <param name="id">Identity of the card</param>
        /// <param name="month">Card month</param>
        /// <param name="special">Special type</param>
        public Card(int id, MonthEnum month, SpecialEnum special)
            : this(id, FamilyEnum.Special, month)
        {
            Special = special;
        }

        /// <summary>
        /// True if the card object is equal to the instance of card
        /// </summary>
        /// <param name="card">Card to test</param>
        /// <returns>True if the card object is equal</returns>
        private bool Equals(Card card)
        {
            return Id == card.Id && 
                   Family == card.Family && 
                   Month == card.Month && 
                   Ribbon == card.Ribbon && 
                   Animal == card.Animal && 
                   Special == card.Special;
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
            return obj is Card && Equals((Card)obj);
        }

        /// <summary>
        /// Hashcode
        /// </summary>
        /// <returns>Hashcode</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return Family.GetHashCode() *
                       Month.GetHashCode() *
                       Ribbon.GetHashCode() * 
                       Animal.GetHashCode() *
                       Special.GetHashCode() *
                       Id.GetHashCode();
            }
        }
    }
}
