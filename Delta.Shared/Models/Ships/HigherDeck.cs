using System.Collections.Generic;

namespace Delta.Shared.Models.Ships
{
    public class HigherDeck : IDeck<HigherDeckSection>
    {
        public byte Number => 0;

        public byte Length => (byte)Sections.Length;

        public HigherDeckSection[] Sections {get; private set;}

        public HigherDeck (byte Length)
        {
            Sections = new HigherDeckSection[Length];
        }
    }
}