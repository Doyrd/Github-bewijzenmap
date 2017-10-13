using UnityEngine.UI;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource currentAudio;
    public Slider volumeSlider;
    public Text volumeSliderText;
    public float theAudioVolumeValue;
    internal int difficultyValue;

    void Start()
    {
        volumeSlider.value = 1f;
    }

    void Update()
    {
        theAudioVolumeValue = volumeSlider.value;
        volumeSliderText.text = "Music volume: " + Mathf.Round(theAudioVolumeValue * 100) + "%";
    }

    public void ChangeMusicVolume()
    {
        currentAudio.volume = volumeSlider.value;
    }
}
