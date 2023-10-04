using UnityEngine;

public abstract class AirportVehicleFactory<T> : MonoBehaviour where T : Transport
{
    public abstract T Create();
}







