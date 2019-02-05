using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicCtrl : MonoBehaviour
{
    static bool AudioBegin = false;
    public static AudioSource audSource;

    void Awake()
    {
        DontDestroyOnLoad(this);
        if (!AudioBegin)
        {
            GetComponent<AudioSource>().Play();
            AudioBegin = true;
        }
    }
    void Start()
    {
        audSource = GetComponent<AudioSource>();
    }

    public void MusicMute()
    {
        audSource.mute = !audSource.mute;
    }
}
