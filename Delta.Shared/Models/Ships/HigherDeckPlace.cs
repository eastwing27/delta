namespace Delta.Shared.Models.Ships
{
    public class HigherDeckPlace : HigherDeckSection
    {
        public HigherDeckPlaceModule PlaceModule { get; set; }
        public override IHigherDeckModule Module => PlaceModule as IHigherDeckModule;
    }
}