using UnityEngine;

namespace Facade
{
    public interface IFireGun
    {
        FireGunTemplate FireGunTemplate { get; }
        WeaponProperties WeaponProperties { get; }
        void Shoot();
        void Reload();
        void Aim();
    }
}