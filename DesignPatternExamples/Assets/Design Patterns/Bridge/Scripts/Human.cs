using UnityEngine;

namespace Bridge
{
    public class Human : MonoBehaviour, IPlayableCharacter
    {
        [SerializeField] private Animator animator;
        [SerializeField] private float speed;
        public bool Idle { get; private set; }

        public bool IsIdle() => Idle;

        public void Attack()
        {
            //do attack animation
        }

        public void Move(Vector3 direction)
        {
            transform.position += direction * speed * Time.deltaTime;
        }

        public void SetIdle(bool value)
        {
            Idle = value;
            //do idle animation
        }
    }
}