using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicCtrlMenu : MonoBehaviour
{
    private Slider musicSlider;
    private Slider sfxSlider;
    private Button musicButton;
    private Button sfxButton;
    private GameObject music;
    private AudioSource musicSource;

    void Start()
    {
        musicSlider = GameObject.Find("Music Slider").GetComponent<Slider>();
        sfxSlider = GameObject.Find("SFX Slider").GetComponent<Slider>();
        music = GameObject.FindGameObjectWithTag("music");
        musicSource = music.GetComponent<AudioSource>();
        musicButton = GameObject.Find("Music Toggle").GetComponent<Button>();
        sfxButton = GameObject.Find("SFX Toggle").GetComponent<Button>();
        if (!globalVariables.musicChange)
        {
            globalVariables.MusicVol = 1f;
        }
        if (!globalVariables.sfxChange)
        {
            globalVariables.SfxVol = 1f;
        }
    }
    void Update()
    {
        musicSource.volume = globalVariables.MusicVol;
        musicSlider.value = globalVariables.MusicVol;
        sfxSlider.value = globalVariables.SfxVol;
        if (globalVariables.musicMute)
        {
            musicButton.GetComponent<Image>().color = Color.red;
        } else
        {
            musicButton.GetComponent<Image>().color = Color.green;
        }
        if (globalVariables.sfxMute)
        {
            sfxButton.GetComponent<Image>().color = Color.red;
        }
        else
        {
            sfxButton.GetComponent<Image>().color = Color.green;
        }
    }
    public void MusicMuteMenu()
    {
        musicSource.mute = !musicSource.mute;
        globalVariables.musicMute = !globalVariables.musicMute;
    }
    public void MusicSliderControl(float vol)
    {
        globalVariables.MusicVol = vol;
        globalVariables.musicChange = true;
    }
    public void SFXMuteMenu()
    {
        globalVariables.sfxMute = !globalVariables.sfxMute;
    }
    public void sfxSliderControl(float vol)
    {
        globalVariables.SfxVol = vol;
        globalVariables.sfxChange = true;
    }
}
