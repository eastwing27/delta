namespace Delta.Shared.Models.Ships
{
    public class Ship : DeltaObject
    {
        public ShipClass Class {get; private set;}

        public Ship (ShipClass Class)
        {
            this.Class = Class;
        }
    }
}