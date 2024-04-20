namespace Library.GangOfFour.Behavioural.State;

public class GoldState : State
{
    public GoldState(State state)
        : this(state.Balance)
    {
    
    }

    public GoldState(double balance)
    {
        Balance = balance;
        Initialise();
    }

    private void Initialise()
    {
        interest = 0.05;
        lowerLimit = 1000.0;
        upperLimit = 10000000;
    }

    protected override void StateChangedCheck(Account context)
    {
        if (Balance < 0.0)
        {
            context.State = new RedState(this);
        }
        else if (Balance < lowerLimit)
        {
            context.State = new SilverState(this);
        }
    }
}