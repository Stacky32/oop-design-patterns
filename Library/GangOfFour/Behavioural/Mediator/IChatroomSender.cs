namespace Library.GangOfFour.Behavioural.Mediator;

public interface IChatroomSender
{
    void Send(string from, string to, string message);
}