using System.Collections.Generic;

namespace Delta.Shared.Models.Ships
{
    public class ShipClass
    {
        public string  Name {get;set;}
        public Hull Hull {get;set;}
        public IShipBow Bow {get;set;}
        public IShipForage Forage {get;set;}
        public IEnumerable <IDeck> Decks {get;set;}
        
    }
}