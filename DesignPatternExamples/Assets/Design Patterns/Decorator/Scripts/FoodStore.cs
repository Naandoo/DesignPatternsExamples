using UnityEngine;
using ScriptableVariable;
using UnityEngine.EventSystems;

namespace Decorator
{
    public class FoodStore : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] FoodGUI _foodGUI;
        [SerializeField] private IntVariable _moneyAmount;
        [SerializeField] private Inventory _inventory;
        public Food Food;

        private void OnEnable()
        {
            _moneyAmount.OnValueChanged += CheckIfObjectIsPurchasable;
            _inventory.OnInventoryChanged += CheckFoodAvailability;

            _foodGUI.UpdateGUI();
            CheckFoodAvailability();
        }

        private void OnDisable()
        {
            _moneyAmount.OnValueChanged -= CheckIfObjectIsPurchasable;
            _inventory.OnInventoryChanged -= CheckFoodAvailability;
        }

        private void CheckIfObjectIsPurchasable(int moneyAmount)
        {
            if (moneyAmount >= Food.Cost) CheckFoodAvailability();
        }

        private void CheckFoodAvailability()
        {
            _foodGUI.ToggleObjectInteraction(value: Food.CheckAvailability(coinAmount: _moneyAmount.Value));
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            _foodGUI.ClickedObjectAnimation();
            OnFoodButtonClicked();
        }

        public void OnFoodButtonClicked()
        {
            _moneyAmount.Value -= (int)Food.Cost;
            _inventory.InventoryAdd(Food);
        }
    }
}
