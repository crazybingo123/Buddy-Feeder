using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyBehavior : MonoBehaviour
{
    private int oldUnits = 0;
    private int oldClick = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("checkAction", 0.0f, 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void checkAction()
    {

        if (globalVariables.Units == oldUnits || globalVariables.Click == oldClick || globalVariables.Units == 0)
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
