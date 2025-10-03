namespace Library.GangOfFour.Behavioural.State;

public abstract class State
{
    protected double interest;
    protected double lowerLimit;
    protected double upperLimit;

    public double Balance { get; set; }

    public virtual void Deposit(double amount, Account context)
    {
        Balance += amount;
        StateChangedCheck(context);
    }

    public virtual void Withdraw(double amount, Account context)
    {
        Balance -= amount;
        StateChangedCheck(context);
    }

    public virtual double PayInterest(Account context) {
        var interestPaid = Balance * interest;
        Balance += interestPaid;
        StateChangedCheck(context);

        return interestPaid;
    }

    protected abstract void StateChangedCheck(Account context);
}