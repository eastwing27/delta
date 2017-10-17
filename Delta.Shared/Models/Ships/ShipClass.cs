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
        public IEnumerable <IDeck<IDeckSection>> Decks {get;set;}

        public bool IsValid => 
            Hull != null &&
            Bow != null &&
            Forage != null &&
            Decks.Any() &&
            Decks.Where (deck => deck is HigherDeck).Count() <= 1;

        public ShipClass (int Decks, int Length, bool HasHigherDeck = true)
        {
            if (Decks < 1)
                throw new ArgumentException("At least one deck must be specified");

            
        }

        public override string ToString() => Name;

        public IEnumerator<IDeck<IDeckSection>> GetEnumerator()
        {
            return Decks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Decks.GetEnumerator();
        }
    }
}