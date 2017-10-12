namespace Delta.Shared.Models.ShipDetails
{
    public abstract class HigherDeckSection : IDeckSection
    {
        public byte HorizontalPosition { get; set; }
        public abstract IHigherDeckModule Module {get; set;}
    }
}