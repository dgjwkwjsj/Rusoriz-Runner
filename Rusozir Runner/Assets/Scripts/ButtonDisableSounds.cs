using UnityEngine;
using UnityEngine.UI;

public class ButtonDisableSounds : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private Sprite Mutesprite;
    [SerializeField] private Sprite Soundsprite;


    private bool isMuted;


    private void Start()
    {
        isMuted = PlayerPrefs.GetInt("isMuted", 0) == 1;
        UpdateSound();
    }
    public void ToggleMute()
    {
        isMuted = !isMuted;
        PlayerPrefs.SetInt("isMuted", isMuted ? 1 : 0);
        PlayerPrefs.Save();

        UpdateSound();
    }

    private void UpdateSound()
    {
        AudioListener.volume = isMuted ? 0f : 1f;

        if (isMuted)
        {
            icon.sprite = Mutesprite;
        }
        else
        {
            icon.sprite = Soundsprite;
        }
    }
}
