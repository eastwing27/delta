using System.Collections.Generic;

namespace Delta.Shared.Models.Ships
{
    public class HigherDeck : IDeck<HigherDeckSection>
    {
        public byte Number => 0;

        public byte Length {get; internal set;}

        public IEnumerable<HigherDeckSection> Sections {get; internal set;}
    }
}