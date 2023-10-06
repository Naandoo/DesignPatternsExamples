public class HelicopterHandler : AirportVehicleFactory
{
    public Helicopter _vehiclePrefab;

    public override Transport Create()
    {
        return _vehiclePrefab;
    }
}
