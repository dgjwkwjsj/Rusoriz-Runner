using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    [SerializeField] private TMP_Text scoreText;

    private int score;  
    public int Score => score;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        score = PlayerPrefs.GetInt("hand", 0);
        UpdateScore();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreText.text = " " + score;
    }
}