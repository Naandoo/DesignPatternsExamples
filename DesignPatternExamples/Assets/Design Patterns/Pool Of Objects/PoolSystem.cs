using UnityEngine;
using System.Collections.Generic;

public class PoolSystem<T> : IPoolSystem<T> where T : Object
{
    private readonly Queue<T> _pool = new();
    private readonly T _prefab;
    private readonly Transform _parent;

    public PoolSystem(T prefab, int initialSize, Transform parent)
    {
        _prefab = prefab;
        _parent = parent;

        for (int i = 0; i < initialSize; i++)
        {
            _pool.Enqueue(InstantiateItem());
        }
    }

    public T InstantiateItem()
    {
        T item = Object.Instantiate(_prefab, _parent);
        SetActive(item, false);
        return item;
    }

    private static void SetActive(T item, bool active)
    {
        switch (item)
        {
            case MonoBehaviour behaviour:
                behaviour.gameObject.SetActive(active);
                break;
            case GameObject gameObject:
                gameObject.SetActive(active);
                break;
        }
    }

    public T Get(bool autoActive = true)
    {
        if (_pool.Count == 0)
        {
            T item = InstantiateItem();
            if (autoActive) SetActive(item, true);
            return item;
        }

        T poolItem = _pool.Dequeue();
        if (autoActive) SetActive(poolItem, true);
        return poolItem;
    }

    public void Return(T item)
    {
        if (_pool.Contains(item)) return;
        SetActive(item, false);
        _pool.Enqueue(item);
    }
}
