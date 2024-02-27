using System;
using UnityEngine;

namespace Facade
{
    [CreateAssetMenu(fileName = "FireGunTemplate", menuName = "Design Patterns/Facade/FireGunTemplate")]
    public class FireGunTemplate : ScriptableObject
    {
        public float BulletPerSecond;
        public Projectile Projectile;
        public Cartridge Cartridge;
        public float ReloadSpeed;
        public float ZoomAmount;
        public Sprite WeaponIcon;
    }

    [Serializable]
    public class Projectile
    {
        public float Speed;
        public float DropRate;
        public float Damage;
    }

    [Serializable]
    public class Cartridge
    {
        public int MaximumAvailability;
        public int BulletsCapacity;
    }
}


