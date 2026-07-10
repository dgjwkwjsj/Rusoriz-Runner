using UnityEngine;

public class Section_Move : MonoBehaviour
{
    private float section_speed = 1f;
    void Update()
    {
        transform.position += new Vector3(0,0,-3)* section_speed * Time.deltaTime;
    }
}
