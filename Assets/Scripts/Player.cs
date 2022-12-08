using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string Pusername = "Öðrenci";
    public string Pgender = "Male";
    public float PmaxHealth = 100.0f;
    public float PmaxXP = 100.0f;
    public float PcurrentHealth;
    public float PcurrentXP;
    public float PCorrect;
    public float PWrong;
    public float PNotAnswered;
    public float PQuestionAnswered;
    public float Paccuracy = 0.0f;
    public float PDamage;
    public float PDefence;
    public float PCriticalChance;
    public float PCriticalDamage;
    public float PTotalDamage;
    public int PStat = 0;
    public int PCombo = 0;
    public int PHighscore;
    public int PScore = 0;
    public int level = 1;
    public int Gamelevel = 9;
    public int stage = 0;
    public int Piqcoin;

    public PlayerHealthbar healthBar;
    public PlayerXPBar playerxpbar;
    public Image image;
    public CharacterSelection characterSelection;
    private Sprite playerpicture;
    // Start is called before the first frame update
    void Start()
    {
        Pusername = characterSelection.UsName;
        Pgender = characterSelection.Gender;
        PmaxHealth = 100.0f;
        PmaxXP = 100.0f;
        PDamage = 50.0f;
        PDefence = 1.0f;
        PCriticalChance = 1.0f;
        PCriticalDamage = 200.0f;
        PcurrentXP = 0.0f;
        PStat = 0;
        PTotalDamage = PDamage;
        PcurrentHealth = PmaxHealth;
        healthBar.SetMaxHealth(PmaxHealth);
        healthBar.SetHealth(PcurrentHealth);
        playerxpbar.SetMaxXP(PmaxXP, level);
        playerxpbar.SetXP(PcurrentXP);
        if(PlayerPrefs.HasKey("IQPoints"))
        {
            UnityEngine.Debug.Log("IQPoints var.");
            Piqcoin = PlayerPrefs.GetInt("IQPoints", 0);
        }
        if (PlayerPrefs.HasKey("Highscore"))
        {
            UnityEngine.Debug.Log("Highscore var.");
            PHighscore = PlayerPrefs.GetInt("Highscore", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Pusername = characterSelection.UsName;
        Pgender = characterSelection.Gender;
        Gamelevel += 0;
        PCombo += 0;
        level += 0;
        stage += 0;
        PDamage += 0.0f;
        PDefence += 0.0f;
        PCriticalChance += 0.0f;
        PCriticalDamage += 0.0f;
        PcurrentHealth += 0.0f;
        PmaxHealth += 0.0f;
        PStat += 0;
        PTotalDamage = PDamage;
        healthBar.SetMaxHealth(PmaxHealth);
        healthBar.SetHealth(PcurrentHealth);
        playerxpbar.SetMaxXP(PmaxXP, level);
        playerxpbar.SetXP(PcurrentXP);
        if (PlayerPrefs.HasKey("IQPoints"))
        {
            Piqcoin = PlayerPrefs.GetInt("IQPoints", 0);
        }
        if (PlayerPrefs.HasKey("Highscore"))
        {
            PHighscore = PlayerPrefs.GetInt("Highscore", 0);
        }
    }
}
