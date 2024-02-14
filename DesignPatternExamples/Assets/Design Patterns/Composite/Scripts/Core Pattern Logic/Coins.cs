using ScriptableVariable;
using UnityEngine;

namespace Composite
{
    [CreateAssetMenu(fileName = "Coins", menuName = "Design Patterns/Composite/Scriptable/Coins")]
    public class Coins : ILoot
    {
        [SerializeField] private int _value;
        public int Value => _value;

        public override int Reclaim()
        {
            return Value;
        }
    }
}