using UnityEngine;

namespace Decorator
{
    public abstract class FoodDecorator : Food
    {
        abstract protected Food _food { get; set; }
    }
}