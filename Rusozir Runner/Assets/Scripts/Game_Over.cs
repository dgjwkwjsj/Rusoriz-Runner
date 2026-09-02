using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Destroyer"))
        {
            StartCoroutine(GameOver());

            if (gameOverScreen != null)
            {
                gameOverScreen.SetActive(true);
            }
        }

    }
    private IEnumerator GameOver()
    {
        Audio.instance.DeathSound();

        yield return new WaitForSecondsRealtime(1f);

        Audio.instance.StopMusic();

        Time.timeScale = 0f;

        Debug.Log("Game Over");


    }


}
