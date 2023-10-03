using System.Collections.Generic;
using UnityEngine;

public abstract class AirportLogistic : MonoBehaviour
{
    public GameObject _vehiclePrefab;
    public List<GameObject> _vehiclePositions;
    public abstract ITransport HandleVehicle();

    public ITransport GetVehicle()
    {
        Vector3 availablePosition = CheckTransportSpots(_vehiclePositions);

        if (availablePosition != Vector3.zero)
        {
            GameObject vehicleObject = Instantiate(_vehiclePrefab, availablePosition, Quaternion.identity);
            ITransport vehicleInstance = vehicleObject.GetComponent<ITransport>();

            return vehicleInstance;
        }

        return null;
    }

    public Vector3 CheckTransportSpots(List<GameObject> spots)
    {
        if (spots == null || spots.Count == 0)
        {
            Debug.LogError("No spots found");
            return Vector3.zero;
        }
        else
        {
            Vector3 availableSpot = spots[0].transform.position;
            spots.RemoveAt(0);

            return availableSpot;
        }
    }
}

public interface ITransport
{
    void Travel();
}



