using UnityEngine;

public interface IPoolableObject<T> where T : Object
{
    void SetPool(IPoolSystem<T> poolSystem);
}