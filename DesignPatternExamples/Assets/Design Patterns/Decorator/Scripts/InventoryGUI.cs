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

        public void AddInventoryObject(Food food)
        {
            InventoryObject inventoryObject = _inventoryObjectsPool.Get();
            inventoryObject.SetObject(food);
        }

        public void RemoveInventoryObject(InventoryObject inventoryObject)
        {
            _inventoryObjectsPool.Return(inventoryObject);
        }
    }
}