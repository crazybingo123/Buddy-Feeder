using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class headerDisplay : MonoBehaviour
{
    private Text msg;
    // Start is called before the first frame update
    void Start()
    {
        msg = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!globalVariables.DeadGame)
        {
            msg.text = "Level";
        }

    }
}
