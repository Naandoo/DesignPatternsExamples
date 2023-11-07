namespace Factory
{
    public class CarHandler : AirportVehicleFactory
    {
        public Car _vehiclePrefab;

        public override Transport Create()
        {
            return _vehiclePrefab;
        }
    }
}
