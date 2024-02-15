using UnityEngine;

namespace Decorator
{
    public abstract class Food : ScriptableObject
    {
        public virtual Sprite Icon { get; set; }
        public virtual string Name { get; set; }
        public virtual double Cost { get; set; }
        public virtual double GetCost() => Cost;
    }
}
