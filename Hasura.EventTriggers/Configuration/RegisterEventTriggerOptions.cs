using Hasura.EventTriggers.Models;

namespace Hasura.EventTriggers.Configuration;

public class RegisterEventTriggerOptions
{
    public string Name { get; set; }
    public string UrlPath { get; set; }

    public string Source { get; set; } = "default";
    public Table Table { get; set; }
    public OperationSpec? Insert { get; set; }
    public OperationSpec? Update { get; set; }
    public bool Delete { get; set; }
}