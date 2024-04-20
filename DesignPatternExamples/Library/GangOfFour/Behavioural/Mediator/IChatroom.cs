using System.Collections.Generic;

namespace Library.GangOfFour.Behavioural.Mediator;

public interface IChatroom : IChatroomSender
{
    void Register(Participant participant);
    void RegisterRange(IEnumerable<Participant> participant);
}