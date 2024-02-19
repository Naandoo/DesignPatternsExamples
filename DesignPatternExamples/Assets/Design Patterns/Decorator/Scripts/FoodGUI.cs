using UnityEngine;
using UnityEngine.UI;
using ScriptableVariable;

namespace Decorator
{
    public class FoodGUI : MonoBehaviour
    {
        [SerializeField] private FoodStore _foodStore;
        [SerializeField] private Image _foodIcon;
        [SerializeField] private Text _foodPrice;
        [SerializeField] private Selectable _foodButton;
        [SerializeField] private IntVariable _moneyAmount;
        [SerializeField] private Inventory _inventory;

        public void UpdateGUI()
        {
            _foodIcon.sprite = _foodStore.Food.Icon;
            _foodPrice.text = _foodStore.Food.Cost.ToString();
        }

        public void ToggleObjectInteraction(bool value) => _foodButton.interactable = value;

        public void OnFoodButtonClicked()
        {
            if (_foodStore.Food.CheckAvailability(_moneyAmount.Value))
            {
                _moneyAmount.Value -= (int)_foodStore.Food.Cost;
                _inventory.Add(_foodStore.Food.InventoryObject);
            }
        }
    }
}