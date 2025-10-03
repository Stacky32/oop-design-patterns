using Library.GangOfFour.Creational.Builder.Enums;

namespace Library.GangOfFour.Creational.Builder.Builders;

public class ScooterBuilder : VehicleBuilder
{
    public ScooterBuilder() : base(VehicleType.Scooter) {}

    public override void BuildFrame()
    {
        Vehicle[PartType.Frame] = "Scooter frame";
    }

    public override void BuildEngine()
    {
        Vehicle[PartType.Engine] = "electric";
    }

    public override void BuildWheels()
    {
        Vehicle[PartType.Wheel] = "2";
    }

    public override void BuildDoors()
    {
        Vehicle[PartType.Door] = "0";
    }
}