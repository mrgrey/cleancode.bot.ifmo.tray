/// <summary>
/// Статус ответа от data source proxy
/// </summary>
/// <remarks>
/// Данные имена нельзя менять для
/// корректного парсинга из json'а
/// </remarks>
public enum Status
{
    Success,
    NoLessons,
    WrongGroup
}