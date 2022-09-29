namespace Hasura.EventTriggers.Models;

public class OperationSpecCreateModel
{
    public OperationSpecCreateModel()
    {
        columns = new List<string>();
        columns = new List<string>();
    }

    public List<string> columns { get; set; }
    public List<string> payload { get; set; }
}