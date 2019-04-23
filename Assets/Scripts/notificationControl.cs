using System;
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
            if (pauseStatus)
            {
                globalVariables.AppPaused = true;
                if (!notificationSent)
                {
                    if (globalVariables.NarState < 5)
                    {
                        NotificationManager.Send(TimeSpan.FromSeconds(120), "Buddy is hungry!", "Come feed your buddy!", new Color(1, 0.3f, 0.15f));
                    }
                    else if (globalVariables.NarState >= 5 && globalVariables.NarState < 7)
                    {
                        NotificationManager.Send(TimeSpan.FromSeconds(60), "Buddy is hungry!", "FEED ME", new Color(1, 0.3f, 0.15f));
                    }
                    else if (globalVariables.NarState >= 7 && globalVariables.NarState < 11)
                    {
                        NotificationManager.Send(TimeSpan.FromSeconds(30), "COME BACK", "COME BACK", new Color(1, 0.3f, 0.15f));
                    } 
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
