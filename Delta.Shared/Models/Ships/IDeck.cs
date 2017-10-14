namespace Delta.Shared.Models.Ships
{
    public interface IDeck
    {
        byte Number {get;set;}
        byte Length {get;set;}
        IDeckSection[] Sections {get;set;}
    }
}