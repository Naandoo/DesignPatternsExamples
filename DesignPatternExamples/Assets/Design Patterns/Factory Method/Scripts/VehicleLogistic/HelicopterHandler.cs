public class HelicopterHandler : AirportLogistic
{
    public override ITransport HandleVehicle()
    {
        ITransport vehicleInstance = base.GetVehicle();
        return vehicleInstance;
    }
}
