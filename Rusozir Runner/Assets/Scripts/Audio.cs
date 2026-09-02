using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private AudioClip audioClipSimplScene;
    [SerializeField] private AudioClip audioClipMainScene;
    [SerializeField] private AudioClip audioClipHandSound;
    [SerializeField] private AudioClip audioClipDeathSound;

    public static Audio instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            bool isMuted = PlayerPrefs.GetInt("isMuted", 0) == 1;
            AudioListener.volume = isMuted ? 0f : 1f;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 0)
        {
            SimpleScene();
        }
        else if (scene.buildIndex == 1)
        {
            MainScene();
        }
    }

    public void SimpleScene()
    {
        if (audioSource.clip == audioClipSimplScene && audioSource.isPlaying)
            return;

        audioSource.clip = audioClipSimplScene;
        audioSource.Play();
    }

    public void MainScene()
    {
        if (audioSource.clip == audioClipMainScene && audioSource.isPlaying)
            return;

        audioSource.clip = audioClipMainScene;
        audioSource.Play();
    }

    public void HandSound()
    {
        audioSource.PlayOneShot(audioClipHandSound);
    }

    public void PlayScream(AudioClip scream)
    {
        audioSource.PlayOneShot(scream);
    }

    public void DeathSound()
    {
        audioSource.PlayOneShot(audioClipDeathSound);
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }
}