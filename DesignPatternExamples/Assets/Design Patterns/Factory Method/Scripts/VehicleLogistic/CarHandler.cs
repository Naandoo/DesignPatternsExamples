public class CarHandler : AirportVehicleFactory<Car>
{
    public Car _vehiclePrefab;

    public override Car Create()
    {
        return _vehiclePrefab;
    }
}
