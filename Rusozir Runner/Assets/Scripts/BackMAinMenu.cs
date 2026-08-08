using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMAinMenu : MonoBehaviour
{
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
