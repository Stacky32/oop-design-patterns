using System;

namespace Library.GangOfFour.Behavioural.Mediator;

public sealed class Member : Participant
{
    public Member(string userName) : base(userName) {}

    public override void Receive(string from, string message)
    {
        Console.WriteLine($"To a {nameof(Member)}");
        base.Receive(from, message);
    }
}