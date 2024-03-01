using UnityEngine;

namespace Prototype
{
    public class Monster : MonoBehaviour
    {
        public IMonsterPrototype MonsterPrototype = new MonsterPrototype();
        public PoolSystem<Monster> currentPool;

        private void Update()
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }

        private void OnTriggerEnter(Collider otherCollider)
        {
            if (otherCollider.TryGetComponent(out Base baseCollider))
            {
                baseCollider.ReceiveDamage(MonsterPrototype.AttackDamage);
                currentPool.Return(this);
            }
        }
    }
}
