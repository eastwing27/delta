using System.Collections.Generic;

namespace Delta.Shared.Models.Ships
{
    public interface IDeck<T> where T : IDeckSection
    {
        byte Number {get;}
        byte Length {get;}
        IEnumerable<T> Sections {get;}
    }
}