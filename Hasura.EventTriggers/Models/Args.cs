namespace Hasura.EventTriggers.Models;

public class Args
{
    public Args()
    {
        table = new Table();
        insert = new OperationSpecCreateModel();
        update = new OperationSpecCreateModel();
    }
    
    public string name { get; set; }
    public string source { get; set; }
    public Table table { get; set; }
    public string webhook { get; set; }
    public OperationSpecCreateModel insert { get; set; }
    public OperationSpecCreateModel update { get; set; }
}