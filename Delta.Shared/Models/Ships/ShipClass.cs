using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Delta.Shared.Models.Ships
{
    public class ShipClass : DeltaObject, IEnumerable<IDeck<IDeckSection>>
    {
        public Hull Hull {get;set;}
        public IShipBow Bow {get;set;}
        public IShipForage Forage {get;set;}
        private IDeck[] decks {get; set;}
        public IEnumerable<IDeck<IDeckSection>> Decks 
            => (IEnumerable<IDeck<IDeckSection>>)decks;

        public byte DecksCount => (byte)decks.Length;

        public bool IsValid => 
            Hull != null &&
            Bow != null &&
            Forage != null &&
            decks.Any() &&
            decks.Where (deck => deck is HigherDeck).Count() <= 1;

        public ShipClass (string ClassName, string Description, byte Length, IEnumerable<IDeck> Decks, IShipBow Bow, IShipForage Forage)
        {
            if (!Decks.Any())
                throw new ArgumentException("At least one deck must be specified");

            this.decks = Decks.ToArray();
            this.Bow = Bow;
            this.Forage = Forage;

            this.Name = Name;
            this.Description = Description;
        }

        public override string ToString() => Name;

        public IEnumerator<IDeck<IDeckSection>> GetEnumerator()
        {
            return Decks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return decks.GetEnumerator();
        }
    }
}