using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helpDisplayCtrl : MonoBehaviour
{
    public Text produce; 
    public Text chefCount;
    public Text factoryCount;
    public Text planetCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       produce.text = "Helpers producing " + globalVariables.PerSec+ " per Sec.";
       chefCount.text = "= " + globalVariables.Chefs;
       factoryCount.text = "= " + globalVariables.Factories;
       planetCount.text = "= " + globalVariables.Planets;

    }
}
