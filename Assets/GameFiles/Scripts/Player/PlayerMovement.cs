using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;

    private Vector2 _moveDirection;
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        transform.Translate(_moveDirection * playerData.PlayerSpeed * Time.deltaTime);

        _animator.SetFloat("Horizontal", _moveDirection.x);
        _animator.SetFloat("Vertical", _moveDirection.y);
    }

    public void OnMove(InputValue value)
    {
        _moveDirection = value.Get<Vector2>();
    }
}