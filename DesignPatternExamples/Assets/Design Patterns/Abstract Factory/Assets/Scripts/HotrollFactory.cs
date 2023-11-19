using UnityEngine;

namespace AbstractFactory
{
    public class HotrollFactory : MonoBehaviour, IAbstractFactory
    {
        [SerializeField] private GameObject _hotrollPrefab;
        [SerializeField] private int _poolSize;
        [SerializeField] private Transform _sushiCreationPoint;
        private PoolSystem<GameObject> _poolSystem;
        public PoolSystem<GameObject> PoolSystem { get => _poolSystem; }

        private void Awake() => _poolSystem = new PoolSystem<GameObject>(_hotrollPrefab, _poolSize, transform);

        public ISushi CreateSushi()
        {
            GameObject sushi = PoolSystem.Get();
            Hotroll hotroll = sushi.GetComponent<Hotroll>();

            SetFactory(hotroll);
            return hotroll;
        }

        public void SetFactory(ISushi sushi) => sushi.Factory = this;
    }
}