using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using ScriptableVariable;

namespace Decorator
{
    public class InventoryObject : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private Image _icon;
        [SerializeField] private TMP_Text _cost;
        [SerializeField] private float _increaseCostPercentage = 1.35f;
        [SerializeField] private Inventory _inventory;
        [SerializeField] private IntVariable _moneyAmount;
        private Food _food;
        private int _costToSell;
        public void InitObject(Food food)
        {
            _food = food;
            _icon.sprite = food.Icon;

            _costToSell = (int)(food.Cost * _increaseCostPercentage);
            _cost.text = _costToSell.ToString();
        }

        public void OnPointerDown(PointerEventData eventData) => SellFood(this);

        private void SellFood(InventoryObject inventoryObject)
        {
            _inventory.InventoryRemove(_food, inventoryObject);
            _moneyAmount.Value += _costToSell;
        }

    }
}