using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicCtrl : MonoBehaviour
{
    static bool AudioBegin = false;
    public static AudioSource audSource;

    void Start()
    {
        audSource = GetComponent<AudioSource>();
    }

    void Awake()
    {
        DontDestroyOnLoad(this);
        if (!AudioBegin)
        {
            GetComponent<AudioSource>().Play();
            AudioBegin = true;
        }
    }
   

    public void MusicMute()
    {
        audSource.mute = !audSource.mute;
    }
}
