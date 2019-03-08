using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savingSystem : MonoBehaviour
{
    private long date;
    private bool save;
    private int oldUnits;
    private int oldChefs;
    private int oldFactories;
    private int oldPlanets;
    private long timePause;
    private long timeGone;
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            oldUnits = globalVariables.Units;
            oldChefs = globalVariables.Chefs;
            oldFactories = globalVariables.Factories;
            oldPlanets = globalVariables.Planets;
            timePause = date;
            save = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        date = DateTime.UtcNow.Ticks / 10000 / 1000;
        if (save == true)
        {
            save = false;
            timeGone = date - timePause;
            globalVariables.Chefs = oldChefs;
            globalVariables.Factories = oldFactories;
            globalVariables.Planets = oldPlanets;
            globalVariables.Units = oldUnits + (((int)timeGone) * globalVariables.Chefs) + (((int)timeGone) * globalVariables.Factories*10) + (((int)timeGone) * globalVariables.Planets*100);
        }
    }

    
}
