using UnityEngine;
using ScriptableVariable;

namespace Decorator
{
    public class FoodStore : MonoBehaviour
    {
        [SerializeField] FoodGUI _foodGUI;
        [SerializeField] private IntVariable _moneyAmount;
        [SerializeField] private Inventory _inventory;
        public Food Food;

        private void OnEnable()
        {
            _foodGUI.UpdateGUI();
            _moneyAmount.OnValueChanged += CheckObjectInteraction;
            _inventory.OnInventoryChanged += CheckFoodAvailability;
        }

        private void OnDisable()
        {
            _moneyAmount.OnValueChanged -= CheckObjectInteraction;
            _inventory.OnInventoryChanged -= CheckFoodAvailability;
        }

        private void CheckObjectInteraction(int moneyAmount)
        {
            if (moneyAmount >= Food.Cost) CheckFoodAvailability();
        }

        private void CheckFoodAvailability()
        {
            _foodGUI.ToggleObjectInteraction(value: Food.CheckAvailability(_moneyAmount.Value));
        }
    }
}
