using System;
using System.Collections.Generic;

namespace Library.GangOfFour.Structural.Decorator;

public class Borrowable<T> : Decorator<T>
{
    
    private readonly List<string> _borrowers = [];

    public Borrowable(LibraryItem<T> libraryItem)
        : base(libraryItem)
    {
        
    }

    public void BorrowItem(string name)
    {
        _borrowers.Add(name);
        NumCopies--;
    }

    public void ReturnItem(string name)
    {
        _borrowers.Remove(name);
        NumCopies++;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Borrowers:");
        _borrowers.ForEach(b => Console.WriteLine($"  - {b}"));
    }
}