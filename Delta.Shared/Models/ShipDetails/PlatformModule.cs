namespace Delta.Shared.Models.ShipDetails
{
    public class PlatformModule : IHigherDeckModule
    {
        public string Name { get; set; }
        public  float Weight { get; set; }
        public float Durability { get; set; }
    }
}