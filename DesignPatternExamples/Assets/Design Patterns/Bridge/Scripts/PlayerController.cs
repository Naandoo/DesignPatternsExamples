using UnityEngine;

namespace Bridge
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private IPlayableCharacter _firstCharacter;
        [SerializeField] private IPlayableCharacter _secondCharacter;
        [SerializeField] private CinemachineCameraController _cameraController;
        private PlayerInput _playerInput;

        private void Start()
        {
            _playerInput = new PlayerInput(_firstCharacter);
        }

        public void SwitchControl()
        {
            _playerInput = new PlayerInput(_secondCharacter);
            _cameraController.SetTarget(_secondCharacter.transform);

            _playerInput = new PlayerInput(_firstCharacter);
            _cameraController.SetTarget(_firstCharacter.transform);
        }

        private void Update()
        {
            GetMovementInput();
            GetAttackInput();
        }

        private void GetMovementInput()
        {
            if (Input.GetKeyDown(KeyCode.W)) _playerInput.Move(Vector3.forward);

            if (Input.GetKeyDown(KeyCode.S)) _playerInput.Move(Vector3.back);

            if (Input.GetKeyDown(KeyCode.D)) _playerInput.Move(Vector3.right);

            if (Input.GetKeyDown(KeyCode.A)) _playerInput.Move(Vector3.left);

            if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S)
            || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
            {
                _playerInput.SetIdle(true);
            }
        }

        private void GetAttackInput() => _playerInput.Attack();

    }
}