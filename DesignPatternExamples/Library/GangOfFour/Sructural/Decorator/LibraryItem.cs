namespace Library.GangOfFour.Structural.Decorator;

public abstract class LibraryItem<T>
{
    public static int NumCopies { get; set; }
    public abstract void Display();
}