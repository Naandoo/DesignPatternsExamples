using UnityEngine;

namespace Builder
{
    [CreateAssetMenu(fileName = "CharacterBuilder", menuName = "Builder/CharacterBuilder", order = 1)]
    public class CharacterBuilder : ScriptableObject//, ICharacterBuilder
    {
        public Sprite _sprite;
        public string _name;
        public GunType _gunType;
        public IAttackType _attackType;
        public int _attackDamage;
        public float _attackRange;
        public string _pathFolder;
    }
}