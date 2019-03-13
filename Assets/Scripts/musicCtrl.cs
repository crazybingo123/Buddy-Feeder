using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicCtrl : MonoBehaviour
{
    public static AudioSource audSource;

    void Start()
    {
        audSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        
    }
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
   

    public void MusicMute()
    {
        audSource.mute = !audSource.mute;
    }
}
