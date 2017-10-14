using System.Collections.Generic;

namespace Delta.Shared.Models.Ships
{
    public interface IDeck
    {
        byte Number {get;}
        byte Length {get;}
        IEnumerable<IDeckSection> Sections {get;}
    }
}