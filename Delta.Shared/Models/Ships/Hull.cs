using System.Collections.Generic;

namespace Delta.Shared.Models.Ships
{
    public class Hull : DeltaObject, ITraitable<Ship>
    {
        public float ArmorClass {get;set;}

        public IEnumerable<Trait<Ship>> Traits {get; internal set;}

    }
}