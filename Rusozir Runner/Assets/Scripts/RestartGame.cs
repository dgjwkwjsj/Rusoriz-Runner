using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void RestartCurrentScene()
    {
        Time.timeScale = 1f;
        AudioListener.volume = 0.6f;

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentSceneIndex);
    }
    public void BackHome()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
}