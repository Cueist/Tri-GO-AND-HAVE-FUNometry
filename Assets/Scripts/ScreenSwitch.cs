using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSwitch : MonoBehaviour
{
    public GameObject Settings;

   void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Settings.activeSelf == true)
            {
                Settings.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                Settings.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
