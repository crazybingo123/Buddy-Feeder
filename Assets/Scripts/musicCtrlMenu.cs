using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicCtrlMenu : MonoBehaviour
{
    public Slider musicSlider;
    private musicCtrl musicCtrl;
    public AudioSource music;

    public void MusicMuteMenu()
    {
        //musicCtrl = GameObject.Find("Main Music").GetComponent<musicCtrl>();
        //musicCtrl.MusicMute();
        music.volume = 0;
    }
    public void MusicSliderControl()
    {
        //musicCtrl.audSource.volume = musicSlider.value;
        music.volume = musicSlider.value;
    }

}
