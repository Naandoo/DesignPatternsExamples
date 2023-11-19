using UnityEngine;

namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        ISushi CreateSushi();
        void SetFactory(ISushi sushi);
        PoolSystem<GameObject> PoolSystem { get; }
    }
}
