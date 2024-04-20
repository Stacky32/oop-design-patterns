using System;

namespace Library.GangOfFour.Behavioural.Mediator;

public sealed class Moderator : Participant
{
    public Moderator(string userName) : base(userName) {}

    public override void Receive(string from, string message)
    {
        Console.WriteLine($"To a {nameof(Moderator)}");
        base.Receive(from, message);
    }
}