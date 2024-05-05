namespace Library.GangOfFour.Behavioural.Memento;

public class SalesProspect : IMementoOriginator<SalesProspect>
{
    public string Name { get; set; } = string.Empty;
    
    public string Email { get; set; } = string.Empty;
    
    public double Budget { get; set; }

    public bool RestoreMemento(Memento<SalesProspect> memento)
    {
        var restored = memento.Deserialize();

        if (restored is null) return false;

        Name = restored.Name;
        Email = restored.Email;
        Budget = restored.Budget;

        return true;
    }

    public Memento<SalesProspect> SaveMemento()
    {
        var memento = new Memento<SalesProspect>();
        return memento.Serialize(this);
    }

    public override string ToString()
    {
        return $"Name: {Name}\nEmail: {Email}\n Budget: {Budget}\n";
    }
}