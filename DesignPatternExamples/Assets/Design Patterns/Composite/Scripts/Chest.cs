using UnityEngine;
using System.Collections.Generic;
using ScriptableVariable;

namespace Composite
{
    [CreateAssetMenu(fileName = "Chest", menuName = "Design Patterns/Composite/Scriptable/Chest")]
    public class Chest : ScriptableObject, ILoot
    {
        [SerializeField] private List<ILoot> _loot;
        [SerializeField] private IntVariable _animationTime;

        public void Add(ILoot loot) => _loot.Add(loot);
        public void Remove(ILoot loot) => _loot.Remove(loot);
        public int Reclaim()
        {
            int totalLoot = 0;
            foreach (ILoot loot in _loot)
            {
                totalLoot += loot.Reclaim();
            }
            return totalLoot;
        }
    }
}