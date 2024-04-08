using System.Collections.Generic;
using Library.GangOfFour.Creational.Builder.Enums;

namespace Library.GangOfFour.Creational.Builder;

public class Vehicle
{
    private readonly Dictionary<PartType, string> _parts = [];
    private readonly VehicleType _vehicleType;

    public Vehicle(VehicleType vehicleType)
    {
        _vehicleType = vehicleType;
    }

    public string this[PartType key]
    {
        get => _parts[key];
        set => _parts[key] = value;
    }

    public string Description => 
        @$"\n-----------------------
        Vehicle Type: {_vehicleType}
        Frame: {this[PartType.Frame]}
        Engine: {this[PartType.Engine]}
        Wheels: {this[PartType.Wheel]}
        Door: {this[PartType.Door]}";
}