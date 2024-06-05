using UnityEngine;

namespace Decorator
{
    public abstract class FoodDecorator : Food
    {
        abstract protected Food Food { get; set; }
    }
}