using UnityEngine;

namespace Singleton
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed;
        private PoolSystem<Bullet> _poolSystem;

        public void SetPool(PoolSystem<Bullet> poolSystem) => _poolSystem = poolSystem;

        private void Update()
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Enemy enemy))
            {
                enemy.Die();
                _poolSystem.Return(this);
            }
        }
    }

}