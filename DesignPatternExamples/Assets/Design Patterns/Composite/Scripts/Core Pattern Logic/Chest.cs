using UnityEngine;
using System.Collections.Generic;
using System;
using System.Linq;
using ScriptableVariable;

namespace Composite
{
    [CreateAssetMenu(fileName = "Chest", menuName = "Design Patterns/Composite/Scriptable/Chest")]
    public class Chest : ILoot
    {
        [SerializeField] private List<ILoot> _loot;
        [SerializeField] private IntVariable _totalCoins;

        public void AddLoot(ILoot loot) => _loot.Add(loot);
        public void RemoveLoot(ILoot loot) => _loot.Remove(loot);

        private int _coinsFound;

        public int CoinsFound { get => _coinsFound; set => _coinsFound = value; }

        public override int Reclaim()
        {
            int totalLoot = 0;

            foreach (ILoot loot in _loot)
            {
                totalLoot += loot.Reclaim();

                if (loot is Coins Coins)
                {
                    CoinsFound += Coins.Value;
                    _totalCoins.Value += Coins.Value;
                }
            }
            return totalLoot;
        }
    }
}