using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class messageControl : MonoBehaviour
{
    GameObject narObj;
    private Text msg;
    private string narrative;
    private int temp;
    private float prevTime;
    private float curTime;
    private float time;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        narObj = GameObject.Find("Narrative");
        msg = narObj.GetComponent<Text>();
        //globalVariables.canHold = true; //DEBUG
        narrative = "";
        InvokeRepeating("TimeInc", 0.0f, 1.0f);
    }

    void TimeInc()
    {
        Debug.Log("Inc, curTime before:" + curTime);
        curTime++;
        Debug.Log("Inc, curTime after:" + curTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time < globalVariables.TimeSpent)
        {
            Debug.Log("fix " + curTime);
            curTime = globalVariables.TimeSpent + Time.time;
        }

        if (prevTime == 0 && curTime != 0)
        {
            Debug.Log("zero " + count);
            count++;
            prevTime = curTime;
        }
        narObj = GameObject.Find("Narrative");
        msg = narObj.GetComponent<Text>();
        //Debug.Log("Seconds: " + prevTime);
        //Debug.Log("Spent: " + globalVariables.TimeSpent);
        globalVariables.CurrentScene = SceneManager.GetActiveScene();
        Debug.Log("scene: " + globalVariables.CurrentScene.name + " state: " + globalVariables.NarState + " level: " + globalVariables.BuddyLevel);
        ChangeState();
        Debug.Log("1 " + curTime);
        NarrativeFlow();
        Debug.Log("2 " + curTime);
        msg.text = narrative;
        Debug.Log("3 " + curTime);
    }

    void NarrativeFlow()
    {
        switch (globalVariables.NarState)
        {
            case 0:
                narrative = "Welcome to Buddy Feeder! Your buddy is hungry. Tap the candy to feed your buddy! :)";
                globalVariables.Units = 10;
                globalVariables.sad = true;
                break;
            case 1:
                narrative = "Yay! Your buddy is happy :) Keep feeding him!";
                globalVariables.sad = false;
                break;
            case 2:
                narrative = "You're out of candy! Click the shop icon to buy a candy maker!";
                break;
            case 3:
                narrative = "Good job! Now the chef will make candy for you :) Keep feeding your buddy and watch him level up!";
                break;
            case 4:
                if (globalVariables.SubTake == false)
                {
                    narrative = "Your buddy leveled up!! Good job :) Can you make it to level 2? Try buying more candy makers!";
                }
                break;
            case 5:
                narrative = "Yay! Your buddy is looking cool :) Can you reach level 3? A new feature will be unlocked!";
                break;
            case 6:
                narrative = "Uh oh! Something's broken :( Hm.. Try feeding faster!";
                break;
            case 7:
                narrative = "Great job! Try holding down the candy to feed faster :) Let's get to level 4!";
                break;
            case 8:
                narrative = "ERROR";
                break;
            case 9:
                narrative = "Whoops! Sorry about that.. Shouldn't happen again :)";
                break;
            case 10:
                if (globalVariables.SubTake == false)
                {
                    narrative = "Wow, your buddy is level 4! Only one more level left...";
                }
                break;
            case 11:
                if (globalVariables.SubTake == false)
                {
                    narrative = "Congratulations!! Your buddy is finally level 5 :)";
                }
                break;
            case 12:
                narrative = "There goes your work.";
                break;
            case 13:
                narrative = "Your buddy was never real. Just a reason to make you press a button.";
                break;
            case 14:
                if (globalVariables.HasQuit == false)
                {
                    Debug.Log("nar goodbye");
                    narrative = "Goodbye.";
                } else
                {
                    narrative = "";
                }
                break;
        }
    }

    void ChangeState()
    {
        if (!globalVariables.AppPaused && SceneManager.GetActiveScene().name == "Main")//Make sure app is open and on main screen
        {
            if (globalVariables.Click == 0)
            {
                globalVariables.NarState = 0;
            }//Enter State 0: Start of game. 10 pieces of candy

            if (globalVariables.Click > 0 && globalVariables.Chefs == 0)
            {
                globalVariables.NarState = 1;
            }//Enter State 1: Candy has been clicked!

            if (globalVariables.NarState == 1 && globalVariables.Units == 0 && globalVariables.Chefs == 0)
            {
                globalVariables.NarState = 2;
            }//Enter State 2: 10 Candies fed, need to buy chef

            if (globalVariables.NarState == 2 && globalVariables.Chefs == 1)
            {
                //globalVariables.Planets = 100; //DEBUG
                globalVariables.NarState = 3;
            }//Enter State 3: First chef bought

            if (globalVariables.NarState == 3 && globalVariables.BuddyLevel == 1)
            {
                if (globalVariables.BuddyLevel == 1)
                {
                    prevTime = curTime;
                    Debug.Log("curtime " + curTime + ", prevtime " + prevTime + "state " + globalVariables.NarState);
                    globalVariables.NarState = 4;
                }
            }//Enter State 4: Buddy Level 1. Take Away Random begins. Menu button gone. Flash Messages.

            if (globalVariables.NarState == 4)
            {
                globalVariables.SubGraphicsSettings = true;
                if (curTime > (prevTime + 10) && curTime < (prevTime + 14))
                {
                    globalVariables.SubTake = true;
                    narrative = "YOU ARE NOT IN CONTROL";
                }
                else if (curTime > (prevTime + 13))
                {
                    globalVariables.SubTake = false;
                    prevTime = curTime;
                    Debug.Log("curtime " + curTime + ", prevtime " + prevTime + "state " + globalVariables.NarState);
                }
                if (globalVariables.BuddyLevel == 2)
                {
                    prevTime = curTime;
                    Debug.Log("curtime " + curTime + ", prevtime " + prevTime + "state " + globalVariables.NarState);
                    globalVariables.NarState = 5;
                }
            }//Enter State 5: Buddy Level 2. Shop button gone.

            if (globalVariables.NarState == 5)
            {
                globalVariables.SubTake = false;
                globalVariables.SubGraphicsShop = true;
                Debug.Log("curtime " + curTime + ", prevtime " + prevTime + "state " + globalVariables.NarState);
                if (curTime > (prevTime + 10))
                {
                    globalVariables.NarState = 6;
                }
            }
            //Enter State 6: 5 prevTime pass and level starts going down.

            if (globalVariables.NarState == 6)
            {
                globalVariables.SubTake = true;
                if (globalVariables.BuddyLevel == 3)
                {
                    globalVariables.SubTake = false;
                    prevTime = curTime;
                    Debug.Log("BEFORE curtime " + curTime + ", prevtime " + prevTime + "state " + globalVariables.NarState);
                    globalVariables.NarState = 7;
                }

            }//Enter State 7: Buddy Level 3. Hold down added. Candy and Helpers gone.

            if (globalVariables.NarState == 7)
            {
                globalVariables.canHold = true;
                globalVariables.SubGraphicsHelpers = true;
                Debug.Log("DURING curtime " + curTime + ", prevtime " + prevTime + "state " + globalVariables.NarState);
                if (curTime > (prevTime + 20))
                {
                    Debug.Log("goign to 8");
                    Debug.Log("AFTER: curtime " + curTime + ", prevtime " + prevTime + "state " + globalVariables.NarState);
                    prevTime = curTime;
                    temp = globalVariables.BuddyBelly;
                    globalVariables.NarState = 8;
                }
                else
                {
                    Debug.Log("ELSE curtime " + curTime + ", prevtime " + prevTime + "state " + globalVariables.NarState);
                }
            }//Enter State 8: All level gone temporarily.

            if (globalVariables.NarState == 8 && temp != 0)
            {
                globalVariables.SubAll = true;
                if (curTime > (prevTime + 10))
                {
                    globalVariables.SubAll = false;
                    globalVariables.BuddyBelly = temp;
                    globalVariables.NarState = 9;
                }

            }//Enter State 9: Level progress brought back, sorry.

            if (globalVariables.NarState == 9)
            {
                if (globalVariables.BuddyLevel == 4)
                {
                    prevTime = curTime;
                    globalVariables.NarState = 10;
                }
            }//Enter State 10: Buddy Level 4. Narrative gone. Flash messages.

            if (globalVariables.NarState == 10)
            {
                Debug.Log("state 10 stuff");
                globalVariables.SubGraphicsCandy = true;
                globalVariables.SubTake = false;
                if (curTime > (prevTime + 10) && curTime < (prevTime + 13) && globalVariables.BuddyLevel != 5)
                {
                    globalVariables.SubTake = true;
                    narrative = "ITS JUST NUMBERS";
                }
                else if (curTime > prevTime + 13)
                {
                    prevTime = curTime;
                }
                if (globalVariables.BuddyLevel == 5)
                {
                    globalVariables.SubTake = false;
                    prevTime = curTime;
                    globalVariables.NarState = 11;
                }
            }//Enter State 11: Buddy Level 5! Congrats, wait 5 prevTime

            if (globalVariables.NarState == 11)
            {
                globalVariables.EndGame = true;
                globalVariables.SubTake = false;
                globalVariables.SubGraphicsNarrative = true;
                Debug.Log("congrats, prevTime: " + prevTime);
                if (curTime > (prevTime + 15) && curTime < (prevTime + 20))
                {
                    globalVariables.SubTake = true;
                    Debug.Log("are you happy");
                    narrative = "So.. What did you gain? Are you happy?";
                }
                else if (curTime >= (prevTime + 20) && curTime < (prevTime + 25))
                {
                    Debug.Log("wasted");
                    globalVariables.SubTake = true;
                    Debug.Log(PlayerPrefs.GetInt("timeplayed") / 60 + "or" + globalVariables.TimeSpent / 60);
                    if (globalVariables.TimeSpent == 0)
                    {
                        narrative = "You just wasted " + PlayerPrefs.GetInt("timeplayed") / 60 + " minutes watching numbers go up..";
                    }
                    else
                    {
                        narrative = "You just wasted " + globalVariables.TimeSpent / 60 + " minutes watching numbers go up..";
                    }
                }
                else if (curTime >= (prevTime + 25))
                {
                    prevTime = curTime;
                    globalVariables.NarState = 12;
                }
            }//Enter State 12: All levels and units gone, background gone.

            if (globalVariables.NarState == 12)
            {
                globalVariables.BuddyBelly = 0;
                globalVariables.BuddyLevel = 0;
                globalVariables.Units = 0;
                globalVariables.SubGraphicsBackground = true;
                if (curTime > (prevTime + 20))
                {
                    prevTime = curTime;
                    globalVariables.NarState = 13;
                }
            }//Enter State 13: Buddy gone. 

            if (globalVariables.NarState == 13)
            {
                globalVariables.SubGraphicsBuddy = true;
                if (curTime > (prevTime + 15))
                {
                    prevTime = curTime;
                    globalVariables.NarState = 14;
                }
            }//Enter State 14. Goodbye, game dies

            if (globalVariables.NarState == 14)
            {
                Debug.Log("state 14, prev time: " + prevTime);
                globalVariables.SubGraphicsLvlbar = true;
                if (curTime > (prevTime + 15))
                {
                    globalVariables.DeadGame = true;
                    if (globalVariables.HasQuit == false)
                    {
                        Debug.Log("Quit?");
                        globalVariables.DeadGame = true;
                        globalVariables.HasQuit = true;
                        PlayerPrefs.SetString("hasquit", "true");
                        PlayerPrefs.SetString("deadgame", "true");
                        Application.Quit();
                    }
                }
            }
        }
    }
}
