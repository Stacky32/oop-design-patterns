namespace Library.GangOfFour.Structural.Bridge;

// The Abstraction class
public abstract class CustomersBase
{
    protected IDataObject<string> _data;

    public CustomersBase(IDataObject<string> data)
    {
        _data = data;
    }

    public virtual void Next() => _data.NextRecord();
    public virtual void Previous() => _data.PreviousRecord();
    public virtual void Add(string name) => _data.AddRecord(name);
    public virtual void Delete(string name) => _data.DeleteRecord(name);
    public virtual void Show() => _data.ShowRecord();
    public virtual void ShowAll() => _data.ShowAllRecords();
}