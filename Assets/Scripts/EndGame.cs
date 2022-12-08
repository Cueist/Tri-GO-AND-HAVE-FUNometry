using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public TextMeshProUGUI Titletext, stats, Username;
    public Button quittomainmenu;
    public Image userimage;
    public Player player;
    public CharacterSelection characterSelection;
    public Manager manager;

    void Start()
    {
        userimage.sprite = player.image.sprite;
        Username.text = player.Pusername + " - " + player.level;
        stats.text = "HIGHSCORE = " + player.PHighscore + "\n\nAccuracy = " + player.Paccuracy + "%" + "\n\nQuestion Answered = " + player.PQuestionAnswered + "\n\nCorrectly Answered = " + player.PCorrect + "\n\nWrongly Answered = " + player.PWrong +
            "\n\nDidn't Answered = " + player.PNotAnswered;
    }

    public void Win()
    {
        Titletext.text = "YOU WIN!";
        UnityEngine.Debug.Log("You Win!");
    }

    public void Lose()
    {
        Titletext.text = "YOU LOSE!";
        UnityEngine.Debug.Log("You Lose!");
    }

    public void QuitM()
    {
        UnityEngine.Debug.Log("Quitting to Main Menu!");
        manager.QuittoMenu();
    }
}
