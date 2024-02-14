using UnityEngine;
namespace Composite
{
    public abstract class ILoot : ScriptableObject
    {
        abstract public int Reclaim();
    }
}
