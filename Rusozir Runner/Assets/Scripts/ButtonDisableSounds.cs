using UnityEngine;
using UnityEngine.UI;

public class ButtonDisableSounds : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private Sprite Mutesprite;
    [SerializeField] private Sprite Soundsprite;


    private bool isMuted;
    

    public void ToggleMute()
    {
        isMuted = !isMuted;
        AudioListener.volume = isMuted ? 0f : 1f;
        
        if(isMuted)
        {
            icon.sprite = Mutesprite;
        }
        else
        {
            icon.sprite = Soundsprite;
        }
    }
}
