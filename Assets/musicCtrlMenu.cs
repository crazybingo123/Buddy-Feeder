using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicCtrlMenu : MonoBehaviour
{
    public Slider musicSlider;
    private musicCtrl musicCtrl;
    // Start is called before the first frame update
    public void MusicMuteMenu()
    {
        musicCtrl = GameObject.Find("Main Music").GetComponent<musicCtrl>();
        musicCtrl.MusicMute();
    }
    public void MusicSliderControl()
    {
        musicCtrl.audSource.volume = musicSlider.value;
    }

}
