using System;

namespace Library.GangOfFour.Structural.Bridge;

// The RefinedAbstraction class
public class Customers : CustomersBase
{
    public Customers(IDataObject<string> data) : base(data)
    {
    }

    public override void ShowAll()
    {
        Console.WriteLine();
        Console.WriteLine("------------------------");
        base.ShowAll();
        Console.WriteLine("------------------------\n");
   }
}