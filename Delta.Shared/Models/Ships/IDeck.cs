using System.Collections.Generic;

namespace Delta.Shared.Models.Ships
{
    public interface IDeck
    {
        byte Number {get;}
        byte Length {get;}
    }

    public interface IDeck<T> : IDeck where T : IDeckSection
    {
        T[] Sections {get;}
    }
}