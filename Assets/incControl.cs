using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class incControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Chef", 0f, 1f);
    }

    // Update is called once per frame
    void Chef()
    {
        globalVariables.units += globalVariables.chefs * 1;
    }
}
