public class HelicopterHandler : AirportVehicleFactory<Helicopter>
{
    public Helicopter _vehiclePrefab;

    public override Helicopter Create()
    {
        return _vehiclePrefab;
    }
}
