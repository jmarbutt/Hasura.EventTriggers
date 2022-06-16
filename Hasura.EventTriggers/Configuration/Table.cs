namespace Hasura.EventTriggers.Configuration;

public class Table
{
    public Table(string name, string? schema)
    {
        Name = name;
        Schema = schema;
    }

    public string Name { get; set; }
    public string? Schema { get; set; }
}