namespace Delta.Shared.Models
{
    public abstract class DeltaObject
    {
        public string Name {get;set;}
        public string Descrition {get;set;}
        public override string ToString() => Name;
    }
}