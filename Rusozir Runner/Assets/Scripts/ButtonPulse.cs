using UnityEngine;

public class ButtonPulse : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float scaleAmount = 1.1f;

    private Vector3 startScale;

    private void Start()
    {
        startScale = transform.localScale;
    }

    private void Update()
    {
        float scale = 1 + Mathf.Sin(Time.time * speed) * (scaleAmount - 1);

        transform.localScale = startScale * scale;
    }
}