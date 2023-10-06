public class BusHandler : AirportVehicleFactory
{
    public Bus _vehiclePrefab;

    public override Transport Create()
    {
        return _vehiclePrefab;
    }
}