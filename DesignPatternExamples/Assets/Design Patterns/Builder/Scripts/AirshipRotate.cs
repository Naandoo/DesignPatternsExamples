using UnityEngine;

namespace Builder
{
    public class AirshipRotate : MonoBehaviour
    {
        private void Update()
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 50f);
        }
    }
}
