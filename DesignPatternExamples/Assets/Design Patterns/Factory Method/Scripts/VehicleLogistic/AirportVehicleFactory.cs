using UnityEngine;

public abstract class AirportVehicleFactory : MonoBehaviour, IAirportVehicleFactory<Transport>
{
    public abstract Transport Create();
}

