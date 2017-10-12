namespace Delta.Shared.Models.ShipDetails
{
    public interface IHigherDeckModule
    {
        string Name { get; set; }
        float Weight { get; set; }
        float Durability { get; set; }
    }
}