using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfxCtrl : MonoBehaviour
{
    public void play()
    {
        AudioSource audio = GetComponent<AudioSource>();
        if (!globalVariables.sfxMute)
        { 
        if (globalVariables.SfxVol != 0)
        {
            audio.volume = globalVariables.SfxVol;
        }
            audio.Play();
        }
    }

    
}
