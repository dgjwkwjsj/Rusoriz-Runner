using UnityEngine;

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
        }
        else
        {
            Destroy(gameObject);
        }
    }

    internal void SimpleScene()
    {
        if (audioSource.clip == audioClipSimplScene && audioSource.isPlaying)
            return;

        audioSource.clip = audioClipSimplScene;
        audioSource.Play();

        Debug.Log("SimpleScene");
    }

    internal void MainScene()
    {
        if (audioSource.clip == audioClipMainScene && audioSource.isPlaying)
            return;

        audioSource.clip = audioClipMainScene;
        audioSource.Play();

        Debug.Log("MainScene");
    }

    internal void HandSound()
    {
        audioSource.PlayOneShot(audioClipHandSound);
    }
    internal void PlayScream(AudioClip scream)
    {
        audioSource.PlayOneShot(scream);
    }
    internal void DeathSound()
    {
        audioSource.PlayOneShot(audioClipDeathSound);
    }
}