using UnityEngine;
using TMPro;

public class ScoreDistance : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text highScoreText;

    private int score;
    private int highScore;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);

        highScoreText.text = highScore + "m";
        scoreText.text = "0m";
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = score + "m";

        if(score >= highScore)
        {
            highScore = score;
            highScoreText.text = highScore + "m";

            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }
    
}
