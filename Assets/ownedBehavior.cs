using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ownedBehavior : MonoBehaviour
{
    private Text ownedText;
    // Start is called before the first frame update
    void Start()
    {
        ownedText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
      ownedText.text =  "Chefs Owned: " + globalVariables.chefs;
    }

    public void ChangeUnits(int amt)
    {
        if (globalVariables.units - 10 >= 0)
        {
            globalVariables.chefs += amt;
            globalVariables.units -= 10;
        }
    }
}
