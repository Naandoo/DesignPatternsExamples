using UnityEngine;

namespace Decorator
{
    [CreateAssetMenu(fileName = "Food", menuName = "Decorator/Food")]
    public class FoodImplementation : Food
    {
        [SerializeField] private Sprite _icon;
        [SerializeField] private string _name;
        [SerializeField] private double _cost;

        public override Sprite Icon { get => _icon; set => _icon = value; }
        public override string Name { get => _name; set => _name = value; }
        public override double Cost { get => _cost; set => _cost = value; }

        public override double GetCost() => Cost;
    }
}
