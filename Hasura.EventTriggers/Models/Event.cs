namespace Hasura.EventTriggers.Models;

public class Event<T>
{
    public object Session_Variables { get; set; }
    public string Op { get; set; }
    public Data<T> Data { get; set; }
}