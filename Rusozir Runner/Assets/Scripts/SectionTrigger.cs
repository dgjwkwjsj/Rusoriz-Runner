using UnityEngine;
using UnityEngine.UIElements;

public class SectionTrigger : MonoBehaviour
{
    [SerializeField] private Transform roadPoint;
    [SerializeField] private GameObject roadSection;

    private bool hasSpawned = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !hasSpawned)
        {
            hasSpawned = true;

            Instantiate(roadSection, roadPoint.position, roadPoint.rotation);

            Debug.Log("New road section spawned");
        }
    }
}
