using UnityEngine;

public class FPV_Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private FixedJoystick joystick;
    [SerializeField] private float speed = 5f;


private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(joystick.Horizontal * speed, joystick.Vertical * speed);
    }
}
