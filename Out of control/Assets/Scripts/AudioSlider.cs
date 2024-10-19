using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSlider : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;

    [SerializeField] Slider music, sfx;
    float sliderMusicValue;
    float sliderSfxValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioMixer.SetFloat("VolMusic", PlayerPrefs.GetFloat("musicVol"));
        music.value = PlayerPrefs.GetFloat("musicVol");

        audioMixer.SetFloat("VolSFX",PlayerPrefs.GetFloat("sfxVol"));
        sfx.value = PlayerPrefs.GetFloat("sfxVol");

        music.onValueChanged.AddListener(changeValueMusic);
        sfx.onValueChanged.AddListener(changeValueSFX);

    }

    public void changeValueSFX(float v)
    {
        audioMixer.SetFloat("VolSFX",v);
        PlayerPrefs.SetFloat("sfxVol", v);
    }

    public void changeValueMusic(float v)
    {
        audioMixer.SetFloat("VolMusic", v);
        PlayerPrefs.SetFloat("musicVol", v);
    }

}
