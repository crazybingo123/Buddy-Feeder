using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuddyBehavior : MonoBehaviour
{
    private int oldUnits = 0;
    private int oldClick = 0;


    // Start is called before the first frame update
    void Start()
    {
        oldUnits = globalVariables.Units;
        oldClick = globalVariables.Click;
        InvokeRepeating("CheckEmotion", 0.0f, 5f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void CheckEmotion()
    {
        if (globalVariables.Units == oldUnits || globalVariables.Click == oldClick)
        {
            globalVariables.sad = true;
        }
        else
        {
            globalVariables.sad = false;
        }
        oldUnits = globalVariables.Units;
        oldClick = globalVariables.Click;
    }
}
