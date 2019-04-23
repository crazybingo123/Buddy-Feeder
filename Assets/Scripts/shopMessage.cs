using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class shopMessage : MonoBehaviour
{
    private Text msg;
    GameObject chefObject;
    ownedBehavior ob;

    // Start is called before the first frame update
    void Start()
    {
        msg = GetComponent<Text>();
        GameObject chefObject = GameObject.FindGameObjectWithTag("chefOwned");
        ob = chefObject.GetComponent<ownedBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        globalVariables.CurrentScene = SceneManager.GetActiveScene();
        Debug.Log("scene:" + globalVariables.CurrentScene.name + "state:" + globalVariables.NarState);
        switch (globalVariables.NarState)
        {
            case 2:
                msg.text = "Great! Click the Buy button to buy a Candy Chef. This first one is on us :)";
                if (globalVariables.CurrentScene.name == "Shop")
                {
                    globalVariables.ChefCost = 0;
                }
                break;
            default:
                msg.text = "Candy: " + globalVariables.Units;
                break;
        }
        if (globalVariables.NarState == 2 && globalVariables.Chefs == 1)
        {
            globalVariables.ChefCost = 10;
            msg.text = "Nice! Return to your buddy!";
        }
    }
}
