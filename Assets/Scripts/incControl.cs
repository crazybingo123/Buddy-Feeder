using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class incControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("HelpInc", 0.0f, 1.0f);
    }

    void HelpInc()
    {
        globalVariables.Units += globalVariables.Chefs * 1;
        globalVariables.Units += globalVariables.Factories * 10;
        globalVariables.Units += globalVariables.Planets * 100;
    }
}
