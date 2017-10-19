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
        private List <IDeck> decks {get; set;}
        public IEnumerable<IDeck<IDeckSection>> Decks 
            => (IEnumerable<IDeck<IDeckSection>>)decks;

        public bool IsValid => 
            Hull != null &&
            Bow != null &&
            Forage != null &&
            decks.Any() &&
            decks.Where (deck => deck is HigherDeck).Count() <= 1;

        public ShipClass (byte Decks, byte Length, bool HasHigherDeck = true)
        {
            if (Decks < 1)
                throw new ArgumentException("At least one deck must be specified");

            this.decks = new List<IDeck>();

            byte counterStart = 0;
            if (HasHigherDeck)
            {
                Decks--;
                counterStart++;
                this.decks.Add(new HigherDeck(Length));
            }

            for (byte i = counterStart; i < Decks+counterStart; i++)
                decks.Add(new Deck(Length, i));
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