using UnityEngine;
using System.Collections.Generic;
using System;

namespace Decorator
{
    [CreateAssetMenu(fileName = "Inventory", menuName = "Decorator/Inventory")]
    public class Inventory : ScriptableObject
    {
        private InventoryGUI _inventoryGUI;
        private Dictionary<Food, int> _inventoryFoods = new();
        public event Action OnInventoryChanged;

        public void SetInventoryGUI(InventoryGUI inventoryGUI) => _inventoryGUI = inventoryGUI;

        public void InventoryAdd(Food food)
        {
            if (_inventoryFoods.ContainsKey(food)) _inventoryFoods[food]++;
            else _inventoryFoods.Add(food, 1);

            _inventoryGUI.Add(food);
            OnInventoryChanged?.Invoke();
        }

        public void InventoryRemove(Food food)
        {
            if (Contains(food))
            {
                if (_inventoryFoods[food] >= 1) _inventoryFoods[food]--;
                if (_inventoryFoods[food] == 0) _inventoryFoods.Remove(food);

                _inventoryGUI.Remove(food);
                OnInventoryChanged?.Invoke();
            }
        }

        public bool Contains(Food food) => _inventoryFoods.ContainsKey(food);
    }
}