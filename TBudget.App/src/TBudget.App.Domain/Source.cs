namespace CashDB.Domain;

public sealed class Source
{
    public Guid Id { get; }
    public string Name { get; }
    public SourceType Type { get; }
    public string DateFormat { get; }
    public string Description { get; }
    public List<SourceColumnMap> Columns { get; }

    private Source(
        Guid id,
        string name,
        SourceType type,
        string dateFormat,
        string description,
        List<SourceColumnMap> columns)
    {
        Id = id;
        Name = name;
        DateFormat = dateFormat;
        Type = type;
        Description = description;
        Columns = columns;
    }

    // public static Source Create()
    // {
    // }
}
