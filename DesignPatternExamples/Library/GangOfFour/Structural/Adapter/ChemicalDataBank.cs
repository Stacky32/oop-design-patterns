using System.Security.Cryptography;

namespace Library.GangOfFour.Structural.Adapter;

public class ChemicalDataBank
{
    public float GetCriticalPoint(Chemical compound, State point)
    {
        return point switch
        {
            State.Boiling => compound switch
            {
                Chemical.Water => 100.0f,
                Chemical.Benzene => 80.1f,
                Chemical.Ethanol => 78.3f,
                _ => 0f,
            },
            State.Melting => compound switch
            {
                Chemical.Water => 0.0f,
                Chemical.Benzene => 5.5f,
                Chemical.Ethanol => -114.1f,
                _ => 0f,
            },
            _ => 0f,
        };
    }

    public string GetMolecularFormula(Chemical compound)
    {
        return compound switch
        {
            Chemical.Water => "H2O",
            Chemical.Benzene => "C6H6",
            Chemical.Ethanol => "C2H5OH",
            _ => string.Empty,
        };
    }

    public double GetMolecularWeight(Chemical compound)
    {
        return compound switch
        {
            Chemical.Water => 18.015d,
            Chemical.Benzene => 78.1134d,
            Chemical.Ethanol => 46.0688d,
            _ => 0d,
        };
    }
}