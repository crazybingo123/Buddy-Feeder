using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class levelBarBehavior : MonoBehaviour
{
    private Slider levelSlider;
    private int levelGoal;
    private int levelStart;
    private int nextLevel;
    private int prevLevel;
    // Start is called before the first frame update
    void Start()
    {
        levelSlider = GetComponent<Slider>();
        levelSlider.minValue = 0;
        levelSlider.maxValue = 100;
        globalVariables.BuddyLevel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        levelSlider.value = globalVariables.BuddyBelly;


        if (globalVariables.BuddyLevel == 0)
        {
            levelStart = 0;
            levelGoal = 25;
            nextLevel = 1;
            prevLevel = 0;
        }//level 0: <25 candies fed, 25 to level 1
        else if (globalVariables.BuddyLevel == 1)
        {
            levelStart = 25;
            levelGoal = 50;
            nextLevel = 2;
            prevLevel = 0;
        }//level 1: 25 candies fed, 50 to level 2
        else if (globalVariables.BuddyLevel == 2)
        {
            levelStart = 50;
            levelGoal = 100;
            nextLevel = 3;
            prevLevel = 1;
        }//level 2: 50 candies fed, 100 to level 3
        else if (globalVariables.BuddyLevel == 3)
        {
            levelStart = 100;
            levelGoal = 200;
            nextLevel = 4;
            prevLevel = 2;
        }//level 3 100 candies fed, 200 to level 4
        else if (globalVariables.BuddyLevel == 4)
        {
            levelStart = 200;
            levelGoal = 350;
            nextLevel = 5;
            prevLevel = 3;
        }//level 4: 200 candies fed, 350 to level 5
        else if (globalVariables.BuddyLevel == 5)
        {
            levelStart = 350;
            levelGoal = 500;
            nextLevel = 6;
            prevLevel = 4;
        }//level 5: 350 candies fed, 500 to level 6

        if (globalVariables.BuddyBelly >= levelStart && globalVariables.BuddyBelly < levelGoal)
        {
            levelSlider.minValue = levelStart;
            levelSlider.maxValue = levelGoal;
        }
        else if (globalVariables.BuddyBelly >= levelGoal)
        {
            globalVariables.BuddyLevel = nextLevel;
        }
        else if (globalVariables.BuddyBelly < levelStart)
        {
            globalVariables.BuddyLevel = prevLevel;
        }

    }
}
