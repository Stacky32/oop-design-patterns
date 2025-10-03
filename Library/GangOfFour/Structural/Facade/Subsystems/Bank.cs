namespace Library.GangOfFour.Structural.Facade.Subsystems;

public class Bank
{
    public bool HasSufficientSavings(Customer c, int amount) => c.Name == "Meerm";
}


