using UnityEngine;

public class PlayerInteractionAirport : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootMouseRaycast();
        }
    }

    private void ShootMouseRaycast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray))
        {
            if (TryGetComponent(out AirportLogistic airportLogistic))
            {
                airportLogistic.GetVehicle();
            }
            else if (TryGetComponent(out ITransport transport))
            {
                transport.Travel();
            }
        }
    }
}
