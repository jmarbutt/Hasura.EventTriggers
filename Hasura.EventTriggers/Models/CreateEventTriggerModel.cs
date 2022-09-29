namespace Hasura.EventTriggers.Models;

public class CreateEventTriggerModel
{
    public CreateEventTriggerModel()
    {
        args = new Args();
    }
    public string type { get; set; }
    public Args args { get; set; }
}
