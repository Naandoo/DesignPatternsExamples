using UnityEngine;

namespace Facade
{
    public class FireGun : MonoBehaviour, IFireGun
    {
        [SerializeField] FireGunTemplate fireGunTemplate;
        [SerializeField] private WeaponProperties weaponProperties;

        public FireGunTemplate FireGunTemplate => fireGunTemplate;
        public WeaponProperties WeaponProperties => weaponProperties;

        public void Shoot()
        {
            throw new System.NotImplementedException();
        }

        public void Reload()
        {
            throw new System.NotImplementedException();
        }

        public void Aim()
        {
            throw new System.NotImplementedException();
        }




    }
}