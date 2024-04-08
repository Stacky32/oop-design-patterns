using Library.GangOfFour.Creational.Builder.Enums;

namespace Library.GangOfFour.Creational.Builder.Builders;

public class CarBuilder : VehicleBuilder
{
    public CarBuilder() : base(VehicleType.Car) {}

    public override void BuildFrame()
    {
        Vehicle[PartType.Frame] = "Car frame";
    }

    public override void BuildEngine()
    {
        Vehicle[PartType.Engine] = "3.2l";
    }

    public override void BuildWheels()
    {
        Vehicle[PartType.Wheel] = "4";
    }

    public override void BuildDoors()
    {
        Vehicle[PartType.Door] = "2";
    }
}