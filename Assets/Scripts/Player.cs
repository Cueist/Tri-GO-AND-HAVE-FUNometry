using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string Pusername = "Öðrenci"; //Assigning Default Username value
    public string Pgender = "Male";  //Assigning Default gender value
    public float PmaxHealth = 100.0f;  //Assigning Default Max Health value
    public float PmaxXP = 100.0f;  //Assigning Default Max Experience value
    public float Paccuracy = 0.0f;  //Assigning Default Accuracy value
    public float PcurrentHealth;
    public float PcurrentXP;
    public float PCorrect;
    public float PWrong;
    public float PNotAnswered;
    public float PQuestionAnswered;
    public float PDamage;
    public float PDefence;
    public float PCriticalChance;
    public float PCriticalDamage;
    public float PTotalDamage;
    public int PStat = 0; //Assigning Default Stat value
    public int PCombo = 0;  //Assigning Default Combo value
    public int PScore = 0;  //Assigning Default Score value
    public int level = 1;   //Assigning Default Player Level value
    public int Gamelevel = 1;   //Assigning Default Game Level value
    public int stage = 0;   //Assigning Default Game Stage value
    public int PHighscore;
    public int Piqcoin;

    [SerializeField] private TextMeshProUGUI Username;
    [SerializeField] private PlayerHealthbar healthBar;
    public PlayerXPBar playerxpbar;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
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
        if (PlayerPrefs.HasKey("IQPoints")) // Checking if there was a Piqcoin value before
        {
            Piqcoin = PlayerPrefs.GetInt("IQPoints", 0);
        }
        if (PlayerPrefs.HasKey("Highscore")) // Checking if there was a PHighscore value before
        {
            PHighscore = PlayerPrefs.GetInt("Highscore", 0);
        }
    }
    void Update() // Updating the values so that it can change the values as the game goes on.
    {
        Gamelevel += 0;
        PCombo += 0;
        level += 0;
        stage += 0;
        PDamage += 0.0f;
        PDefence += 0.0f;
        PCriticalChance += 0.0f;
        PCriticalDamage += 0.0f;
        PcurrentHealth += 0.0f;
        PcurrentXP += 0.0f;
        PmaxHealth += 0.0f;
        PStat += 0;
        PTotalDamage = PDamage;
        healthBar.SetMaxHealth(PmaxHealth);
        healthBar.SetHealth(PcurrentHealth);
        Username.text = Pusername + " - Level " + level;
        if (PlayerPrefs.HasKey("IQPoints")) // Checking if there was a Piqcoin value before
        {
            Piqcoin = PlayerPrefs.GetInt("IQPoints", 0);
        }
        if (PlayerPrefs.HasKey("Highscore")) // Checking if there was a PHighscore value before
        {
            PHighscore = PlayerPrefs.GetInt("Highscore", 0);
        }
    }
}
