using UnityEngine;

public class Obstacle_Move : MonoBehaviour
{
    [SerializeField] private Vector3 moveDirection = Vector3.back;
    private Section_Move platformScript;

    void Start()
    {
        platformScript = FindFirstObjectByType<Section_Move>();
    }

    void Update()
    {
        if (platformScript != null)
        {
            transform.Translate(moveDirection * platformScript.CurrentSpeed * Time.deltaTime, Space.World);
        }
    }
}