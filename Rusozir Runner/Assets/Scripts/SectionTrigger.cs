using UnityEngine;
using UnityEngine.UIElements;

public class SectionTrigger : MonoBehaviour
{

    [SerializeField] private GameObject roadSection;
        
       private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(roadSection, new Vector3( 0f,0f,19.7f), Quaternion.identity);
            Debug.Log("Road section instantiated");
        }
    }
}
