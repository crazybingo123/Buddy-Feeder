﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuCtrl : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        if (!globalVariables.EndGame)
        {
            SceneManager.LoadScene(sceneName);
        }       
    }
}