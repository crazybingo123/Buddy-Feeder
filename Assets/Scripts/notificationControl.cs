using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.SimpleAndroidNotifications
{

    public class notificationControl : MonoBehaviour
    {
        void OnApplicationPause(bool pauseStatus)
        {
            if (pauseStatus)
            {
                globalVariables.AppPaused = true;
                NotificationManager.Send(TimeSpan.FromSeconds(60), "Buddy is hungry!", "Come feed your buddy!", new Color(1, 0.3f, 0.15f));
                globalVariables.sad = true;
            }
            else
            {
                globalVariables.AppPaused = false;
            }
        }
    }
}
