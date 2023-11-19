using UnityEngine;

namespace AbstractFactory
{
    public class SashimiFactory : MonoBehaviour, IAbstractFactory
    {
        [SerializeField] private GameObject _sashimiPrefab;
        [SerializeField] private int _poolSize;
        [SerializeField] private Transform _sushiCreationPoint;
        private PoolSystem<GameObject> _poolSystem;
        public PoolSystem<GameObject> PoolSystem { get => _poolSystem; }

        private void Awake() => _poolSystem = new PoolSystem<GameObject>(_sashimiPrefab, _poolSize, transform);

        public ISushi CreateSushi()
        {
            GameObject sushi = PoolSystem.Get();
            Sashimi sashimi = sushi.GetComponent<Sashimi>();

            SetFactory(sashimi);
            return sashimi;
        }

        public void SetFactory(ISushi sushi) => sushi.Factory = this;
    }
}