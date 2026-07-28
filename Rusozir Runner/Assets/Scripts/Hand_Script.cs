using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hand_Script : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(1);
            Destroy(gameObject);
            Debug.Log("Player get a hand");
        }
    }
}
