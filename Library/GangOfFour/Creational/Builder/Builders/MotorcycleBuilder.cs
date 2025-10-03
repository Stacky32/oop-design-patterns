using Library.GangOfFour.Creational.Builder.Enums;

namespace Library.GangOfFour.Creational.Builder.Builders;

public class MotorcycleBuilder : VehicleBuilder
{
    public MotorcycleBuilder() : base(VehicleType.Motorcycle) {}

    public override void BuildFrame()
    {
        Vehicle[PartType.Frame] = "Motorcycle frame";
    }

    public override void BuildEngine()
    {
        Vehicle[PartType.Engine] = "500cc";
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