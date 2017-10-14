using System.Collections.Generic;

namespace Delta.Shared.Models
{
    public interface ITraitable<T>
    {
        IEnumerable<Trait<T>> Traits {get;}
    }
}