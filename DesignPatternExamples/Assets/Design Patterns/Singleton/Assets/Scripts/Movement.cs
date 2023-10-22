using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private CharacterAnimation _characterAnimation;

    private void FixedUpdate()
    {
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        _rigidbody.MovePosition(transform.position + new Vector3(horizontal, vertical, 0) * _speed * Time.fixedDeltaTime);

        _characterAnimation.UpdateMovementAnimation();
        UpdateTransform();
    }

    private void UpdateTransform()
    {
        if (Input.GetAxisRaw("Horizontal") == 0) return;

        float newRotation = Input.GetAxisRaw("Horizontal") < 0 ? 180 : 0;
        transform.rotation = Quaternion.Euler(0, newRotation, 0);
    }
}
