using UnityEngine;

public class FPV_Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private DynamicJoystick joystick;
    [SerializeField] private float speed = 5f;

    [SerializeField] private float titleSpeed = 5f;
    [SerializeField] private float tiltAngle = 30f;
    [SerializeField] private Transform playerModel;


    private void FixedUpdate()
    {


        rb.linearVelocity = new Vector2(joystick.Horizontal * speed, joystick.Vertical * speed);

        playerModel.transform.rotation = Quaternion.Euler(25f, 0f, 0f);

        float targetTilt = 0f;

        if (joystick.Horizontal < -0.1f)
        {
            targetTilt = tiltAngle;

        }
        else if (joystick.Horizontal > 0.1f)
        {
            targetTilt = -tiltAngle;
        }
        else
        {
            targetTilt = 0f;
        }

        Quaternion targetRotation = Quaternion.Euler(0f, 0f, targetTilt);

        playerModel.localRotation = Quaternion.Slerp(playerModel.localRotation, targetRotation, titleSpeed * Time.fixedDeltaTime);
    }

}
