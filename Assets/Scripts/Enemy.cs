using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public string Ename;
    public int Elevel;
    public float EmaxHealth;
    public float EcurrentHealth;
    public float EDamage;
    public float EDefence;
    public float ECriticalChance;
    public float ECriticalDamage;
    public float Exp;
    public float ETotalDamage;

    public EnemyHealthbar healthBar;
    public Image image;
    private Sprite enemypicture;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        EmaxHealth += 0.0f;
        EcurrentHealth += 0.0f;
        EmaxHealth += 0.0f;
        Elevel += 0;
        EDamage += 0.0f;
        EDefence += 0.0f;
        ECriticalChance += 0.0f;
        ECriticalDamage += 0.0f;
        Exp += 0.0f;
        ETotalDamage += 0.0f;
        healthBar.SetHealth(EcurrentHealth);
    }

    public void EnemyChange(int gamelevel, int stage, int LevelScale)
    {
        int randomEnemy = UnityEngine.Random.Range(1, 8);
        int randomLevel = UnityEngine.Random.Range(1, LevelScale+1);
            UnityEngine.Debug.Log("GameLevel = " + gamelevel + " - Stage = " + stage + " - Enemy Number = " + randomEnemy);
            if (randomEnemy == 1)
            {
                Ename = "Matematik Öðretmeni";
                EmaxHealth = 175.0f + (25.0f * LevelScale);
                EDamage = 7.5f + (2.5f * LevelScale);
                EDefence = 1.5f + (0.5f * LevelScale);
                ECriticalChance = 2.0f + (1.5f * LevelScale);
                ECriticalDamage = 200.0f;
                Elevel = randomLevel;
                Exp = 25.0f + (25.0f * LevelScale);
                ETotalDamage = EDamage;
                EcurrentHealth = EmaxHealth;
                healthBar.SetMaxHealth(EmaxHealth);
                healthBar.SetHealth(EcurrentHealth);
                enemypicture = Resources.Load<Sprite>("Enemies/teacher");
                image.sprite = enemypicture;
            }
            else if (randomEnemy == 2)
            {
                Ename = "Ýlkokul Öðrencisi";
                EmaxHealth = 80.0f + (20.0f * LevelScale);
                EDamage = 3.75f + (1.25f * LevelScale);
                EDefence = 1.0f + (0.25f * LevelScale);
                ECriticalChance = 1.0f + (1.0f * LevelScale);
                ECriticalDamage = 200.0f;
                Elevel = randomLevel;
                Exp = 12.5f + (12.5f * LevelScale);
                ETotalDamage = EDamage;
                EcurrentHealth = EmaxHealth;
                healthBar.SetMaxHealth(EmaxHealth);
                healthBar.SetHealth(EcurrentHealth);
                enemypicture = Resources.Load<Sprite>("Enemies/ilkokulöðrencisi");
                image.sprite = enemypicture;
            }
            else if (randomEnemy == 3)
            {
                Ename = "Okulun Kabadayýsý";
                EmaxHealth = 250.0f + (15.0f * LevelScale);
                EDamage = 10f + (2.5f * LevelScale);
                EDefence = 2.5f + (0.5f * LevelScale);
                ECriticalChance = 2.0f + (1.5f * LevelScale);
                ECriticalDamage = 200.0f;
                Elevel = randomLevel;
                Exp = 50.0f + (50.0f * LevelScale);
                ETotalDamage = EDamage;
                EcurrentHealth = EmaxHealth;
                healthBar.SetMaxHealth(EmaxHealth);
                healthBar.SetHealth(EcurrentHealth);
                enemypicture = Resources.Load<Sprite>("Enemies/BaldingBully");
                image.sprite = enemypicture;
            }
            else if (randomEnemy == 4)
            {
                Ename = "Nöbetçi Öðrenci";
                EmaxHealth = 180.0f + (30.0f * LevelScale);
                EDamage = 20f + (5.5f * LevelScale);
                EDefence = 1.5f + (0.5f * LevelScale);
                ECriticalChance = 2.0f + (2.5f * LevelScale);
                ECriticalDamage = 250.0f;
                Elevel = randomLevel;
                Exp = 25.0f + (25.0f * LevelScale);
                ETotalDamage = EDamage;
                EcurrentHealth = EmaxHealth;
                healthBar.SetMaxHealth(EmaxHealth);
                healthBar.SetHealth(EcurrentHealth);
                enemypicture = Resources.Load<Sprite>("Enemies/studentonduty");
                image.sprite = enemypicture;
            }
            else if (randomEnemy == 5)
            {
                Ename = "Güvenlik Görevlisi";
                EmaxHealth = 250.0f + (50.0f * LevelScale);
                EDamage = 23.5f + (1.5f * LevelScale);
                EDefence = 6.5f + (1.5f * LevelScale);
                ECriticalChance = 1.0f + (0.5f * LevelScale);
                ECriticalDamage = 300f;
                Elevel = randomLevel;
                Exp = 35.0f + (35.0f * LevelScale);
                ETotalDamage = EDamage;
                EcurrentHealth = EmaxHealth;
                healthBar.SetMaxHealth(EmaxHealth);
                healthBar.SetHealth(EcurrentHealth);
                enemypicture = Resources.Load<Sprite>("Enemies/guard");
                image.sprite = enemypicture;
            }
            else if (randomEnemy == 6)
            {
                Ename = "Rehberlik Öðretmeni";
                EmaxHealth = 100.0f + (50.0f * LevelScale);
                EDamage = 15.5f + (1.5f * LevelScale);
                EDefence = 10.5f + (1.5f * LevelScale);
                ECriticalChance = 40.5f + (0.5f * LevelScale);
                ECriticalDamage = 75.0f;
                Elevel = randomLevel;
                Exp = 25.0f + (25.0f * LevelScale);
                ETotalDamage = EDamage;
                EcurrentHealth = EmaxHealth;
                healthBar.SetMaxHealth(EmaxHealth);
                healthBar.SetHealth(EcurrentHealth);
                enemypicture = Resources.Load<Sprite>("Enemies/guidanceteacher");
                image.sprite = enemypicture;
            }
            else if (randomEnemy == 7)
            {
                Ename = "Müdür";
                EmaxHealth = 1000.0f + (20.0f * LevelScale);
                EDamage = 10.5f + (1.5f * LevelScale);
                EDefence = 2.5f + (1.5f * LevelScale);
                ECriticalChance = 20.5f + (2.0f * LevelScale);
                ECriticalDamage = 345.0f;
                Elevel = randomLevel;
                Exp = 200.0f + (200.0f * LevelScale);
                ETotalDamage = EDamage;
                EcurrentHealth = EmaxHealth;
                healthBar.SetMaxHealth(EmaxHealth);
                healthBar.SetHealth(EcurrentHealth);
                enemypicture = Resources.Load<Sprite>("Enemies/schoolprincipal");
                image.sprite = enemypicture;
            }
    }
}
