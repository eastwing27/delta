using System.Collections.Generic;

namespace Delta.Shared.Models.Ships
{
    public class Hull : DeltaObject, IDetail, ITraitable<Ship>
    {
        public float ArmorClass {get;set;}

        public IEnumerable<Trait<Ship>> Traits {get; internal set;}

        public object Resource { get; internal set; }
    }
}