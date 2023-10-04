public class AirplaneHandler : AirportVehicleFactory<Airplane>
{
    public Airplane _vehiclePrefab;

    public override Airplane Create()
    {
        return _vehiclePrefab;
    }
}
