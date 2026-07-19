using UnityEngine;
using System.Collections.Generic;

public class Spawn_Fields : MonoBehaviour
{
    [SerializeField] private List<GameObject> obstaclePrefabs;
    [SerializeField] private Transform spawnedPoint1;
    [SerializeField] private Transform spawnedPoint2;


    private bool isSpawnedFields = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !isSpawnedFields)
        {
            isSpawnedFields = true;
            int randomIndex = Random.Range(0, obstaclePrefabs.Count);
            int randomIndex2 = Random.Range(0, obstaclePrefabs.Count);
            Instantiate(obstaclePrefabs[randomIndex], spawnedPoint1.position, spawnedPoint1.rotation);
            Instantiate(obstaclePrefabs[randomIndex2], spawnedPoint2.position, spawnedPoint1.rotation);
            Debug.Log("Player entered the trigger and Fields spawned");
        }
    }
}
