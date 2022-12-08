using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.UI;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public Button skipCutscene;
    public GameObject Cutscene, musicmanagement;
    private int newPlayer = 1;

    public void PlayGame()
    {
        if(newPlayer == 1)
        {
            UnityEngine.Debug.Log("Opening CutScene");
            newPlayer = 0;
            PlayerPrefs.SetInt("FirstTime", newPlayer);
            Cutscene.SetActive(true);
            musicmanagement.SetActive(false);
        }
        else
        {
            UnityEngine.Debug.Log("Opening Game");
            Cutscene.SetActive(false);
            musicmanagement.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void Awake()
    {
        if (PlayerPrefs.HasKey("FirstTime"))
        {
            newPlayer = PlayerPrefs.GetInt("FirstTime", 1);
        }
    }

    public void Skip()
    {
        UnityEngine.Debug.Log("Skipping Cutscene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        musicmanagement.SetActive(true);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
         // Application.Quit() does not work in the editor so
         // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
         UnityEditor.EditorApplication.isPlaying = false;
#else
        UnityEngine.Debug.Log("Qutting");
        UnityEngine.Application.Quit();
#endif
    }
}
