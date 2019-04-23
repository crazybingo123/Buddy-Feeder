using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class unitButtonBehavior : MonoBehaviour
{
    private Text unitText;
    private int amt;
    public bool pressed;

    // Start is called before the first frame update
    void Start()
    {
        amt = 1;
        unitText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!globalVariables.DeadGame)
        {
         unitText.text = "Candy: " + globalVariables.Units;
        }
    }

    public void ButtonPressed()
    {
        if (globalVariables.canHold)
        {
            InvokeRepeating("ChangeUnits", 0.0f, 0.05f); //0.2 usually
        }
    }
    public void ButtonUnpressed()
    {
        CancelInvoke();
    }

    public void ChangeUnits()
    {
        globalVariables.Click++;
        if (globalVariables.Units != 0 && globalVariables.NarState < 11 && globalVariables.SubAll == false)
        {
            globalVariables.Units -= 1;
            globalVariables.BuddyBelly += amt;
            globalVariables.sad = false;
        }
    }
}
