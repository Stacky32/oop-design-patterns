using System.Text.Json;

namespace Library.GangOfFour.Behavioural.Memento;

public class Memento<T>
{
    private string store = null!;

    public Memento<T> Serialize(object o)
    {
        store = JsonSerializer.Serialize(o);
        return this;
    }

    public T? Deserialize()
    {
        return JsonSerializer.Deserialize<T>(store)!;
    }
}