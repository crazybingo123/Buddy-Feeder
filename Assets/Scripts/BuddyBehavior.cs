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
        Debug.Log("old units = " + oldUnits + ", new units = " + globalVariables.Units);
        Debug.Log("old click = " + oldClick + ", new click = " + globalVariables.Click);
        Debug.Log("Sad =" + globalVariables.sad);

        if (globalVariables.Units == oldUnits || globalVariables.Click == oldClick || globalVariables.Units == 0)
        {
            Debug.Log("getting sad");
            globalVariables.sad = true;
        }
        else
        {
            Debug.Log("happy");
            globalVariables.sad = false;
        }
        oldUnits = globalVariables.Units;
        oldClick = globalVariables.Click;
    }
}
