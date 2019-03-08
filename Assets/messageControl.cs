using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messageControl : MonoBehaviour
{
    private Text msg;
    private string narrative;
    int units = globalVariables.Units;
    int click = globalVariables.Click;

    // Start is called before the first frame update
    void Start()
    {
        msg = GetComponent<Text>();
        narrative = "Welcome";
    }

    // Update is called once per frame
    void Update()
    {
        narrativeFlow();
        msg.text = narrative;
    }

    void narrativeFlow()
    {
        if (globalVariables.Units == 0 && globalVariables.Click == 0)
        {
            narrative = "Welcome to Buddy Feeder! Tap the candy to feed your buddy :)";
        }
        if (globalVariables.Click > 1)
        {
            narrative = "Yay! Your buddy is happy :) keep feeding him!";
        }
    }
}
