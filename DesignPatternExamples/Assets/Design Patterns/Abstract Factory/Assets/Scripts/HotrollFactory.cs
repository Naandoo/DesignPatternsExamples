using UnityEngine;

namespace AbstractFactory
{
    public class HotrollFactory : AbstractFactory
    {
        private void Awake() => _poolSystem = new PoolSystem<GameObject>(_hotrollPrefab, _poolSize, transform);
    }


}