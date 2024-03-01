using UnityEngine;

namespace Decorator
{
    [CreateAssetMenu(fileName = "Food", menuName = "Decorator/Food")]
    public class FoodImplementation : Food
    {
        [SerializeField] private Sprite _icon;
        [SerializeField] private int _cost;

        public override Sprite Icon { get => _icon; set => _icon = value; }
        public override int Cost { get => _cost; set => _cost = value; }

        public override InventoryObject InventoryObject { get; set; }
    }
}
