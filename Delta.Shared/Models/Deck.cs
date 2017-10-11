using Delta.Shared.Models.Enums;

namespace Delta.Shared.Models
{
    public class Deck
    {
        public bool IsHigher {get;set;}
        public DeckSectionTypes[] AvailibleTypes => IsHigher 
            ? new[] {DeckSectionTypes.Decoration, DeckSectionTypes.House, DeckSectionTypes.Platform, DeckSectionTypes.Special}
            : new[] {DeckSectionTypes.Compartment, DeckSectionTypes.Decoration, DeckSectionTypes.Special}
    }
}