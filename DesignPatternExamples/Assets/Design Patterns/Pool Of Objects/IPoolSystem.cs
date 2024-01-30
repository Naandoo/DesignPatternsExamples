using UnityEngine;

public interface IPoolSystem<T> where T : Object
{
    T InstantiateItem();
    T Get(bool autoActive = true);
    void Return(T item);
}