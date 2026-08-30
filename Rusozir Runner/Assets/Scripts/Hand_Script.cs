using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class Hand_Script : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Audio.instance.HandSound();
            ScoreManager.Instance.AddScore(1);
            PlayerPrefs.SetInt("hand", ScoreManager.Instance.Score);
            PlayerPrefs.Save();
            Destroy(gameObject);
            Debug.Log("Player get a hand");
        }
    }
}
