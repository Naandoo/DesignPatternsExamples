using UnityEngine;

namespace Decorator
{
    [CreateAssetMenu(fileName = "Food", menuName = "Decorator/FoodDecorator")]
    public class FoodDecoratorImplementation : FoodDecorator
    {
        [SerializeField] private Sprite _icon;
        [SerializeField] private int _cost;
        [SerializeField] protected Food _Food;
        [SerializeField] private Inventory inventory;
        [SerializeField] private InventoryObject _inventoryObject;
        protected override Food Food { get => _Food; set => _Food = value; }

        public override Sprite Icon { get => _icon; set => _icon = value; }
        public override int Cost { get => _cost; set => _cost = value; }
        public override InventoryObject InventoryObject { get => _inventoryObject; set => _inventoryObject = value; }
        public override int GetCost() => base.GetCost() + Cost;
        public override bool CheckAvailability(int coinAmount) => coinAmount >= _cost && inventory.Contains(Food);
    }
}