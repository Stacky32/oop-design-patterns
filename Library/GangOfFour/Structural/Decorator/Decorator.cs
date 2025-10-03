namespace Library.GangOfFour.Structural.Decorator;

public abstract class Decorator<T>(LibraryItem<T> _libraryItem) : LibraryItem<T>
{
    public override void Display() => _libraryItem.Display();
}