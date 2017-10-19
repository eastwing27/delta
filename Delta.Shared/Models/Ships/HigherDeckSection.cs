namespace Delta.Shared.Models.Ships
{
    public abstract class HigherDeckSection : DeltaObject, IDeckSection, IDetail
    {
        public byte Position { get; internal set; }
        public object Resource { get; internal set; }

        public abstract IHigherDeckModule Module {get;}
    }
}