using Library.GangOfFour.Structural.Facade.Subsystems;

namespace Library.GangOfFour.Structural.Facade;

public class Mortgage
{
    private readonly Bank bank = new();
    private readonly Loan loan = new();
    private readonly Credit credit = new();

    public bool IsEligible(Customer cust, int amount) =>
        bank.HasSufficientSavings(cust, amount)
        && loan.HasNoBadLoans(cust)
        && credit.HasGoodCredit(cust);
}