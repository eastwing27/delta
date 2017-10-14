using System.Collections.Generic;

namespace Delta.Shared.Models.Ships
{
    public class ShipClass : DeltaObject
    {
        public Hull Hull {get;set;}
        public IShipBow Bow {get;set;}
        public IShipForage Forage {get;set;}
        public IEnumerable <IDeck> Decks {get;set;}
        
        public override string ToString() => Name;
    }
}