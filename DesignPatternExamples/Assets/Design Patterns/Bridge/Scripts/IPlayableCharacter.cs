using UnityEngine;

namespace Bridge
{
    public interface IPlayableCharacter
    {
        bool Idle { get; }
        bool IsIdle();
        void SetIdle(bool value);
        void Attack();
        void Move(Vector3 direction);
        Transform transform { get; }
        void ExecuteAnimation(string animationName);
    }
}
