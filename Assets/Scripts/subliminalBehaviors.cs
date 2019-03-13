using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subliminalBehaviors : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TakeAway()
    {
        if (!globalVariables.AppPaused && globalVariables.Units >= 100)
        {
            globalVariables.SubTake = true;
        }
    }
    void Removal()
    {
        if (!globalVariables.AppPaused && globalVariables.Units >= 1000)
        {
            globalVariables.SubAll = true;
        }
    }
}
