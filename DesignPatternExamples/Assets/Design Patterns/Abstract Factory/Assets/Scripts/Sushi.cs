using UnityEngine;

namespace AbstractFactory
{
    public abstract class Sushi : MonoBehaviour, IPoolableObject<GameObject>
    {
        [SerializeField] private Collider _collider;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private Transform _sushiPhysicObjectTransform;
        private Feedback _feedback = new();
        private IPoolSystem<GameObject> _poolSystem;
        private Vector3 _sushiCreationPoint;

        private void OnEnable()
        {
            _collider.isTrigger = false;
            _rigidbody.useGravity = true;
            _sushiCreationPoint = transform.position;
        }

        public void SetPool(IPoolSystem<GameObject> poolSystem)
        {
            _poolSystem = poolSystem;
        }

        private void Update()
        {
            CheckDistanceToDisable();
        }

        private void CheckDistanceToDisable()
        {
            if (Vector3.Distance(_sushiPhysicObjectTransform.position, _sushiCreationPoint) > 10)
            {
                _poolSystem.Return(gameObject);
            }
        }

        public void Eat()
        {
            _collider.isTrigger = true;
            _rigidbody.useGravity = false;

            _feedback.OnEatAnimation(transform, onFinishedAnimation: () =>
            {
                _poolSystem.Return(gameObject);
            });
        }

    }
}