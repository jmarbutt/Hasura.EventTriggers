namespace Hasura.EventTriggers.Models;

public class Data<T>
{
    public T Old { get; set; }
    public T New { get; set; }
}