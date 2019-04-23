using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ownedBehavior : MonoBehaviour
{
    private Text ownedText;
    public string helpType;

    // Start is called before the first frame update
    void Start()
    {
        if (globalVariables.ChefCost == 0)
        {
            globalVariables.ChefCost = 10;
        }
        if (globalVariables.FactCost == 0)
        {
            globalVariables.FactCost = 100;
        }
        if (globalVariables.PlanetCost == 0)
        {
            globalVariables.PlanetCost = 1000;
        }
        ownedText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (helpType == "chef")
        {
            ownedText.text = "Chefs Owned: " + globalVariables.Chefs;
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
        if (helpType == "chef")
        {
            if (globalVariables.Units - globalVariables.ChefCost >= 0)
            {
                globalVariables.Chefs += amt;
                globalVariables.Help += amt;
                globalVariables.PerSec += 1;
                globalVariables.Units -= globalVariables.ChefCost;
                globalVariables.ChefCost = Convert.ToInt32(globalVariables.ChefCost * 1.25);
            }
        }
        else if (helpType == "factory")
        {
            if (globalVariables.Units - globalVariables.FactCost >= 0)
            {
                globalVariables.Factories += amt;
                globalVariables.Help += amt;
                globalVariables.PerSec += 10;
                globalVariables.Units -= globalVariables.FactCost;
                globalVariables.FactCost = Convert.ToInt32(globalVariables.FactCost * 1.25);
            }
        }
        else if (helpType == "planet")
        {
            if (globalVariables.Units - globalVariables.PlanetCost >= 0)
            {
                globalVariables.Planets += amt;
                globalVariables.Help += amt;
                globalVariables.PerSec += 100;
                globalVariables.Units -= globalVariables.PlanetCost;
                globalVariables.PlanetCost = Convert.ToInt32(globalVariables.PlanetCost * 1.25);
            }
        }
    }
}
