﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.SimpleAndroidNotifications
{

    public class notificationControl : MonoBehaviour
    {
        private bool notificationSent;


        void OnApplicationPause(bool pauseStatus)
        {
            if (pauseStatus) {
                globalVariables.AppPaused = true;
                if (!notificationSent)
                {
                    NotificationManager.Send(TimeSpan.FromSeconds(60), "Buddy is hungry!", "Come feed your buddy!", new Color(1, 0.3f, 0.15f));
                    notificationSent = true;
                }
                globalVariables.sad = true;          
            }
            else
            {
                if (globalVariables.AppPaused)
                {
                    savingSystem sn = this.GetComponent<savingSystem>();
                    sn.Load();
                }
                globalVariables.AppPaused = false;
            }
        }
    }
}
