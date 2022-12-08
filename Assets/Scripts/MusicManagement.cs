using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicManagement : MonoBehaviour
{
    public Slider Music, Volume;
    public AudioSource musicsample, volumesample, correctanswer, wronganswer, PNotAnswered;
    bool m_screenone, m_screentwo;
    public float defaultValueM = 0.2f, defaultValueV = 0.5f;

    void Start()
    {
        if (PlayerPrefs.HasKey("Music"))
        {
            Music.value = PlayerPrefs.GetFloat("Music", 0.20f);
        }
        if (PlayerPrefs.HasKey("Volume"))
        {
            Volume.value = PlayerPrefs.GetFloat("Volume", 0.50f);
        }
        defaultValueM = Music.value;
        defaultValueV = Volume.value;
        m_screenone = true;
        m_screentwo = true;
    }

    void Awake()
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
        defaultValueM = Music.value;
        defaultValueV = Volume.value;
        PlayerPrefs.SetFloat("Music", defaultValueM);
        PlayerPrefs.SetFloat("Volume", defaultValueV);
        if (SceneManager.GetActiveScene().buildIndex == 0 && m_screenone == true)
        {
            musicsample.Play();
            m_screenone = false;
            m_screentwo = true;
        }
        if (SceneManager.GetActiveScene().buildIndex == 1 && m_screentwo == true)
        {
            musicsample.Play();
            m_screentwo = false;
            m_screenone = true;
        }
    }

    void OnGUI()
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
