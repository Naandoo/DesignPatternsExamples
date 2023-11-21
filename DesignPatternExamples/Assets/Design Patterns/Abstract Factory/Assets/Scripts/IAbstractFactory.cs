using UnityEngine;

namespace AbstractFactory
{
    public abstract class AbstractFactory : MonoBehaviour
    {
        public GameObject _hotrollPrefab;
        public int _poolSize;
        public Transform _sushiCreationPoint;
        public PoolSystem<GameObject> _poolSystem;
        public PoolSystem<GameObject> PoolSystem { get => _poolSystem; }

        public void CreateSushi()
        {
            GameObject sushi = PoolSystem.Get();
            sushi.transform.localPosition = _sushiCreationPoint.position;

            ISushi iSushi = sushi.GetComponent<ISushi>();

            SetFactory(iSushi);
        }

        public void SetFactory(ISushi sushi) => sushi.Factory = this;
    }
}
