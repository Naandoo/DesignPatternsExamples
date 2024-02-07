using System.Security.Cryptography;
using UnityEngine;

namespace Bridge
{
    public abstract class PlayableCharacter : MonoBehaviour, IPlayableCharacter
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private float _speed;
        [SerializeField] private float _rotationSpeed;
        public bool Idle { get; private set; }

        public virtual bool IsIdle() => Idle;

        public virtual void Attack()
        {
            ExecuteAnimation("Attack");
        }

        public virtual void Move(Vector3 direction)
        {
            transform.position += direction * _speed * Time.deltaTime;
            ExecuteAnimation("Walk");
            Rotate(direction);
        }

        public virtual void SetIdle(bool value)
        {
            Idle = value;
            if (Idle) ExecuteAnimation("Idle");
        }

        public virtual void Rotate(Vector3 direction)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            float rotationSpeed = _rotationSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed);
        }

        public virtual void ExecuteAnimation(string animationName)
        {
            if (_animator.GetCurrentAnimatorStateInfo(0).IsName(animationName)) return;
            _animator.Play(animationName);
        }
    }
}