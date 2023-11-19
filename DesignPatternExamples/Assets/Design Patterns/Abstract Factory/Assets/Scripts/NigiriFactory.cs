using UnityEngine;

namespace AbstractFactory
{
    public class NigiriFactory : MonoBehaviour, IAbstractFactory
    {
        [SerializeField] private GameObject _nigiriPrefab;
        [SerializeField] private int _poolSize;
        [SerializeField] private Transform _sushiCreationPoint;
        private PoolSystem<GameObject> _poolSystem;
        public PoolSystem<GameObject> PoolSystem { get => _poolSystem; }

        private void Awake() => _poolSystem = new PoolSystem<GameObject>(_nigiriPrefab, _poolSize, transform);

        public ISushi CreateSushi()
        {
            GameObject sushi = PoolSystem.Get();
            Nigiri nigiri = sushi.GetComponent<Nigiri>();

            SetFactory(nigiri);
            return nigiri;
        }

        public void SetFactory(ISushi sushi) => sushi.Factory = this;
    }
}