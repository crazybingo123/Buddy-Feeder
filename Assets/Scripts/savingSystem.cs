using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savingSystem : MonoBehaviour
{
    private DateTime saveTime;
    private TimeSpan timeGone;
    private DateTime loadTime;
    private int unitsMade;

    /*void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            Save();
            globalVariables.TimesQuit++;
        }
        else
        {
            Restore();
        }
    }

    void OnApplicationQuit()
    {
        globalVariables.TimesQuit++;
        Save();
    }

    void OnDestroy()
    {
        Save();
        globalVariables.TimesQuit++;
    }
    */
    void Update()
    {
        Save();
    }

    private void Awake()
    {
        //DontDestroyOnLoad(this);
    }
    public void Save()
    {
        PlayerPrefs.SetInt("chefs", globalVariables.Chefs);
        PlayerPrefs.SetInt("units", globalVariables.Units);
        PlayerPrefs.SetInt("factories", globalVariables.Factories);
        PlayerPrefs.SetInt("planets", globalVariables.Planets);
        PlayerPrefs.SetInt("perSec", globalVariables.PerSec);
        saveTime = DateTime.UtcNow;
        PlayerPrefs.SetString("saveTime", saveTime.ToString());
    }

    public void Load()
    {
        //timeReturn = DateTime.UtcNow.Ticks / 10000 / 1000;
        //timeGone = timeReturn - timePause;
        globalVariables.Chefs = PlayerPrefs.GetInt("chefs");
        globalVariables.Factories = PlayerPrefs.GetInt("factories");
        globalVariables.Planets = PlayerPrefs.GetInt("planets");
        globalVariables.Units = PlayerPrefs.GetInt("units");
        loadTime = DateTime.UtcNow;
        PlayerPrefs.SetString("loadTime", loadTime.ToString());
        saveTime = DateTime.Parse(PlayerPrefs.GetString("saveTime"));
        timeGone = loadTime - saveTime;
        unitsMade = ((int)timeGone.TotalSeconds * globalVariables.Chefs) + ((int)timeGone.TotalSeconds * globalVariables.Factories * 10) + ((int)timeGone.TotalSeconds * globalVariables.Planets * 100);
        globalVariables.Units += unitsMade;
        globalVariables.PerSec = PlayerPrefs.GetInt("perSec");
        Debug.Log("Made units: " + unitsMade + " in Seconds:" + timeGone);
    }
}
