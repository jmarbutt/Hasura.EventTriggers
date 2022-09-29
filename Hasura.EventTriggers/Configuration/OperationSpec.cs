using Hasura.EventTriggers.Models;

namespace Hasura.EventTriggers.Configuration;

public class OperationSpec
{
    public string[]? Columns { get; set; }
    public string[]? Payload { get; set; }

    public OperationSpecCreateModel ConvertToCreateModel()
    {
        var model = new OperationSpecCreateModel
        {
            columns = Columns.ToList(),
            payload = Payload.ToList()
        };

        return model;
    }
}