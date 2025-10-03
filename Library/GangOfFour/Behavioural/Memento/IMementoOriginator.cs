namespace Library.GangOfFour.Behavioural.Memento;

public interface IMementoOriginator<T>
{
    bool RestoreMemento(Memento<T> memento);
    
    Memento<T> SaveMemento();
}