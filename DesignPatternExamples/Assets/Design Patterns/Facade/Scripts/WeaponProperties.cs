using UnityEngine;

namespace Facade
{
    [CreateAssetMenu(fileName = "WeaponProperties", menuName = "Design Patterns/Facade/WeaponProperties")]
    public class WeaponProperties : MonoBehaviour
    {
        [SerializeField] private GameObject weaponPrefab;
        [SerializeField] private Transform bulletSpawnPoint;
    }
}