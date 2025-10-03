using System;

namespace Library.GangOfFour.Behavioural.Observer;

public class Investor : IInvestor
{
    public string Name { get; set; } = null!;

    public void Update(object? sender, ChangeEventArgs e)
    {
        Console.WriteLine(
            "Notified {0} of {1}'s change to {2:c}",
            Name,
            e.Symbol,
            e.Price);
    }
}