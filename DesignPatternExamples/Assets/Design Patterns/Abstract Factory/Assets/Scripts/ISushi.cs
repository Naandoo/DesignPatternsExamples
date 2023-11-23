using UnityEngine;

namespace AbstractFactory
{
    public abstract class ISushi : MonoBehaviour
    {
        [SerializeField] private Collider _collider;
        [SerializeField] private Rigidbody _rigidbody;
        private Feedback _feedback = new();
        public AbstractFactory Factory { get; set; }

        private void OnEnable()
        {
            _collider.isTrigger = false;
            _rigidbody.useGravity = true;
        }

        public void Eat()
        {
            _collider.isTrigger = true;
            _rigidbody.useGravity = false;

            _feedback.onEatAnimation(transform, onFinishedAnimation: () =>
            {
                Factory.PoolSystem.Return(this.gameObject);
            });
        }
    }
}