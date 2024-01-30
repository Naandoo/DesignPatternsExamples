using UnityEngine;

namespace AbstractFactory
{
    public class PlayerInput : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    Sushi sushi = hit.collider.GetComponentInParent<Sushi>();
                    if (sushi != null) sushi.Eat();
                }
            }
        }
    }
}