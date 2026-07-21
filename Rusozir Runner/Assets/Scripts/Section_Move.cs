using UnityEngine;

public class Section_Move : MonoBehaviour
{
    [SerializeField] private float Current_speed = 1f;
    [SerializeField] private float acceleration = 0.1f;
    [SerializeField] private float max_speed = 100f;

    [SerializeField] private Vector3 moveDirection = Vector3.back;

    public float CurrentSpeed => Current_speed;

    void Update()
    {
        if (Current_speed < max_speed)
        {
            Current_speed += acceleration * Time.deltaTime;

            Current_speed = Mathf.Min(Current_speed, max_speed);
        }

        transform.Translate(moveDirection * Current_speed * Time.deltaTime, Space.World);
    }
}
