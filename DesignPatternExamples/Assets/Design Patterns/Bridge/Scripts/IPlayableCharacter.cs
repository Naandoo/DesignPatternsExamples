using UnityEngine;

namespace Bridge
{
    public interface IPlayableCharacter
    {
        bool Idle { get; }
        bool IsIdle();
        void SetIdle(bool value);
        void Attack();
        void MoveRight();
        void MoveLeft();
        void MoveUp();
        void MoveDown();
        void ExecuteAnimation(string animationName);
    }
}
