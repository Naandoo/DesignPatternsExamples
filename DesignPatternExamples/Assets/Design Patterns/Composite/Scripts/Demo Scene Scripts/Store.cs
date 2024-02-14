using ScriptableVariable;
using UnityEngine;

namespace Composite
{
    [CreateAssetMenu(fileName = "Store", menuName = "Design Patterns/Composite/Scriptable/Store")]
    public class Store : ScriptableObject
    {
        [SerializeField] private IntVariable _currentCoins;
        [SerializeField] private IntVariable _currentAmountOfChests;
        [SerializeField] private IntVariable _currentStrengthAmount;
        [SerializeField] private IntVariable _currentSpeedAmount;
        [SerializeField] private IntVariable _currentHealthAmount;
        [SerializeField] private IntVariable _currentShieldAmount;
        [SerializeField] private IntVariable _upgradeStatusCost;
        [SerializeField] private IntVariable _chestCost;

        public void BuyChest() => Purchase(_chestCost, _currentAmountOfChests);
        public void UpgradeAttackDamage() => Purchase(_upgradeStatusCost, _currentStrengthAmount);
        public void UpgradeSpeed() => Purchase(_upgradeStatusCost, _currentSpeedAmount);
        public void UpgradeHealth() => Purchase(_upgradeStatusCost, _currentHealthAmount);
        public void UpgradeShield() => Purchase(_upgradeStatusCost, _currentShieldAmount);

        private void Purchase(IntVariable cost, IntVariable item)
        {
            if (_currentCoins.Value >= cost.Value)
            {
                _currentCoins.Value -= cost.Value;
                item.Value++;
            }
        }
    }
}
