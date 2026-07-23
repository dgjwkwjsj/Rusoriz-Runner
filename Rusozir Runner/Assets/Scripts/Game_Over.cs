using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Destroyer"))
        {
            Time.timeScale = 0f;
            Debug.Log("Game Over");
            if (gameOverScreen != null)
            {
                gameOverScreen.SetActive(true);
            }
        }

    }
}
