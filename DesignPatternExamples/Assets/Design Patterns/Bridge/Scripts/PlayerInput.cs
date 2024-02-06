using UnityEngine;

namespace Bridge
{
    public class PlayerInput
    {
        private IPlayableCharacter _character;
        public IPlayableCharacter Character { get => _character; private set => _character = value; }
        public PlayerInput(IPlayableCharacter character)
        {
            _character = character;
        }

        public void Attack()
        {
            if (_character.IsIdle())
            {
                _character.Attack();
            }
        }

        public void Move(Vector3 direction)
        {
            _character.Move(direction);
        }

        public void SetIdle(bool value)
        {
            if (value != _character.Idle)
            {
                _character.SetIdle(value);
            }
        }
    }
}