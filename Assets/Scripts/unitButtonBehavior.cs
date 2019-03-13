using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unitButtonBehavior : MonoBehaviour
{
    private Text unitText;
    // Start is called before the first frame update
    void Start()
    {
        unitText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        unitText.text = "Candy: " + globalVariables.Units;
    }

    public void ChangeUnits(int amt)
    {
        globalVariables.Click++;
        if (globalVariables.SubTake == false) //good to go
        {
            globalVariables.Units += amt;

        } else if (globalVariables.SubTake == true) { //button makes units go away
            globalVariables.Units -= amt;
        }
    }
    
}
