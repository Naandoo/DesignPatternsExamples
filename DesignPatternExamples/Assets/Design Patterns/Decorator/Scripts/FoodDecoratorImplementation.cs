using UnityEngine;

namespace Decorator
{
    [CreateAssetMenu(fileName = "Food", menuName = "Decorator/FoodDecorator")]
    public class FoodDecoratorImplementation : FoodDecorator
    {
        [SerializeField] private Sprite _icon;
        [SerializeField] private string _name;
        [SerializeField] private double _cost;
        [SerializeField] protected Food _Food;

        public override Sprite Icon { get => _icon; set => _icon = value; }
        public override string Name { get => _name; set => _name = value; }
        public override double Cost { get => _cost; set => _cost = value; }
        protected override Food _food { get => _Food; set => _Food = value; }

        public override double GetCost() => base.GetCost() + Cost;
    }
}