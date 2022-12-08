using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSettingsMenu : MonoBehaviour
{
    public Button quityes, resetyes;
    public Manager manager;

    public void QuitButton()
    {
        UnityEngine.Debug.Log("Quiting back to Main Menu");
        manager.QuittoMenu();
    }

    public void ResetDataButton()
    {
        UnityEngine.Debug.Log("Resetting Data!");
        manager.ResetData();
    }
}
