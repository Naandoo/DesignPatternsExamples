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
            if (Input.GetKey(KeyCode.W)) _playerInput.Move(Vector3.forward);

            if (Input.GetKey(KeyCode.S)) _playerInput.Move(Vector3.back);

            if (Input.GetKey(KeyCode.D)) _playerInput.Move(Vector3.right);

            if (Input.GetKey(KeyCode.A)) _playerInput.Move(Vector3.left);

            if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S)
            || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
            {
                _playerInput.SetIdle(true);
            }
        }

        private void GetAttackInput() => _playerInput.Attack();

    }
}