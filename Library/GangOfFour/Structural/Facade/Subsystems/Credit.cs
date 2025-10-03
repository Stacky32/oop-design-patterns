namespace Library.GangOfFour.Structural.Facade.Subsystems;

public class Credit
{
    public bool HasGoodCredit(Customer c) => c.Name == "Meerm";
}