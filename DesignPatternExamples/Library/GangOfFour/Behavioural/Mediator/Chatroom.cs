using System;
using System.Collections.Generic;

namespace Library.GangOfFour.Behavioural.Mediator;

public class Chatroom : IChatroom
{
    private readonly Dictionary<string, Participant> _participants = [];

    public void Register(Participant participant)
    {
        if (_participants.TryAdd(participant.UserName, participant))
        {
            participant.Chatroom = this;
        }
        else
        {
            Console.WriteLine("Participant {0} already added!", participant.UserName);
        }
    }

    public void RegisterRange(IEnumerable<Participant> participants)
    {
        foreach (var participant in participants)
        {
            Register(participant);
        }
    }

    public void Send(string from, string to, string message)
    {
        if (_participants.TryGetValue(to, out var participant))
        {
            participant.Receive(from, message);
        }
        else
        {
            Console.WriteLine("Participant {0} is not a member of this room", to);
        }
    }
}