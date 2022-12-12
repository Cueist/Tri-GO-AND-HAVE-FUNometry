using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagement : MonoBehaviour
{
    [SerializeField] private Button skipCutscene;
    [SerializeField] private GameObject Cutscene, musicmanagement;
    [SerializeField] private int newPlayer = 1;

    public void PlayGame()
    {
        if(newPlayer == 1) // Checking if it is the user's first time
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

    void Awake() // Checking the newPlayer status
    {
        if (PlayerPrefs.HasKey("FirstTime"))
        {
            newPlayer = PlayerPrefs.GetInt("FirstTime", 1);
        }
    }

    public void Skip() // Skip features for the Cutscene
    {
        UnityEngine.Debug.Log("Skipping Cutscene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Opening the next Scene(Game)
        musicmanagement.SetActive(true);
    }

    public void QuitGame() // Application.Quit() does not work in the editor so UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
    {
#if UNITY_EDITOR
        UnityEngine.Debug.Log("Qutting");
        UnityEditor.EditorApplication.isPlaying = false;
#else
        UnityEngine.Debug.Log("Qutting");
        UnityEngine.Application.Quit();
#endif
    }
}
