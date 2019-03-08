using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfxCtrl : MonoBehaviour
{
    public void play()
    {
        AudioSource audio = GetComponent<AudioSource>();
        Debug.Log("Play");
        audio.Play();
    }

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
