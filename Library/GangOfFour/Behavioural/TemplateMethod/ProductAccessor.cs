using System;

namespace Library.GangOfFour.Behavioural.TemplateMethod;

public class ProductAccessor : DataAccessor<Product>
{
    public override void Select()
    {
        Items.AddRange([
            new() { ProductName = "Red" },
            new() { ProductName = "Green" },
            new() { ProductName = "Blue" },
            new() { ProductName = "Purple" },
            new() { ProductName = "Orange" },
            new() { ProductName = "Pink" },
            new() { ProductName = "Brown" }
        ]);
    }

    public override void Process(int top)
    {
        Console.WriteLine("Products:");
        
        for (var i = 0; i < top && i < Items.Count; i++)
        {
            Console.WriteLine(Items[i].ProductName);
        }

        Console.WriteLine("");
    }
}