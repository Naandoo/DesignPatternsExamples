using UnityEngine;

namespace Factory
{
    public abstract class AirportVehicleFactory : MonoBehaviour, IAirportVehicleFactory<Transport>
    {
        public abstract Transport Create();
    }
}


