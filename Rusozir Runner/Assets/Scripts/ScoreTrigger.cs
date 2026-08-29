using UnityEngine;
using TMPro;

public class ScoreTrigger : MonoBehaviour
{
    [SerializeField] private ScoreDistance scoreDistance;

    private int score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreDistance.AddScore(20);
        }
    }
}
