using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helperButton : MonoBehaviour
{
    private Text msg;
    private int helperCost;
    public string helperType;
    // Start is called before the first frame update
    void Start()
    {
        msg = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (helperType == "Chef")
        {
            helperCost = globalVariables.ChefCost;
        }
        else if (helperType == "Factory")
        {
            helperCost = globalVariables.FactCost;
        }
        else if (helperType == "Planet")
        {
            helperCost = globalVariables.PlanetCost;
        }
        msg.text = "Buy for " + helperCost + " Candies";
    }
}
