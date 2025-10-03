namespace Library.GangOfFour.Behavioural.Observer;

public interface IInvestor
{
    void Update(object? sender, ChangeEventArgs e);
}