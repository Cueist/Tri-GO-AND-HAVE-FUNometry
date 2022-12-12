using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Manager : MonoBehaviour
{
    public Player player;
    public Enemy enemy;
    public Questions questions;
    public GameObject GameScreen, EndGame, GameSettingsMenu, LevelupPart, EndGameWindow, CharacterSelectionpart;
    public MiddlePart middlepart;
    public EndGame endgame;
    public MusicManagement MusicManagement;
    public CharacterSelection CharacterSelection;
    public StageBar StageBar;
    public TextMeshProUGUI GameLevel, Combopoints, Highscorepoints, Scorepoints;
    public ItemContainer itemcontainer;
    public bool selectedContinue = false, endchoice = false;
    // Start is called before the first frame update
    void Start()
    {
        StageBar.SetStage(player.stage);
        middlepart.AccText(player.Paccuracy);
        middlepart.IQText(player.Piqcoin);
        if (PlayerPrefs.HasKey("Highscore"))
        {
            Highscorepoints.text = " " + PlayerPrefs.GetInt("Highscore", 0).ToString();
        }
        if (PlayerPrefs.HasKey("IQPoints"))
        {
            middlepart.IQText(PlayerPrefs.GetInt("IQPoints", 0));
        }
        enemy.EnemyChange(player.Gamelevel, player.stage, player.level);
        GameLevel.text = "" + player.Gamelevel + ".Level";
    }
    public void End()
    {
        if(player.PcurrentHealth > 0 && player.Gamelevel > 7)
        {
            GameScreen.SetActive(false);
            EndGame.SetActive(true);
            endgame.Win();
        }
        else if(player.Gamelevel > 7 && player.PcurrentHealth <= 0)
        {
            GameScreen.SetActive(false);
            EndGame.SetActive(true);
            endgame.Win();
        }
        else if(player.PcurrentHealth <= 0)
        {
            GameScreen.SetActive(false);
            EndGame.SetActive(true);
            endgame.Lose();
        }
        else
        {
            GameScreen.SetActive(false);
            EndGame.SetActive(true);
            endgame.Win();
        }
    }

    public void CorrectChoice(int timeRemaining)
    {
        player.PQuestionAnswered++;
        player.PCorrect++;
        player.Piqcoin++;
        player.PCombo++;
        PlayerPrefs.SetInt("IQPoints", player.Piqcoin);
        Combopoints.text = " " + player.PCombo.ToString() + "X";
        MusicManagement.correctanswer.Play();
        middlepart.IQText(player.Piqcoin);
        Score(timeRemaining);
        EnemyTakeDamage();
        PlayerAccuracy();
    }

    public void WrongChoice()
    {
        player.PQuestionAnswered++;
        player.PWrong++;
        player.PCombo = 0;
        Combopoints.text = " " + player.PCombo.ToString();
        MusicManagement.wronganswer.Play();
        PlayerTakeDamage();
        PlayerAccuracy();
    }

    public void EmptyAnswer()
    {
        player.PQuestionAnswered++;
        player.PWrong++;
        player.PCombo = 0;
        Combopoints.text = " " + player.PCombo.ToString();
        MusicManagement.PNotAnswered.Play();
        PlayerTakeDamage();
        PlayerAccuracy();
    }

    public void Score(int timeRemaining)
    {
        if (player.PCombo == 0)
        {
            player.PScore += 10 * timeRemaining;
        }
        else
        {
            player.PScore += (10 * player.PCombo) * timeRemaining;
        }
        Scorepoints.text = " " + player.PScore.ToString();
        if(player.PScore >= player.PHighscore)
        {
            player.PHighscore = player.PScore;
            PlayerPrefs.SetInt("Highscore", player.PHighscore);
            Highscorepoints.text = " " + player.PHighscore.ToString();

        }
    }

    public void ResetData()
    {
        PlayerPrefs.DeleteKey("Highscore");
        PlayerPrefs.DeleteKey("IQPoints");
        PlayerPrefs.DeleteKey("FirstTime");
        ContinueTime();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        StartCoroutine(FPSCountdown());
    }

    public void QuittoMenu()
    {
        ContinueTime();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        StartCoroutine(FPSCountdown());
    }

    IEnumerator FPSCountdown()
    {
        yield return new WaitForSeconds((float)1);
        CharacterSelectionpart.SetActive(true);
        GameSettingsMenu.SetActive(false);
        EndGame.SetActive(false);
    }



    public void PlayerTakeDamage()
    {
        if (player.PcurrentHealth > 0.0f)
        {
            if(player.PDefence < enemy.ETotalDamage)
            {
                player.PcurrentHealth -= enemy.ETotalDamage - player.PDefence;
            }
            UnityEngine.Debug.Log("Damage Taken = " + enemy.ETotalDamage);
            if (player.PcurrentHealth <= 0.0f)
            {
                End();
            }
        }
    }
    public void PlayerLevelling(float remainingxp)
    {
        player.level++;
        player.PmaxHealth += 10.0f;
        player.PcurrentHealth += 10.0f;
        player.PDamage += 5.0f;
        player.PDefence += 1.0f;
        player.PCriticalChance += 1.0f;
        player.PCriticalDamage += 1.0f;
        player.PcurrentXP = remainingxp;
        player.PStat++;
        player.playerxpbar.SetMaxXP(player.PmaxXP, player.level);
        UnityEngine.Debug.Log("Level Up!");
        LevelupPart.SetActive(true);
        StartCoroutine(LevelupCountdown());
    }

    IEnumerator LevelupCountdown()
    {
        yield return new WaitForSeconds((float)0.5);
        LevelupPart.SetActive(false);
    }

    public void PlayerAccuracy()
    {
        player.Paccuracy = (player.PCorrect / player.PQuestionAnswered) * 100.0f;
        middlepart.AccText(player.Paccuracy);
        UnityEngine.Debug.Log("Player acc = " + player.Paccuracy);
    }

    public void EnemyTakeDamage()
    {
        if (enemy.EcurrentHealth > 0.0f)
        {
            if (UnityEngine.Random.Range(1, 101) <= player.PCriticalChance)
            {
                player.PTotalDamage = player.PDamage * (player.PCriticalDamage / 100.0f);
                UnityEngine.Debug.Log("Critical Damage!");
            }
            if (enemy.EDefence < player.PTotalDamage)
            {
                enemy.EcurrentHealth -= player.PTotalDamage - enemy.EDefence;
            }
            UnityEngine.Debug.Log("Damage Dealt = " + player.PTotalDamage);
            if (enemy.EcurrentHealth <= 0.0f)
            {
                player.PcurrentXP += enemy.Exp;
                player.playerxpbar.SetXP(player.PcurrentXP);
                player.Piqcoin++;
                player.stage++;
                if (player.Gamelevel == 7 && player.stage == 12 && selectedContinue == false && endchoice == false)
                {
                    GameLevel.text = "Sonsuz Mod...";
                    WantingtoEnd(selectedContinue);
                    endchoice = true;
                }
                else if (player.stage > 10 && (player.Gamelevel != 7 && player.stage != 11))
                {
                    player.Gamelevel++;
                    player.stage = 0;
                    itemcontainer.Quality(100);
                    GameLevel.text = "" + player.Gamelevel + ".Level";
                }
                else
                {
                    itemcontainer.Quality(UnityEngine.Random.Range(1, 101));
                }
                StageBar.SetStage(player.stage);
                enemy.EnemyChange(player.Gamelevel, player.stage, player.level);
            }
        }
    }

    public void WantingtoEnd(bool ContinueChoice)
    {
        EndGameWindow.SetActive(true);
        Time.timeScale = 0;
        selectedContinue = ContinueChoice;
        if (selectedContinue)
        {
            Time.timeScale = 1;
            End();
        }
    }

    public void ContinueTime()
    {
        Time.timeScale = 1;
    }
}
