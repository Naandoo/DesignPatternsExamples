using UnityEngine;

namespace AbstractFactory
{
    public class MakiFactory : MonoBehaviour, IAbstractFactory
    {
        [SerializeField] private GameObject _makiPrefab;
        [SerializeField] private int _poolSize;
        [SerializeField] private Transform _sushiCreationPoint;
        private PoolSystem<GameObject> _poolSystem;
        public PoolSystem<GameObject> PoolSystem { get => _poolSystem; }

        private void Awake() => _poolSystem = new PoolSystem<GameObject>(_makiPrefab, _poolSize, transform);

        public ISushi CreateSushi()
        {
            GameObject sushi = PoolSystem.Get();
            sushi.transform.position = _sushiCreationPoint.position;

            Maki maki = sushi.GetComponent<Maki>();
            SetFactory(maki);
            return maki;
        }

        public void SetFactory(ISushi sushi) => sushi.Factory = this;
    }
}