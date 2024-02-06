using UnityEngine;
using Cinemachine;

namespace Bridge
{
    public class CinemachineCameraController : MonoBehaviour
    {
        [SerializeField] private CinemachineVirtualCamera _cinemachineCamera;

        public void SetTarget(Transform target) => _cinemachineCamera.Follow = target;
    }
}
