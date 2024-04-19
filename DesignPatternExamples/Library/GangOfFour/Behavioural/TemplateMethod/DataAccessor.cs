using System.Collections.Generic;

namespace Library.GangOfFour.Behavioural.TemplateMethod;

public abstract class DataAccessor<T> where T : class, new()
{
    protected List<T> Items { get; set; } = [];

    public abstract void Select();
    public abstract void Process(int top);

    public virtual void Connect()
    {
        Items.Clear();
    }

    public virtual void Disconnect()
    {
        Items.Clear();
    }

    public void Run(int top)
    {
        Connect();
        Select();
        Process(top);
        Disconnect();
    }
}