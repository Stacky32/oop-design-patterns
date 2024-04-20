using System;

namespace Library.GangOfFour.Behavioural.Mediator;

public abstract class Participant
{
    public string UserName { get; }

    public IChatroomSender? Chatroom { get; set; }

    public Participant(string userName)
    {
        UserName = userName;
    }

    public void Send(string to, string message)
    {
        Chatroom?.Send(UserName, to, message);
    }

    public virtual void Receive(string from, string message)
    {
        Console.WriteLine($"From: {from}\nTo: {UserName}\nMessage: '{message}'\n");
    }
}