public class BusHandler : AirportVehicleFactory<Bus>
{
    public Bus _vehiclePrefab;

    public override Bus Create()
    {
        return _vehiclePrefab;
    }
}