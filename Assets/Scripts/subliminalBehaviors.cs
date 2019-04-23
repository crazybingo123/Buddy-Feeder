using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class subliminalBehaviors : MonoBehaviour
{
    GameObject graphicsObject;
    Image graphicsImage;
    Animator buddyAnim;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("TakeAway", 0.0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (globalVariables.SubGraphicsSettings)
        {
            GraphicsChange("Menu Icon");
        }
        if (globalVariables.SubGraphicsShop)
        {
            GraphicsChange("Shop Icon");
        }
        if (globalVariables.SubGraphicsCandy)
        {
            GraphicsChange("Candy");
        }
        if (globalVariables.SubGraphicsHelpers)
        {
            GraphicsChange("chef");
            GraphicsChange("factory");
            GraphicsChange("planet");
        }
        if (globalVariables.SubGraphicsBackground)
        {
            GraphicsChange("Background");
        }
        if (globalVariables.SubGraphicsBuddy)
        {
            GraphicsChange("Buddy");
        }
        if (globalVariables.SubGraphicsNarrative)
        {
            GraphicsChange("Narrative Panel");
        }

        if (globalVariables.SubGraphicsBuddy)
        {
            GraphicsChange("Buddy");
            graphicsObject = GameObject.Find("Buddy");
            buddyAnim = graphicsObject.GetComponent<Animator>();
            buddyAnim.runtimeAnimatorController = null;
        }

        if (globalVariables.SubGraphicsLvlbar)
        {
            GraphicsChange("Level Show");
            GraphicsChange("Level Background");
        }

        if (globalVariables.SubAll && globalVariables.BuddyBelly != 0)
        {
            TakeAll();
        }

        if (globalVariables.HasQuit)
        {
            globalVariables.DeadGame = true;
        }
    }

    void TakeAway()
    {
        if (globalVariables.SubTake && globalVariables.BuddyBelly != 0)
        {
            globalVariables.BuddyBelly--;
        }
    }
    //First subversive act: Level bar decreases each second.

    void TakeAll()
    {
        globalVariables.BuddyBelly = 0;
    }
    //Second subversive act: All level progress taken

    void GraphicsChange(string objName)
    {
        if (globalVariables.CurrentScene.name == "Main")
        {
            graphicsObject = GameObject.Find(objName);
            graphicsImage = graphicsObject.GetComponent<Image>();
            graphicsImage.sprite = null;
        }
    }
}
