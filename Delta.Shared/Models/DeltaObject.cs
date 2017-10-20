namespace Delta.Shared.Models
{
    public abstract class DeltaObject
    {
        public virtual string Name {get;set;}
        public virtual string Description {get;set;}
        public override string ToString() => Name;
    }
}