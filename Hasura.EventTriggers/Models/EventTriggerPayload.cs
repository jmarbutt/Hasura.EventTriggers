namespace Hasura.EventTriggers.Models;
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

public class EventTriggerPayload<T>
{
    public Event<T> Event { get; set; }
    public string Created_At { get; set; }
    public string Id { get; set; }
    public Trigger Trigger { get; set; }
    public Table Table { get; set; }
}