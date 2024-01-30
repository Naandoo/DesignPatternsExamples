using UnityEngine;

namespace AbstractFactory
{
    public class MakiFactory : AbstractFactory
    {
        private void Awake() => PoolSystem = new PoolSystem<GameObject>(_sushiPrefab, _poolSize, transform);
    }
}