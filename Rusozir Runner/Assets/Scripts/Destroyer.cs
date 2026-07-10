using UnityEngine;

public class Destroyer : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destroyer"))
        {
            Destroy(other.gameObject);
            Debug.Log("Road section destroyed");
        }
    }
}
