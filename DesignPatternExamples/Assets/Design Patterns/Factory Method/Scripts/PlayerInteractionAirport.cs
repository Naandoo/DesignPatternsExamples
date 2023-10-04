using UnityEngine;

public class PlayerInteractionAirport : MonoBehaviour
{
    [SerializeField] private BusHandler _busHandler;
    [SerializeField] private CarHandler _carHandler;
    [SerializeField] private HelicopterHandler _helicopterHandler;
    [SerializeField] private AirplaneHandler _airplaneHandler;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootMouseRaycast();
        }
    }

    private void ShootMouseRaycast()
    {

    }
}
