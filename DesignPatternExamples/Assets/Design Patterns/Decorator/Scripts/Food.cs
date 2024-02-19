using UnityEngine;

namespace Decorator
{
    public abstract class Food : ScriptableObject
    {
        public virtual Sprite Icon { get; set; }
        public virtual int Cost { get; set; }
        public virtual int GetCost() => Cost;
        public virtual bool CheckAvailability(int coinAmount) => coinAmount >= Cost;
        public abstract InventoryObject InventoryObject { get; set; }
    }
}
