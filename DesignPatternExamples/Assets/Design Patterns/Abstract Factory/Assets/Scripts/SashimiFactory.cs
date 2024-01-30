using UnityEngine;

namespace AbstractFactory
{
    public class SashimiFactory : AbstractFactory
    {
        private void Awake() => PoolSystem = new PoolSystem<GameObject>(_sushiPrefab, _poolSize, transform);
    }
}