using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ownedBehavior : MonoBehaviour
{
    private Text ownedText;
    public string helpType;
    public int helpCost;

    // Start is called before the first frame update
    void Start()
    {
        ownedText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (helpType == "chef") 
    {
      ownedText.text =  "Chefs Owned: " + globalVariables.Chefs;
    }
        else if (helpType == "factory")
        {
            ownedText.text = "Factories Owned: " + globalVariables.Factories;
        }
        else if (helpType == "planet")
        {
            ownedText.text = "Planets Owned: " + globalVariables.Planets;
        }
    }
    public void ChangeUnits(int amt)
    {
        if (globalVariables.Units - helpCost >= 0)
        {
            if (helpType == "chef")
            {
                globalVariables.Chefs += amt;
                globalVariables.Help += amt;
                globalVariables.PerSec += 1;
            } else if (helpType == "factory")
            {
                globalVariables.Factories += amt;
                globalVariables.Help += amt;
                globalVariables.PerSec += 10;
            } else if (helpType == "planet")
            {
                globalVariables.Planets += amt;
                globalVariables.Help += amt;
                globalVariables.PerSec += 100;
            }
            globalVariables.Units -= helpCost;
        }
    }
}
