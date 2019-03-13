using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class globalVariables
{
    private static int units;
    private static int perSec;
    private static int help;
    private static int planets;
    private static int chefs;
    private static int factories;
    private static bool sub3;
    private static bool subTake;
    private static bool subAll;
    private static bool appPaused;
    private static int click;
    public static bool sfxMute;
    public static bool musicMute;
    public static bool sad;
    public static bool musicChange;
    public static bool sfxChange;
    private static float musicVol;
    private static float sfxVol;
    private static int timesQuit;

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

    public static bool Sub3
    {
        get
        {
            return sub3;
        }

        set
        {
            sub3 = value;
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

    public static int TimesQuit
    {
        get
        {
            return timesQuit;
        }

        set
        {
            timesQuit = value;
        }
    }
}

