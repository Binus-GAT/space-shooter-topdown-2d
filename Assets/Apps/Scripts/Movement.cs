using UnityEngine;
using UnityEngine.InputSystem;


public class Movement : MonoBehaviour
{
    private Rigidbody2D rb2d;

    void Awake()
    {
        // Initialize the Rigidbody2D component
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void SetVelocity(Vector2 direction, float speed)
    {
        // Move the object in the specified direction at the given speed
        rb2d.linearVelocity = direction.normalized * speed;
    }


    public void SetVelocity(InputAction.CallbackContext context)
    {
        SetVelocity(context.ReadValue<Vector2>(), 1.0f);
    }
}
