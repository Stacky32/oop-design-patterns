using System;

namespace Library.GangOfFour.Structural.Decorator;

public sealed class Book : LibraryItem<Book>
{
    private readonly string _author;
    private readonly string _title;

    public Book(string author, string title, int numCopies)
    {
        _author = author;
        _title = title;
        NumCopies = numCopies;
    }

    public override void Display()
    {
        Console.WriteLine(@$"
            \nBook ---------
              Author: {_author}
              Title: {_title}
              Copies: {NumCopies}\n");
    }
}