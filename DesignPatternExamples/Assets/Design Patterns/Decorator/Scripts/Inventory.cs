using UnityEngine;
using System.Collections.Generic;
using System;

namespace Decorator
{
    [CreateAssetMenu(fileName = "Inventory", menuName = "Decorator/Inventory")]
    public class Inventory : ScriptableObject
    {
        private InventoryGUI _inventoryGUI;
        private Dictionary<Food, int> _foodInventory = new();
        public event Action OnInventoryChanged;

        public void SetInventoryGUI(InventoryGUI inventoryGUI) => _inventoryGUI = inventoryGUI;
        public void Add(InventoryObject inventoryObject)
        {
            Food food = inventoryObject.Food;
            if (_foodInventory.ContainsKey(food)) _foodInventory[food]++;
            else _foodInventory.Add(food, 1);

            _inventoryGUI.AddInventoryObject(food);
            OnInventoryChanged?.Invoke();
        }

        public void Remove(InventoryObject inventoryObject)
        {
            Food food = inventoryObject.Food;
            if (_foodInventory.ContainsKey(food))
            {
                _foodInventory[food]--;
                if (_foodInventory[food] <= 0) _foodInventory.Remove(food);
            }

            _inventoryGUI.RemoveInventoryObject(inventoryObject);
            OnInventoryChanged?.Invoke();
        }

        public bool Contains(Food food) => _foodInventory.ContainsKey(food);
    }
}