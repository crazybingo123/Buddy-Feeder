using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class globalVariables
{
    public static int units, chefs;

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

}
