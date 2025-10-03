using System;

namespace Library.GangOfFour.Behavioural.State;

public class Account
{
    private readonly string _owner;

    public Account(string owner)
    {
        _owner = owner;
        State = new SilverState(0.0);
    }

    public double Balance => State.Balance;

    public State State;

    public void Deposit(double amount)
    {
        State.Deposit(amount, this);
        Console.WriteLine("Account {0}", _owner);
        Console.WriteLine("Deposited {0:C} --- ", amount);
        Console.WriteLine(" Balance = {0:C}", this.Balance);
        Console.WriteLine(" Status  = {0}",
            State.GetType().Name);
        Console.WriteLine("");
    }

    public void Withdraw(double amount)
    {
        State.Withdraw(amount, this);
        Console.WriteLine("Account {0}", _owner);
        Console.WriteLine("Withdrew {0:C} --- ", amount);
        Console.WriteLine(" Balance = {0:C}", this.Balance);
        Console.WriteLine(" Status  = {0}\n",
            State.GetType().Name);
    }

    public void PayInterest()
    {
        var interestPaid = State.PayInterest(this);
        Console.WriteLine("Account {0}", _owner);
        Console.WriteLine("Interest Paid --- {0}", interestPaid);
        Console.WriteLine(" Balance = {0:C}", this.Balance);
        Console.WriteLine(" Status  = {0}\n",
            State.GetType().Name);
    }
}