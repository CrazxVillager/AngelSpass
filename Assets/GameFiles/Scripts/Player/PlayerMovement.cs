using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    
    private Vector2 _moveDirection;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_moveDirection * (playerData.PlayerSpeed * Time.deltaTime));
    }

    public void Move(InputAction.CallbackContext context)
    {
        _moveDirection = context.ReadValue<Vector2>();
    }
}
