public class AirplaneHandler : AirportVehicleFactory
{
    public Airplane _vehiclePrefab;

    public override Transport Create()
    {
        return _vehiclePrefab;
    }
}
