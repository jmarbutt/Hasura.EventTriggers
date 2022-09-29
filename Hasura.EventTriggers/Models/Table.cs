namespace Hasura.EventTriggers.Models;

public class Table
{
    public Table(string name = "", string schema = "dbo")
    {
        this.name = name;
        this.schema = schema;
    }


    public string schema { get; set; }
    public string name { get; set; }
}