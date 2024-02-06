using UnityEngine;

namespace Factory
{

    public class PlayerInteractionAirport : MonoBehaviour
    {
        [SerializeField] private AirportSpotsHandler _airportSpotsHandler;

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
            Collider collider = Physics.Raycast(ray, out RaycastHit hit) ? hit.collider : null;


            if (collider == null) return;
            InteractWithCollidedObject(collider);
        }

        public void InteractWithCollidedObject(Collider collider)
        {
            if (collider.TryGetComponent(out AirportVehicleFactory airportVehicleFactory))
            {
                Transport transport = airportVehicleFactory.Create();
                Vector3 transportPosition = _airportSpotsHandler.GetAvailablePosition(transport);

                if (transportPosition == default) return;
                Instantiate(transport, transportPosition, transport.transform.rotation);
            }

            else if (collider.TryGetComponent(out Transport transport))
            {
                transport.Travel();
            }
        }


    }
}
