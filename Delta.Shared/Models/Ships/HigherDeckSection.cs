namespace Delta.Shared.Models.Ships
{
    public abstract class HigherDeckSection : IDeckSection
    {
        public byte Position { get; internal set; }
        public object Resource { get; internal set; }

        public abstract IHigherDeckModule Module {get;set;}
    }
}