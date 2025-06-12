using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private Movement movement;

    void Awake()
    {
        movement = GetComponent<Movement>();
    }

    public void SetVelocity(InputAction.CallbackContext context)
    {
        movement.SetVelocity(context.ReadValue<Vector2>(), 1.0f);
    }
}