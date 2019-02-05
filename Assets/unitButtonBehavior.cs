using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unitButtonBehavior : MonoBehaviour
{
    private Text unitText;
    // Start is called before the first frame update
    void Start()
    {
        unitText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        unitText.text = "Bread: " + globalVariables.units;
    }

    public void ChangeUnits(int amt)
    {
        globalVariables.units += amt;
    }

}
