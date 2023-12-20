using UnityEngine;

namespace Builder
{
    public interface ICharacterBuilder
    {
        void SetSprite(SpriteRenderer spriteRenderer);
        void SetName(CharacterID characterID);
        void SetGunType(GunType gunType);
        void SetAttackType(CharacterAttackType characterAttackType);
        void SetAttackDamage(CharacterID characterID);
        void SetAttackRange(CharacterID characterID);
        void CreateInPath(string _pathFolder);
    }
}
