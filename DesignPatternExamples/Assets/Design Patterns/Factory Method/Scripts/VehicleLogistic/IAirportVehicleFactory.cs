namespace Factory
{
    public interface IAirportVehicleFactory<T> where T : Transport
    {
        T Create();
    }
}