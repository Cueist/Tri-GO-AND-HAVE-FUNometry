using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    public TextMeshProUGUI enemyname;
    void Update()
    {
        healthBar.SetHealth(EcurrentHealth);
        enemyname.text = Ename + " - " + "Level " + Elevel.ToString();
    }

    public void EnemyChange(int gamelevel, int stage, int LevelScale) //Changing the enemy
    {
        int randomEnemy = UnityEngine.Random.Range(1, 8);
        int randomLevel = UnityEngine.Random.Range(1, LevelScale + 1);
        int randombosslevel = Random.Range(LevelScale+1, LevelScale * gamelevel);
        UnityEngine.Debug.Log("GameLevel = " + gamelevel + " - Stage = " + stage + " - Enemy Number = " + randomEnemy);
        if (gamelevel == 1 && stage == 10) // Level 1 Boss
        {
            Ename = "Pisagor";
            EmaxHealth = 175.0f + (25.0f * randombosslevel);
            EDamage = 7.5f + (2.5f * randombosslevel);
            EDefence = 1.5f + (0.5f * randombosslevel);
            ECriticalChance = 2.0f + (1.5f * randombosslevel);
            ECriticalDamage = 200.0f;
            Elevel = randombosslevel;
            Exp = 25.0f + (25.0f * randombosslevel);
            ETotalDamage = EDamage;
            EcurrentHealth = EmaxHealth;
            image.sprite = Resources.Load<Sprite>("Enemies/pisagor");
        }
        else if (gamelevel == 2 && stage == 10) // Level 2 Boss
        {
            Ename = "Cahit Arf";
            EmaxHealth = 150.0f + (20.0f * randombosslevel);
            EDamage = 10f + (2.5f * randombosslevel);
            EDefence = 2.0f + (0.5f * randombosslevel);
            ECriticalChance = 2.0f + (1.5f * randombosslevel);
            ECriticalDamage = 200.0f;
            Elevel = randombosslevel;
            Exp = 25.0f + (25.0f * randombosslevel);
            ETotalDamage = EDamage;
            EcurrentHealth = EmaxHealth;
            image.sprite = Resources.Load<Sprite>("Enemies/cahitarf");
        }
        else if (gamelevel == 3 && stage == 10) // Level 3 Boss
        {
            Ename = "Birûni";
            EmaxHealth = 250.0f + (25.0f * randombosslevel);
            EDamage = 10f + (2.5f * randombosslevel);
            EDefence = 2.0f + (0.5f * randombosslevel);
            ECriticalChance = 3.0f + (1.5f * randombosslevel);
            ECriticalDamage = 250.0f;
            Elevel = randombosslevel;
            Exp = 40.0f + (25.0f * randombosslevel);
            ETotalDamage = EDamage;
            EcurrentHealth = EmaxHealth;
            image.sprite = Resources.Load<Sprite>("Enemies/biruni");
        }
        else if (gamelevel == 4 && stage == 10) // Level 4 Boss
        {
            Ename = "Leonhard Euler";
            EmaxHealth = 150.0f + (25.0f * randombosslevel);
            EDamage = 20f + (2.5f * randombosslevel);
            EDefence = 1.5f + (0.5f * randombosslevel);
            ECriticalChance = 2.0f + (1.5f * randombosslevel);
            ECriticalDamage = 200.0f;
            Elevel = randombosslevel;
            Exp = 30.0f + (25.0f * randombosslevel);
            ETotalDamage = EDamage;
            EcurrentHealth = EmaxHealth;
            image.sprite = Resources.Load<Sprite>("Enemies/euler");
        }
        else if (gamelevel == 5 && stage == 10) // Level 5 Boss
        {
            Ename = "Wilhelm Leibniz";
            EmaxHealth = 150.0f + (25.0f * randombosslevel);
            EDamage = 15f + (2.5f * randombosslevel);
            EDefence = 1.0f + (0.5f * randombosslevel);
            ECriticalChance = 3.0f + (1.5f * randombosslevel);
            ECriticalDamage = 300.0f;
            Elevel = randombosslevel;
            Exp = 25.0f + (25.0f * randombosslevel);
            ETotalDamage = EDamage;
            EcurrentHealth = EmaxHealth;
            image.sprite = Resources.Load<Sprite>("Enemies/teacher");
        }
        else if (gamelevel == 6 && stage == 10) // Level 6 Boss
        {
            Ename = "Isaac Newton";
            EmaxHealth = 200.0f + (25.0f * randombosslevel);
            EDamage = 15f + (2.5f * randombosslevel);
            EDefence = 1.5f + (0.5f * randombosslevel);
            ECriticalChance = 5.0f + (1.5f * randombosslevel);
            ECriticalDamage = 200.0f;
            Elevel = randombosslevel;
            Exp = 50.0f + (25.0f * randombosslevel);
            ETotalDamage = EDamage;
            EcurrentHealth = EmaxHealth;
            image.sprite = Resources.Load<Sprite>("Enemies/newton");
        }
        else if (gamelevel == 7 && stage == 10) // Level 7 Boss
        {
            Ename = "Aryabhatta";
            EmaxHealth = 300.0f + (25.0f * randombosslevel);
            EDamage = 20f + (2.5f * randombosslevel);
            EDefence = 1.5f + (0.5f * randombosslevel);
            ECriticalChance = 2.0f + (1.5f * randombosslevel);
            ECriticalDamage = 200.0f;
            Elevel = randombosslevel;
            Exp = 25.0f + (25.0f * randombosslevel);
            ETotalDamage = EDamage;
            EcurrentHealth = EmaxHealth;
            image.sprite = Resources.Load<Sprite>("Enemies/aryabhatta");
        }
        else if (gamelevel == 7 && stage == 11) // Final Boss
        {
            Ename = "Nasir al-Din al-Tusi";
            EmaxHealth = 500.0f + (25.0f * randombosslevel);
            EDamage = 20f + (2.5f * randombosslevel);
            EDefence = 4.0f + (0.5f * randombosslevel);
            ECriticalChance = 3.0f + (1.5f * randombosslevel);
            ECriticalDamage = 400.0f;
            Elevel = randombosslevel;
            Exp = 100.0f + (25.0f * randombosslevel);
            ETotalDamage = EDamage;
            EcurrentHealth = EmaxHealth;
            image.sprite = Resources.Load<Sprite>("Enemies/nasir");
        }
        else
        {
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
                image.sprite = Resources.Load<Sprite>("Enemies/teacher");
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
                image.sprite = Resources.Load<Sprite>("Enemies/ilkokulöðrencisi");
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
                image.sprite = Resources.Load<Sprite>("Enemies/BaldingBully");
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
                EcurrentHealth = EmaxHealth; ;
                image.sprite = Resources.Load<Sprite>("Enemies/studentonduty");
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
                image.sprite = Resources.Load<Sprite>("Enemies/guard");
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
                image.sprite = Resources.Load<Sprite>("Enemies/guidanceteacher");
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
                image.sprite = Resources.Load<Sprite>("Enemies/schoolprincipal");
            }
        }
        healthBar.SetMaxHealth(EmaxHealth);
        healthBar.SetHealth(EcurrentHealth);
        enemyname.text = Ename + " - " + "Level " + Elevel.ToString();
    }
}
