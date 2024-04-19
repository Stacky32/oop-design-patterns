using System;

namespace Library.GangOfFour.Behavioural.TemplateMethod;

public class CategoryAccessor : DataAccessor<Category>
{
    public override void Select()
    {
        Items.AddRange([
            new() { CategoryName = "Red" },
            new() { CategoryName = "Green" },
            new() { CategoryName = "Blue" },
            new() { CategoryName = "Purple" },
            new() { CategoryName = "Orange" },
            new() { CategoryName = "Pink" },
            new() { CategoryName = "Brown" }
        ]);
    }

    public override void Process(int top)
    {
        Console.WriteLine("Categories:");
        
        for (var i = 0; i < top && i < Items.Count; i++)
        {
            Console.WriteLine(Items[i].CategoryName);
        }

        Console.WriteLine("");
    }
}