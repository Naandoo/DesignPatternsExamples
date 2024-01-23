using UnityEngine;

namespace AbstractFactory
{
    public abstract class AbstractFactory : MonoBehaviour
    {
        public GameObject _sushiPrefab;
        public int _poolSize;
        public Transform _sushiCreationPoint;
        public PoolSystem<GameObject> _poolSystem;
        public PoolSystem<GameObject> PoolSystem { get => _poolSystem; }

        public void CreateSushi()
        {
            GameObject sushi = PoolSystem.Get();
            sushi.transform.localPosition = _sushiCreationPoint.position;
            AddRandomForce(sushi);

            ISushi iSushi = sushi.GetComponent<ISushi>();

            SetFactory(iSushi);
        }

        public void SetFactory(ISushi sushi) => sushi.Factory = this;

        public void AddRandomForce(GameObject sushi)
        {
            Rigidbody rigidbody = sushi.GetComponentInChildren<Rigidbody>();
            rigidbody.AddForce(new Vector3(Random.Range(-0.75f, 0.75f), 0f, Random.Range(-0.75f, 0.75f)) * 100f);
        }
    }
}
