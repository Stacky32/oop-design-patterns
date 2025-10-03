namespace Library.GangOfFour.Behavioural.State;

public class SilverState : State
{
    public SilverState(State state)
        : this(state.Balance)
    {
    }

    public SilverState(double balance)
    {
        Balance = balance;
        Initialise();
    }

    private void Initialise()
    {
        interest = 0.0;
        lowerLimit = 0.0;
        upperLimit = 1000.0;
    }

    protected override void StateChangedCheck(Account context)
    {
        if (Balance < lowerLimit)
        {
            context.State = new RedState(this);
        }
        else if (Balance > upperLimit)
        {
            context.State = new GoldState(this);
        }
    }
}