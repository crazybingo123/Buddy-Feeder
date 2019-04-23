using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savingSystem : MonoBehaviour
{
    private DateTime saveTime;
    private DateTime oldTime;
    private DateTime currentTime;
    private TimeSpan timeGone;
    private DateTime loadTime;
    private float timePlayed;
    private int unitsMade;

    void Update()
    {
        Save();
    }

    public void Save()
    {

        PlayerPrefs.SetInt("units", globalVariables.Units);
        PlayerPrefs.SetInt("chefs", globalVariables.Chefs);
        PlayerPrefs.SetInt("chefcost", globalVariables.ChefCost);
        PlayerPrefs.SetInt("factories", globalVariables.Factories);
        PlayerPrefs.SetInt("factcost", globalVariables.FactCost);
        PlayerPrefs.SetInt("planets", globalVariables.Planets);
        PlayerPrefs.SetInt("planetcost", globalVariables.PlanetCost);

        PlayerPrefs.SetInt("timeplayed", Convert.ToInt32(Time.fixedUnscaledTime));

        PlayerPrefs.SetInt("persec", globalVariables.PerSec);
        PlayerPrefs.SetInt("click", globalVariables.Click);
        PlayerPrefs.SetInt("help", globalVariables.Help);
        PlayerPrefs.SetInt("buddybelly", globalVariables.BuddyBelly);
        PlayerPrefs.SetInt("narstate", globalVariables.NarState);

        if (globalVariables.SubTake == true)
        {
            PlayerPrefs.SetString("subtake", "true");
        }
        else
        {
            PlayerPrefs.SetString("subtake", "false");
        }

        if (globalVariables.SubGraphicsHelpers == true)
        {
            PlayerPrefs.SetString("subgraphicshelpers", "true");
        }
        else
        {
            PlayerPrefs.SetString("subgraphicshelpers", "false");
        }

        if (globalVariables.SubGraphicsCandy == true)
        {
            PlayerPrefs.SetString("subgraphicscandy", "true");
        }
        else
        {
            PlayerPrefs.SetString("subgraphicscandy", "false");
        }

        if (globalVariables.SubGraphicsSettings == true)
        {
            PlayerPrefs.SetString("subgraphicssettings", "true");
        }
        else
        {
            PlayerPrefs.SetString("subgraphicssettings", "false");
        }

        if (globalVariables.SubGraphicsShop == true)
        {
            PlayerPrefs.SetString("subgraphicsshop", "true");
        }
        else
        {
            PlayerPrefs.SetString("subgraphicsshop", "false");
        }

        if (globalVariables.SubGraphicsBackground == true)
        {
            PlayerPrefs.SetString("subgraphicsbackground", "true");
        }
        else
        {
            PlayerPrefs.SetString("subgraphicsbackground", "false");
        }

        if (globalVariables.SubGraphicsNarrative == true)
        {
            PlayerPrefs.SetString("subgraphicsnarrative", "true");
        }
        else
        {
            PlayerPrefs.SetString("subgraphicsnarrative", "false");
        }

        if (globalVariables.SubGraphicsBuddy == true)
        {
            PlayerPrefs.SetString("subgraphicsbuddy", "true");
        }
        else
        {
            PlayerPrefs.SetString("subgraphicsbuddy", "false");
        }

        if (globalVariables.SubGraphicsLvlbar == true)
        {
            PlayerPrefs.SetString("subgraphicslvlbar", "true");
        }
        else
        {
            PlayerPrefs.SetString("subgraphicslvlbar", "false");
        }

        if (globalVariables.canHold == true)
        {
            PlayerPrefs.SetString("canhold", "true");
        }
        else
        {
            PlayerPrefs.SetString("canhold", "false");
        }

        if (globalVariables.EndGame == true)
        {
            PlayerPrefs.SetString("endgame", "true");
        }
        else
        {
            PlayerPrefs.SetString("endgame", "false");
        }

        if (globalVariables.DeadGame == true)
        {
            PlayerPrefs.SetString("deadgame", "true");
        }
        else
        {
            PlayerPrefs.SetString("deadgame", "false");
        }

        if (globalVariables.HasQuit == true)
        {
            PlayerPrefs.SetString("hasquit", "true");
        }
        else
        {
            PlayerPrefs.SetString("hasquit", "false");
        }

        saveTime = DateTime.UtcNow;
        PlayerPrefs.SetString("savetime", saveTime.ToString());

        PlayerPrefs.SetInt("timespent", Convert.ToInt32(globalVariables.TimeSpent));
    }

    public void Load()
    {
        loadTime = DateTime.UtcNow;
        PlayerPrefs.SetString("loadtime", loadTime.ToString());
        saveTime = DateTime.Parse(PlayerPrefs.GetString("savetime"));
        timeGone = loadTime - saveTime;

        globalVariables.TimeSpent = PlayerPrefs.GetInt("timespent") + PlayerPrefs.GetInt("timeplayed");

        globalVariables.Units = PlayerPrefs.GetInt("units");        
        globalVariables.Chefs = PlayerPrefs.GetInt("chefs");
        globalVariables.ChefCost = PlayerPrefs.GetInt("chefcost");
        globalVariables.Factories = PlayerPrefs.GetInt("factories");
        globalVariables.FactCost = PlayerPrefs.GetInt("factcost");
        globalVariables.Planets = PlayerPrefs.GetInt("planets");
        globalVariables.PlanetCost = PlayerPrefs.GetInt("planetcost");
        unitsMade = ((int)timeGone.TotalSeconds * globalVariables.Chefs) + ((int)timeGone.TotalSeconds * globalVariables.Factories * 10) + ((int)timeGone.TotalSeconds * globalVariables.Planets * 100);
        globalVariables.Units += unitsMade;
        Debug.Log("Units made: " + unitsMade + " in " + timeGone.TotalSeconds);

        globalVariables.PerSec = PlayerPrefs.GetInt("persec");
        globalVariables.Click = PlayerPrefs.GetInt("click");
        globalVariables.Help = PlayerPrefs.GetInt("help");
        globalVariables.BuddyBelly = PlayerPrefs.GetInt("buddybelly");
        globalVariables.NarState = PlayerPrefs.GetInt("narstate");

        if (string.Compare(PlayerPrefs.GetString("canhold"), "true") == 0)
        {
            globalVariables.canHold = true;
        }
        else
        {
            globalVariables.canHold = false;
        }


        if (string.Compare(PlayerPrefs.GetString("subtake"), "true") == 0)
        {
            globalVariables.SubTake = true;
        }
        else
        {
            globalVariables.SubTake = false;
        }

        if (string.Compare(PlayerPrefs.GetString("subgraphicsbuddy"), "true") == 0)
        {
            globalVariables.SubGraphicsBuddy = true;
        }
        else
        {
            globalVariables.SubGraphicsBuddy = false;
        }

        if (string.Compare(PlayerPrefs.GetString("subgraphicsshop"), "true") == 0)
        {
            globalVariables.SubGraphicsShop = true;
        }
        else
        {
            globalVariables.SubGraphicsShop= false;
        }

        if (string.Compare(PlayerPrefs.GetString("subgraphicssettings"), "true") == 0)
        {
            globalVariables.SubGraphicsSettings = true;
        }
        else
        {
            globalVariables.SubGraphicsSettings = false;
        }

        if (string.Compare(PlayerPrefs.GetString("subgraphicscandy"), "true") == 0)
        {
            globalVariables.SubGraphicsCandy = true;
        }
        else
        {
            globalVariables.SubGraphicsCandy = false;
        }

        if (string.Compare(PlayerPrefs.GetString("subgraphicshelpers"), "true") == 0)
        {
            globalVariables.SubGraphicsHelpers = true;
        }
        else
        {
            globalVariables.SubGraphicsHelpers = false;
        }

        if (string.Compare(PlayerPrefs.GetString("subgraphicsbackground"), "true") == 0)
        {
            globalVariables.SubGraphicsBackground = true;
        }
        else
        {
            globalVariables.SubGraphicsBackground = false;
        }

        if (string.Compare(PlayerPrefs.GetString("subgraphicsnarrative"), "true") == 0)
        {
            globalVariables.SubGraphicsNarrative = true;
        }
        else
        {
            globalVariables.SubGraphicsNarrative = false;
        }

        if (string.Compare(PlayerPrefs.GetString("subgraphicslvlbar"), "true") == 0)
        {
            globalVariables.SubGraphicsLvlbar = true;
        }
        else
        {
            globalVariables.SubGraphicsLvlbar= false;
        }

        if (string.Compare(PlayerPrefs.GetString("endgame"), "true") == 0)
        {
            globalVariables.EndGame = true;
        }
        else
        {
            globalVariables.EndGame = false;
        }

        if (string.Compare(PlayerPrefs.GetString("deadgame"), "true") == 0)
        {
            globalVariables.DeadGame = true;
        }
        else
        {
            globalVariables.DeadGame = false;
        }

        if (string.Compare(PlayerPrefs.GetString("canhold"), "true") == 0)
        {
            globalVariables.canHold = true;
        }
        else
        {
            globalVariables.canHold = false;
        }

        if (string.Compare(PlayerPrefs.GetString("hasquit"), "true") == 0)
        {
            globalVariables.HasQuit = true;
        }
        else
        {
            globalVariables.HasQuit = false;
        }

    }
}
