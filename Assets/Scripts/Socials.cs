using UnityEngine;
using UnityEngine.EventSystems;

public class Socials : MonoBehaviour
{
    public void OpenURL() // Opening our social accounts
    {
#if UNITY_EDITOR
        string name = EventSystem.current.currentSelectedGameObject.name;
        if (name == "Facebook")
        {
            UnityEngine.Debug.Log("Opening Facebook");
            UnityEngine.Application.OpenURL("https://www.facebook.com/profile.php?id=100088830513161");
        }
        else if (name == "Twitter")
        {
            UnityEngine.Debug.Log("Opening Twitter");
            UnityEngine.Application.OpenURL("https://twitter.com/triGOANDHAVEFUN");
        }
        else if (name == "Youtube")
        {
            UnityEngine.Debug.Log("Opening Youtube");
            UnityEngine.Application.OpenURL("https://www.youtube.com/@trigoandhavefunometry");
        }
        else if (name == "Instagram")
        {
            UnityEngine.Debug.Log("Opening Instagram");
            UnityEngine.Application.OpenURL("https://www.instagram.com/trigoandhavefunometry/");
        }
#else
        string name = EventSystem.current.currentSelectedGameObject.name;
        if (name == "Facebook")
        {
            UnityEngine.Debug.Log("Opening Facebook");
            UnityEngine.Application.OpenURL("https://www.facebook.com/profile.php?id=100088830513161");
        }
        else if (name == "Twitter")
        {
            UnityEngine.Debug.Log("Opening Twitter");
            UnityEngine.Application.OpenURL("https://twitter.com/triGOANDHAVEFUN");
        }
        else if (name == "Youtube")
        {
            UnityEngine.Debug.Log("Opening Youtube");
            UnityEngine.Application.OpenURL("https://www.youtube.com/@trigoandhavefunometry");
        }
        else if (name == "Instagram")
        {
            UnityEngine.Debug.Log("Opening Instagram");
            UnityEngine.Application.OpenURL("https://www.instagram.com/trigoandhavefunometry/");
        }
#endif
    }
}
