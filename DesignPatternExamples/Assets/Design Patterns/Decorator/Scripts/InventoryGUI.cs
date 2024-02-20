using UnityEngine;

namespace Decorator
{
    public class InventoryGUI : MonoBehaviour
    {
        [SerializeField] private InventoryObject _inventoryObject;
        [SerializeField] private Transform _inventoryParent;
        [SerializeField] private Inventory _inventory;
        private PoolSystem<InventoryObject> _inventoryObjectsPool;
        private int _inventorySize = 20;

        private void Start()
        {
            _inventoryObjectsPool = new PoolSystem<InventoryObject>(_inventoryObject, _inventorySize, _inventoryParent);
            _inventory.SetInventoryGUI(this);
        }

        public void Add(Food food)
        {
            InventoryObject newInventoryObject = _inventoryObjectsPool.Get();
            food.InventoryObject = newInventoryObject;
            newInventoryObject.InitObject(food);
        }

        public void Remove(Food food)
        {
            InventoryObject inventoryObject = food.InventoryObject;
            _inventoryObjectsPool.Return(inventoryObject);
        }
    }
}