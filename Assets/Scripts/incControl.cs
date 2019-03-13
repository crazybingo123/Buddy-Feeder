using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class incControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        savingSystem sn = this.GetComponent<savingSystem>();
        InvokeRepeating("HelpInc", 0.0f, 1.0f);
        sn.Load();
    }

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("scriptsMain");
        if (objs.Length > 1)
        {
            Destroy(objs[1]);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void HelpInc()
    {
        globalVariables.Units += globalVariables.Chefs * 1;
        globalVariables.Units += globalVariables.Factories * 10;
        globalVariables.Units += globalVariables.Planets * 100;
    }
}
