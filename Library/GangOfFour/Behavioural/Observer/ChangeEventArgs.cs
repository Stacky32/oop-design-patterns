using System;

namespace Library.GangOfFour.Behavioural.Observer;

public class ChangeEventArgs : EventArgs
{
    public string Symbol { get; set; } = null!;
    public double Price { get; set; }

    public ChangeEventArgs(string symbol, double price)
    {
        Symbol = symbol;
        Price = price;
    }
}