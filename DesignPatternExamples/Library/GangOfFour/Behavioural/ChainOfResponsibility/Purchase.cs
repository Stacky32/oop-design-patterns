namespace Library.GangOfFour.Behavioural.ChainOfResponsibility;

public record Purchase
{
    public required double Amount { get; init; }
    public required string Purpose { get; init; }
    public required int Number { get; init; }
}