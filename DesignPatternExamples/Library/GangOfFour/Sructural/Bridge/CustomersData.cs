using System;
using System.Collections.Generic;

namespace Library.GangOfFour.Structural.Bridge;

public class CustomersData : IDataObject<string>
{
    private readonly string _city;
    private readonly List<string> _customers;
    private int _current = 0;

    public CustomersData(string city)
    {
        _city = city;

        _customers =
        [
            "Jim Jones", "Donnie Rump", "Snoop Frogg"
        ];
    }

    public void AddRecord(string t) => _customers.Add(t);

    public void DeleteRecord(string t) => _customers.Remove(t);

    public string GetCurrentRecord() => _customers[_current];

    public void NextRecord()
    {
        if (_current < _customers.Count - 1)
        {
            _current++;
        }
    }

    public void PreviousRecord()
    {
        if (_current > 0)
        {
            _current--;
        }
    }

    public void ShowRecord()
    {
        Console.WriteLine(GetCurrentRecord());
    }

    public void ShowAllRecords()
    {
        Console.WriteLine($"Customer Group: {_city}");
        _customers.ForEach(c => Console.WriteLine("  " + c));
    }
}