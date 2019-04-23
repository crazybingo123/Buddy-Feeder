using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class globalVariables
{
    private static Scene currentScene;
    private static int units;
    private static int chefs;
    private static int chefCost;
    private static int factories;
    private static int factCost;
    private static int planets;
    private static int planetCost;
    private static int perSec;
    private static int click;
    private static int help;
    private static int buddyBelly;
    private static int buddyLevel;
    private static int narState;

    private static bool subGraphicsSettings;
    private static bool subGraphicsShop;
    private static bool subGraphicsCandy;
    private static bool subGraphicsHelpers;
    private static bool subGraphicsBackground;
    private static bool subGraphicsNarrative;
    private static bool subGraphicsBuddy;
    private static bool subGraphicsLvlbar;
    private static bool subTake;
    private static bool subAll;
    private static bool endGame;
    private static bool deadGame;
    private static bool appPaused;
    private static bool hasQuit;

    public static bool canHold;
    public static bool sfxMute;
    public static bool musicMute;
    public static bool sad;
    public static bool musicChange;
    public static bool sfxChange;

    private static float musicVol;
    private static float sfxVol;
    private static float timeSpent;


    public static int Units
    {
        get
        {
            return units;
        }

        set
        {
            units = value;
        }
    }

    public static int NarState
    {
        get
        {
            return narState;
        }

        set
        {
            narState = value;
        }
    }

    public static Scene CurrentScene
    {
        get
        {
            return currentScene;
        }

        set
        {
            currentScene = value;
        }
    }

    public static int Planets
    {
        get
        {
            return planets;
        }

        set
        {
            planets = value;
        }
    }

    public static int PlanetCost
    {
        get
        {
            return planetCost;
        }

        set
        {
            planetCost = value;
        }
    }

    public static int Chefs
    {
        get
        {
            return chefs;
        }

        set
        {
            chefs = value;
        }
    }

    public static int ChefCost
    {
        get
        {
            return chefCost;
        }

        set
        {
            chefCost = value;
        }
    }

    public static int Factories
    {
        get
        {
            return factories;
        }

        set
        {
            factories = value;
        }
    }

    public static int FactCost
    {
        get
        {
            return factCost;
        }

        set
        {
            factCost = value;
        }
    }

    public static bool SubGraphicsSettings
    {
        get
        {
            return subGraphicsSettings;
        }

        set
        {
            subGraphicsSettings = value;
        }
    }

    public static bool SubGraphicsShop
    {
        get
        {
            return subGraphicsShop;
        }

        set
        {
            subGraphicsShop = value;
        }
    }

    public static bool SubGraphicsHelpers
    {
        get
        {
            return subGraphicsHelpers;
        }

        set
        {
            subGraphicsHelpers = value;
        }
    }

    public static bool SubGraphicsCandy
    {
        get
        {
            return subGraphicsCandy;
        }

        set
        {
            subGraphicsCandy = value;
        }
    }

    public static bool SubGraphicsBackground
    {
        get
        {
            return subGraphicsBackground;
        }

        set
        {
            subGraphicsBackground = value;
        }
    }

    public static bool SubGraphicsBuddy
    {
        get
        {
            return subGraphicsBuddy;
        }

        set
        {
            subGraphicsBuddy = value;
        }
    }

    public static bool SubGraphicsLvlbar
    {
        get
        {
            return subGraphicsLvlbar;
        }

        set
        {
            subGraphicsLvlbar = value;
        }
    }


    public static bool SubGraphicsNarrative
    {
        get
        {
            return subGraphicsNarrative;
        }

        set
        {
            subGraphicsNarrative = value;
        }
    }

    public static bool SubTake
    {
        get
        {
            return subTake;
        }

        set
        {
            subTake = value;
        }
    }

    public static bool SubAll
    {
        get
        {
            return subAll;
        }

        set
        {
            subAll = value;
        }
    }

    public static bool AppPaused
    {
        get
        {
            return appPaused;
        }

        set
        {
            appPaused = value;
        }
    }

    public static bool EndGame
    {
        get
        {
            return endGame;
        }

        set
        {
            endGame = value;
        }
    }

    public static bool DeadGame
    {
        get
        {
            return deadGame;
        }

        set
        {
            deadGame = value;
        }
    }

    public static bool HasQuit
    {
        get
        {
            return hasQuit;
        }

        set
        {
            hasQuit = value;
        }
    }

    public static int Click
    {
        get
        {
            return click;
        }

        set
        {
            click = value;
        }
    }

    public static int Help
    {
        get
        {
            return help;
        }

        set
        {
            help = value;
        }
    }

    public static int PerSec
    {
        get
        {
            return perSec;
        }

        set
        {
            perSec = value;
        }
    }

    public static float MusicVol
    {
        get
        {
            return musicVol;
        }

        set
        {
            musicVol = value;
        }
    }

    public static float SfxVol
    {
        get
        {
            return sfxVol;
        }

        set
        {
            sfxVol = value;
        }
    }

    public static float TimeSpent
    {
        get
        {
            return timeSpent;
        }

        set
        {
            timeSpent = value;
        }
    }

    public static int BuddyLevel
    {
        get
        {
            return buddyLevel;
        }

        set
        {
            buddyLevel = value;
        }
    }

    public static int BuddyBelly
    {
        get
        {
            return buddyBelly;
        }

        set
        {
            buddyBelly = value;
        }
    }
}

