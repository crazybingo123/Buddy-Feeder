using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helpDisplayCtrl : MonoBehaviour
{
    private Text produce;
    private Text chefCount;
    private Text factoryCount;
    private Text planetCount;

    // Start is called before the first frame update
    void Start()
    {
        produce = GameObject.Find("helpProduce").GetComponent<Text>();
        chefCount = GameObject.Find("chefCnt").GetComponent<Text>();
        factoryCount = GameObject.Find("factoryCnt").GetComponent<Text>();
        planetCount = GameObject.Find("planetCnt").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!globalVariables.DeadGame || !globalVariables.HasQuit)
        {
            produce.text = "Helpers producing " + globalVariables.PerSec + " per Sec.";
            chefCount.text = "= " + globalVariables.Chefs;
            factoryCount.text = "= " + globalVariables.Factories;
            planetCount.text = "= " + globalVariables.Planets;
        } 
    }
}
