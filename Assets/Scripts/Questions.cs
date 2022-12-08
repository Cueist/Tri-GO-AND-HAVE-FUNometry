using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Diagnostics;
using System;

public class Questions : MonoBehaviour
{
    public TextMeshProUGUI Question;
    public Button button1, button2, button3, button4, button5;
    private int randomQ, preQuestion;
    private string correctAnswer, choiceA, choiceB, choiceC, choiceD, choiceE;
    public Manager manager;
    public float timeRemaining = 60;
    public bool timerIsRunning = false;
    public TextMeshProUGUI timeText;
    // Start is called before the first frame update
    void Start()
    {
        randomQ = UnityEngine.Random.Range(1, 4); //max a +1 ekle
        preQuestion = randomQ;
        QuestionPool(manager.PlayerStage());
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining <= 0)
            {
                UnityEngine.Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                Empty();
            }
            else
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void QuestionPool(int stage)
    {
        if (stage >= 0 && stage <= 10)
        {
            QuestionSelection9(randomQ);
        }
        timeRemaining = 60;
        timerIsRunning = true;
        GameObject.Find("ChoiceA").GetComponentInChildren<Text>().text = choiceA;
        GameObject.Find("ChoiceB").GetComponentInChildren<Text>().text = choiceB;
        GameObject.Find("ChoiceC").GetComponentInChildren<Text>().text = choiceC;
        GameObject.Find("ChoiceD").GetComponentInChildren<Text>().text = choiceD;
        GameObject.Find("ChoiceE").GetComponentInChildren<Text>().text = choiceE;
    }

    public void TaskOnClickB1()
    {
        button1.interactable = false;
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
        button5.interactable = false;
        timerIsRunning = false;
        if (GameObject.Find("ChoiceA").GetComponentInChildren<Text>().text == correctAnswer.ToString())
        {
            button1.GetComponent<Image>().color = Color.green;
            Correct();
        }
        else
        {
            button1.GetComponent<Image>().color = Color.red;
            Wrong();
        }
    }
    public void TaskOnClickB2()
    {
        button1.interactable = false;
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
        button5.interactable = false;
        timerIsRunning = false;
        if (GameObject.Find("ChoiceB").GetComponentInChildren<Text>().text == correctAnswer.ToString())
        {
            button2.GetComponent<Image>().color = Color.green;
            Correct();
        }
        else
        {
            button2.GetComponent<Image>().color = Color.red;
            Wrong();
        }
    }
    public void TaskOnClickB3()
    {
        button1.interactable = false;
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
        button5.interactable = false;
        timerIsRunning = false;
        if (GameObject.Find("ChoiceC").GetComponentInChildren<Text>().text == correctAnswer.ToString())
        {
            button3.GetComponent<Image>().color = Color.green;
            Correct();
        }
        else
        {
            button3.GetComponent<Image>().color = Color.red;
            Wrong();
        }
    }
    public void TaskOnClickB4()
    {
        button1.interactable = false;
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
        button5.interactable = false;
        timerIsRunning = false;
        if (GameObject.Find("ChoiceD").GetComponentInChildren<Text>().text == correctAnswer.ToString())
        {
            button4.GetComponent<Image>().color = Color.green;
            Correct();
        }
        else
        {
            button4.GetComponent<Image>().color = Color.red;
            Wrong();
        }
    }
    public void TaskOnClickB5()
    {
        button1.interactable = false;
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
        button5.interactable = false;
        timerIsRunning = false;
        if (GameObject.Find("ChoiceE").GetComponentInChildren<Text>().text == correctAnswer.ToString())
        {
            button5.GetComponent<Image>().color = Color.green;
            Correct();
        }
        else
        {
            button5.GetComponent<Image>().color = Color.red;
            Wrong();
        }
    }

    public void Correct()
    {
        UnityEngine.Debug.Log("Correct Choice!");
        StartCoroutine(QuestionWaitTime());
        manager.CorrectChoice((int)timeRemaining);
        randomQ = UnityEngine.Random.Range(1, 4);
        while (randomQ == preQuestion)
        {
            randomQ = UnityEngine.Random.Range(1, 4);
        }
        preQuestion = randomQ;
    }

    public void Wrong()
    {
        UnityEngine.Debug.Log("Wrong Choice!");
        StartCoroutine(QuestionWaitTime());
        manager.WrongChoice();
        randomQ = UnityEngine.Random.Range(1, 4);
        while (randomQ == preQuestion)
        {
            randomQ = UnityEngine.Random.Range(1, 4);
        }
        preQuestion = randomQ;
    }

    public void Empty()
    {
        UnityEngine.Debug.Log("Out of time!");
        manager.EmptyAnswer();
        randomQ = UnityEngine.Random.Range(1, 4);
        while (randomQ == preQuestion)
        {
            randomQ = UnityEngine.Random.Range(1, 4);
        }
        preQuestion = randomQ;
        if (GameObject.Find("ChoiceA").GetComponentInChildren<Text>().text == correctAnswer.ToString())
        {
            button1.GetComponent<Image>().color = Color.green;
        }
        else if(GameObject.Find("ChoiceB").GetComponentInChildren<Text>().text == correctAnswer.ToString())
        {
            button2.GetComponent<Image>().color = Color.green;
        }
        else if (GameObject.Find("ChoiceC").GetComponentInChildren<Text>().text == correctAnswer.ToString())
        {
            button3.GetComponent<Image>().color = Color.green;
        }
        else if (GameObject.Find("ChoiceD").GetComponentInChildren<Text>().text == correctAnswer.ToString())
        {
            button4.GetComponent<Image>().color = Color.green;
        }
        else if (GameObject.Find("ChoiceE").GetComponentInChildren<Text>().text == correctAnswer.ToString())
        {
            button5.GetComponent<Image>().color = Color.green;
        }
        StartCoroutine(QuestionWaitTime());
    }

    IEnumerator QuestionWaitTime()
    {
        yield return new WaitForSeconds((float)0.5);
        button1.interactable = true;
        button2.interactable = true;
        button3.interactable = true;
        button4.interactable = true;
        button5.interactable = true;
        button1.GetComponent<Image>().color = Color.black;
        button2.GetComponent<Image>().color = Color.black;
        button3.GetComponent<Image>().color = Color.black;
        button4.GetComponent<Image>().color = Color.black;
        button5.GetComponent<Image>().color = Color.black;
        QuestionPool(manager.PlayerStage());
    }

    public void QuestionSelection9(int randomQ)
    {
        if(randomQ == 1)
        {
            Question.text = "A = 2 + 4sinx olduðuna göre A nýn alabileceði kaç farklý tamsayý deðeri vardýr?";
            correctAnswer = "9";
            choiceA = "6";
            choiceB = "7";
            choiceC = "8";
            choiceD = "9";
            choiceE = "10";
        }
        else if (randomQ == 2)
        {
            Question.text = "tanx.cosx ifadesinin sadeleþmiþ þekli aþaðýdakilerden hangisidir?";
            correctAnswer = "sinx";
            choiceA = "cotx";
            choiceB = "secx";
            choiceC = "cosecx";
            choiceD = "sinx";
            choiceE = "cosx";
        }
        else if (randomQ == 3)
        {
            Question.text = "A = secx olmak üzere A sayýsý aþaðýdakilerden hangisi olabilir?";
            correctAnswer = "-3/2";
            choiceA = "-2/3";
            choiceB = "-3/2";
            choiceC = "1/3";
            choiceD = "2/5";
            choiceE = "3/7";
        }
    }
}
