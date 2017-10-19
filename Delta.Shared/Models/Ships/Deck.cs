using System.Collections.Generic;

namespace Delta.Shared.Models.Ships
{
    internal class Deck : IDeck<DeckSection>
    {
        public byte Number {get; private set;}

        public byte Length => (byte)Sections.Length;

        public DeckSection[] Sections {get; private set;}

        public Deck (byte Length, byte Number)
        {
            Sections = new DeckSection[Length];
            this.Number = Number;
        }
    }
}