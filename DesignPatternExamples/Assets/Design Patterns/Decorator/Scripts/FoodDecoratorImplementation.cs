using UnityEngine;

namespace Decorator
{
    [CreateAssetMenu(fileName = "Food", menuName = "Decorator/FoodDecorator")]
    public class FoodDecoratorImplementation : FoodDecorator
    {
        [SerializeField] private Sprite _icon;
        [SerializeField] private int _cost;
        [SerializeField] protected Food _FoodNeeded;
        [SerializeField] private Inventory inventory;

        public override Sprite Icon { get => _icon; set => _icon = value; }
        public override int Cost { get => _cost; set => _cost = value; }
        protected override Food Food { get => _FoodNeeded; set => _FoodNeeded = value; }
        public override InventoryObject InventoryObject { get; set; }

        public override int GetCost() => base.GetCost() + Cost;
        public override bool CheckAvailability(int coinAmount) => coinAmount >= _cost && inventory.Contains(Food);
    }
}