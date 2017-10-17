namespace Delta.Shared.Models.Ships
{
    public abstract class HigherDeckPlaceModule : DeltaObject, IHigherDeckModule
    {
        public float Durability {get; set;}

        public object Resource {get; set;}
    }
}