using UnityEngine;

namespace Bridge
{
    public abstract class PlayableCharacter : MonoBehaviour, IPlayableCharacter
    {
        [SerializeField] private Animator animator;
        [SerializeField] private float speed;
        public bool Idle { get; private set; }

        public virtual bool IsIdle() => Idle;

        public virtual void Attack()
        {
            //do attack animation
        }

        public virtual void Move(Vector3 direction)
        {
            transform.position += direction * speed * Time.deltaTime;
        }

        public virtual void SetIdle(bool value)
        {
            Idle = value;
            //do idle animation
        }

    }
}