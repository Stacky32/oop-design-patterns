using System.Collections;
using System.Collections.Generic;

namespace Library.GangOfFour.Behavioural.Iterator;

public class ItemColection<T> : IEnumerable<T>
{
    private readonly List<T> _items = [];

    public int Count => _items.Count;

    public IEnumerable<T> Forwards => this;
    
    public IEnumerable<T> Backwards
    {
        get
        {
            for (var i = Count - 1; i >= 0; i--)
            {
                yield return _items[i];
            }
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (var i = 0; i < Count; i++)
        {
            yield return _items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Add(T item) => _items.Add(item);

    public IEnumerable<T> FromToStep(int from, int to, int step)
    {
        for (var i = from; i <= to; i += step)
        {
            yield return _items[i];
        }
    }
}