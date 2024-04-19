namespace Library.GangOfFour.Structural.Adapter;

public class CompoundAdapter : Compound
{
    private readonly ChemicalDataBank _bank = new();

    public CompoundAdapter(Chemical chemical)
    {
        Chemical = chemical;
    }

    public void Analyse()
    {
        BoilingPoint = _bank.GetCriticalPoint(Chemical, State.Boiling);
        MeltingPoint = _bank.GetCriticalPoint(Chemical, State.Melting);
        MolecularWeight = _bank.GetMolecularWeight(Chemical);
        MolecularFormula = _bank.GetMolecularFormula(Chemical);
    }

    public override string ToString()
    {
        return $@"
            \nCompound:
              Formula: {MolecularFormula}
              Weight: {MolecularWeight}
              Melting Point {MeltingPoint}
              Boiling Point {BoilingPoint}\n";
    }
}