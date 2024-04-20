namespace Library.GangOfFour.Structural.Bridge;

// The Implementor interface
public interface IDataObject<T>
{
    void NextRecord();
    void PreviousRecord();
    void AddRecord(T t);
    void DeleteRecord(T t);
    T GetCurrentRecord();
    void ShowRecord();
    void ShowAllRecords();
}