namespace Delta.Shared.Models.Enums
{
    public enum DeckSectionTypes : byte 
    {
        Platform = 0, //Участок верхней палубы
        Compartment = 1, //Отсек
        House = 3, //Рубка
        Special = 4, //Особая секция
        Decoration = 5 //Не несёт функциональной нагрузки, влияет только на внешний вид корабля
    }
}