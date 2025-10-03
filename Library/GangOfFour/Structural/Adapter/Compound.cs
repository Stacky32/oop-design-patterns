namespace Library.GangOfFour.Structural.Adapter;

public class Compound
{
    public Chemical Chemical { get; protected set; }
    public float BoilingPoint { get; protected set; }
    public float MeltingPoint { get; protected set; }
    public double MolecularWeight { get; protected set; }
    public string? MolecularFormula { get; protected set; }

    public override string ToString()
    {
        return $"Unknown Compound";
    }
}