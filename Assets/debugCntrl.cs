using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugCntrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hold()
    {
        globalVariables.canHold = !globalVariables.canHold;
    }

    public void AddFactory()
    {
        globalVariables.Factories++;
    }
}
