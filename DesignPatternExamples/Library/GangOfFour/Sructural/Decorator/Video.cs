using System;

namespace Library.GangOfFour.Structural.Decorator;

public sealed class Video : LibraryItem<Video>
{
    private readonly string _director;
    private readonly string _title;
    private readonly int _runtime;

    public Video(
        string director,
        string title,
        int runtime,
        int numCopies)
    {
        _director = director;
        _title = title;
        _runtime = runtime;
        NumCopies = numCopies;
    }

    public override void Display()
    {
        Console.WriteLine(@$"
            \nVideo ----------
            Director: {_director}
            Title: {_title}
            Copies: {NumCopies}
            Runtime: {_runtime} mins\n");
    }
}