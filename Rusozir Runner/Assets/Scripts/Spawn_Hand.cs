using UnityEngine;
using System.Collections.Generic;

public class Spawn_Hand : MonoBehaviour
{
    [SerializeField] private List<Transform> SpawnHand;
    [SerializeField] private GameObject HandPrefab;

    private void Start()
    {
        foreach (Transform point in SpawnHand)
        {
            Instantiate(
                HandPrefab,
                point.position,
                point.rotation,
                transform
            );
        }
    }
}