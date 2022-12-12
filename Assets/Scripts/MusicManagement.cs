using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicManagement : MonoBehaviour
{
    [SerializeField] private Slider Music, Volume;
    [SerializeField] private bool m_screenone, m_screentwo;
    [SerializeField] private float defaultValueM = 0.2f, defaultValueV = 0.5f;
    public AudioSource musicsample, volumesample, correctanswer, wronganswer, PNotAnswered;

    void Start()
    {
        if (PlayerPrefs.HasKey("Music")) // Checking if there was a saved Music value before
        {
            Music.value = PlayerPrefs.GetFloat("Music", 0.20f);
        }
        if (PlayerPrefs.HasKey("Volume")) // Checking if there was a saved Volume value before
        {
            Volume.value = PlayerPrefs.GetFloat("Volume", 0.50f);
        }
        defaultValueM = Music.value;
        defaultValueV = Volume.value;
        m_screenone = true;
        m_screentwo = true;
    }

    void Awake() // Adding Music and Volue values, If there was a saved Music, Volume values
    {
        if (PlayerPrefs.HasKey("Music"))
        {
            Music.value = PlayerPrefs.GetFloat("Music", 0.20f);
        }
        if (PlayerPrefs.HasKey("Volume"))
        {
            Volume.value = PlayerPrefs.GetFloat("Volume", 0.50f);
        }
    }

    void Update()
    {
        defaultValueM = Music.value; // Updating the values according to the slider's values
        defaultValueV = Volume.value;
        PlayerPrefs.SetFloat("Music", defaultValueM);
        PlayerPrefs.SetFloat("Volume", defaultValueV);
        if (SceneManager.GetActiveScene().buildIndex == 0 && m_screenone == true) // Playing the music even when the scenes switched (For Menu)
        {
            musicsample.Play();
            m_screenone = false;
            m_screentwo = true;
        }
        if (SceneManager.GetActiveScene().buildIndex == 1 && m_screentwo == true) // Playing the music even when the scenes switched (For Game)
        {
            musicsample.Play();
            m_screentwo = false;
            m_screenone = true;
        }
    }

    void OnGUI() // Configure the values on GUI change
    {
        musicsample.volume = defaultValueM;
        Music.value = defaultValueM;
        volumesample.volume = defaultValueV;
        Volume.value = defaultValueV;
        correctanswer.volume = defaultValueV;
        wronganswer.volume = defaultValueV;
        PNotAnswered.volume = defaultValueV;
    }

}
