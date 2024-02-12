using ScriptableVariable;
using UnityEngine;

namespace Composite
{
    [CreateAssetMenu(fileName = "Coins", menuName = "Design Patterns/Composite/Scriptable/Coins")]
    public class Coins : ScriptableObject, ILoot
    {
        [SerializeField] private int _value;
        [SerializeField] private IntVariable _playerCoins;
        public int Value => _value;

        public int Reclaim()
        {
            _playerCoins.Add(_value);
            return _value;
        }
    }
}