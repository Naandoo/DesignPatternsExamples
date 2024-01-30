using UnityEngine;

namespace AbstractFactory
{
    public abstract class AbstractFactory : MonoBehaviour
    {
        public GameObject _sushiPrefab;
        public int _poolSize;
        public Transform _sushiCreationPoint;
        public PoolSystem<GameObject> PoolSystem;
        private const float _sushiPushForce = 0.75f;
        private const float _sushiPushForceMultiplier = 100f;

        public void CreateSushi()
        {
            GameObject sushi = PoolSystem.Get();
            IPoolableObject<GameObject> poolableObject = sushi.GetComponent<IPoolableObject<GameObject>>();
            poolableObject.SetPool(PoolSystem);

            sushi.transform.localPosition = _sushiCreationPoint.position;
            AddRandomForce(sushi);

            Sushi Sushi = sushi.GetComponent<Sushi>();
        }

        public void AddRandomForce(GameObject sushi)
        {
            Rigidbody rigidbody = sushi.GetComponentInChildren<Rigidbody>();
            rigidbody.AddForce(new Vector3(Random.Range(-_sushiPushForce, _sushiPushForce),
            0f, Random.Range(-_sushiPushForce, _sushiPushForce)) * _sushiPushForceMultiplier);
        }
    }
}
