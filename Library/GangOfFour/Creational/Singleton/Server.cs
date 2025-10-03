namespace Library.GangOfFour.Creational.Singleton;

public record Server(string Name, string Ip)
{
    public override string ToString() => $"{Name} ({Ip})";
}