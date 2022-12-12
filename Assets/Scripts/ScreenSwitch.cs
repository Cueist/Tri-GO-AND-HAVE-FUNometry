using UnityEngine;

public class ScreenSwitch : MonoBehaviour
{
    [SerializeField] private GameObject Settings;

   void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // If ESC button is pressed, active the settings screen and pause the game.
        {
            if(Settings.activeSelf == true)
            {
                Settings.SetActive(false);
                Time.timeScale = 1; // Resume the game
            }
            else
            {
                Settings.SetActive(true);
                Time.timeScale = 0; // Pause the game
            }
        }
    }
}
