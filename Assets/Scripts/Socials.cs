using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using static System.Net.Mime.MediaTypeNames;

public class Socials : MonoBehaviour
{
    public void OpenURL()
    {
#if UNITY_EDITOR
        string name = EventSystem.current.currentSelectedGameObject.name;
        if (name == "Facebook")
        {
            UnityEngine.Debug.Log("hello");
            UnityEngine.Application.OpenURL("https://www.facebook.com/");
        }
        else
        {
            UnityEngine.Debug.Log("hello2");
            UnityEngine.Application.OpenURL("https://www.google.com/");
        }
#else
        string name = EventSystem.current.currentSelectedGameObject.name;
        if (name == "Facebook")
        {
            UnityEngine.Debug.Log("Opening Facebook");
            UnityEngine.Application.OpenURL("https://www.facebook.com/");
        }
        else if (name == "Twitter")
        {
            UnityEngine.Debug.Log("Opening Twitter");
            UnityEngine.Application.OpenURL("https://www.google.com/");
        }
        else if (name == "Youtube")
        {
            UnityEngine.Debug.Log("Opening Youtube");
            UnityEngine.Application.OpenURL("https://www.youtube.com/");
        }
        else
        {
            UnityEngine.Debug.Log("Opening Instagram");
            UnityEngine.Application.OpenURL("https://www.instagram.com/");
        }
#endif
    }
}
