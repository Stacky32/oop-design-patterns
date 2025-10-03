using Library.GangOfFour.Creational.Builder.Builders;

namespace Library.GangOfFour.Creational.Builder;

public class Shop
{
    private VehicleBuilder? _vehicleBuilder;

    public void Construct(VehicleBuilder vehicleBuilder)
    {
        _vehicleBuilder = vehicleBuilder;

        _vehicleBuilder.BuildFrame();
        _vehicleBuilder.BuildEngine();
        _vehicleBuilder.BuildWheels();
        _vehicleBuilder.BuildDoors();
    }

    public string? ShowVehicle()
    {
        return _vehicleBuilder?.Vehicle.Description;
    }
}