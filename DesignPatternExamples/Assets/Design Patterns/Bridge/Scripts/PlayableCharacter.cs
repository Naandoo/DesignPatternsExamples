using System.Security.Cryptography;
using UnityEngine;

namespace Bridge
{
    public abstract class PlayableCharacter : MonoBehaviour, IPlayableCharacter
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private float _speed;
        [SerializeField] private float _speedRotation;
        [SerializeField] private Transform _skinTransform;
        public bool Idle { get; private set; }

        public virtual bool IsIdle() => Idle;

        public virtual void Attack()
        {
            ExecuteAnimation("Attack");
        }

        public virtual void MoveLeft()
        {
            transform.position += -transform.right * _speed * Time.deltaTime;
            ExecuteAnimation("Walk");
            Rotate(-transform.right);
        }

        public virtual void MoveRight()
        {
            transform.position += transform.right * _speed * Time.deltaTime;
            ExecuteAnimation("Walk");
            Rotate(transform.right);
        }

        public virtual void MoveUp()
        {
            transform.position += transform.forward * _speed * Time.deltaTime;
            ExecuteAnimation("Walk");
            Rotate(transform.forward);
        }

        public virtual void MoveDown()
        {
            transform.position += -transform.forward * _speed * Time.deltaTime;
            ExecuteAnimation("Walk");
            Rotate(-transform.forward);
        }

        public virtual void SetIdle(bool value)
        {
            Idle = value;
            if (Idle) ExecuteAnimation("Idle");
        }

        public virtual void Rotate(Vector3 direction)
        {
            _skinTransform.rotation = Quaternion.Slerp(_skinTransform.rotation, Quaternion.LookRotation(direction), _speedRotation * Time.deltaTime);
        }

        public virtual void ExecuteAnimation(string animationName)
        {
            if (_animator.GetCurrentAnimatorStateInfo(0).IsName(animationName)) return;
            _animator.Play(animationName);
        }
    }
}