using System;
using System.Runtime.CompilerServices;

namespace Library.GangOfFour.Behavioural.State;

public class RedState : State
{
    public RedState(State state)
    {
        Balance = state.Balance;
        Initialise();
    }

    private void Initialise()
    {
        interest = 0.0;
        lowerLimit = -100.0;
        upperLimit = 0.0;
    }

    public override void Withdraw(double amount, Account context)
    {
        Console.WriteLine("No funds available");
    }

    protected override void StateChangedCheck(Account context)
    {
        if (Balance > upperLimit)
        {
            context.State = new SilverState(this);
        }
    }
}