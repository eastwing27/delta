using System.Collections.Generic;

namespace Delta.Shared.Models.Ships
{
    internal class DeckSection : DeltaObject, IDeckSection, IDetail, ITraitable<Ship>
    {
        public byte Position {get; internal set;}
 
        public object Resource {get; set;}

        public IEnumerable<Trait<Ship>> Traits {get; internal set;}
    }
}