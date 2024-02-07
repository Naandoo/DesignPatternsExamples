using UnityEngine;

namespace Bridge
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private PlayableCharacter _firstCharacter;
        [SerializeField] private PlayableCharacter _secondCharacter;
        [SerializeField] private CinemachineCameraController _cameraController;
        private PlayerInput _playerInput;

        private void Awake()
        {
            _playerInput = new PlayerInput(_firstCharacter);
        }

        public void SwitchControl()
        {
            if (_playerInput.Character.Equals(_firstCharacter))
            {
                _playerInput = new PlayerInput(_secondCharacter);
                _cameraController.SetTarget(_secondCharacter.transform);
            }
            else
            {
                _playerInput = new PlayerInput(_firstCharacter);
                _cameraController.SetTarget(_firstCharacter.transform);
            }
        }

        private void Update()
        {
            GetMovementInput();
            GetAttackInput();
        }

        private void GetMovementInput()
        {
            if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                _playerInput.Move(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")));
                _playerInput.SetIdle(false);
            }
            if (!Input.anyKey) _playerInput.SetIdle(true);
        }

        private void GetAttackInput()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _playerInput.Attack();
            }
        }

    }
}