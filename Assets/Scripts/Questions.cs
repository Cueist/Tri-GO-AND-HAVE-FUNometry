using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Questions : MonoBehaviour
{
    private int randomQ, preQuestion;
    public Image Question;
    public string correctAnswer, choiceA, choiceB, choiceC, choiceD, choiceE;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private Button button1, button2, button3, button4, button5;
    [SerializeField] private Manager manager;
    [SerializeField] private float timeRemaining;
    [SerializeField] private bool timerIsRunning = false;
    [SerializeField] private QuestionSelection1 questionSelection1;
    [SerializeField] private QuestionSelection2 questionSelection2;
    [SerializeField] private QuestionSelection3 questionSelection3;
    void Start()
    {
        randomQ = UnityEngine.Random.Range(1, 4); // Add +1 to Max
        preQuestion = randomQ;
        QuestionPool(manager.player.Gamelevel); // Picking a question according to our Game Level
    }
    void Update()
    {
        if (timerIsRunning) // Checking-Updating the timer
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
    void DisplayTime(float timeToDisplay) // Displaying time
    {
        timeToDisplay += 1; // Adding +1 so that it shows 1 min instead of 0:59 (Becouse of the miliseconds)
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void QuestionPool(int GameLevel) // Our Question Pool
    {
        if (GameLevel == 1)
        {
            questionSelection1.QuestionSelection(randomQ); // Yönlü açýlar
        }
        else if (GameLevel == 2)
        {
            questionSelection2.QuestionSelection(randomQ); // Açý ölcü birimleri
        }
        else if (GameLevel == 3)
        {
            questionSelection3.QuestionSelection(randomQ); // Tri Fonsiyonlar
        }
        timeRemaining = 60;
        timerIsRunning = true;
        GameObject.Find("ChoiceA").GetComponentInChildren<Text>().text = choiceA;   //Configuring choiceA
        GameObject.Find("ChoiceB").GetComponentInChildren<Text>().text = choiceB;   //Configuring choiceB
        GameObject.Find("ChoiceC").GetComponentInChildren<Text>().text = choiceC;   //Configuring choiceC
        GameObject.Find("ChoiceD").GetComponentInChildren<Text>().text = choiceD;   //Configuring choiceD
        GameObject.Find("ChoiceE").GetComponentInChildren<Text>().text = choiceE;   //Configuring choiceE
    }

    public void TaskOnClickB1() //Checking the choiceA click interaction
    {
        button1.interactable = false;   //Disabling all of the buttons for the answer reveal and interaction
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
        button5.interactable = false;
        timerIsRunning = false;
        if (GameObject.Find("ChoiceA").GetComponentInChildren<Text>().text == correctAnswer.ToString()) //Checking if it is the right answer
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
    public void TaskOnClickB2() //Checking the choiceB click interaction
    {
        button1.interactable = false;   //Disabling all of the buttons for the answer reveal and interaction
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
        button5.interactable = false;
        timerIsRunning = false;
        if (GameObject.Find("ChoiceB").GetComponentInChildren<Text>().text == correctAnswer.ToString()) //Checking if it is the right answer
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
    public void TaskOnClickB3() //Checking the choiceC click interaction
    {
        button1.interactable = false;   //Disabling all of the buttons for the answer reveal and interaction
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
        button5.interactable = false;
        timerIsRunning = false;
        if (GameObject.Find("ChoiceC").GetComponentInChildren<Text>().text == correctAnswer.ToString()) //Checking if it is the right answer
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
    public void TaskOnClickB4() //Checking the choiceD click interaction
    {
        button1.interactable = false;   //Disabling all of the buttons for the answer reveal and interaction
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
        button5.interactable = false;
        timerIsRunning = false;
        if (GameObject.Find("ChoiceD").GetComponentInChildren<Text>().text == correctAnswer.ToString()) //Checking if it is the right answer
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
    public void TaskOnClickB5() //Checking the choiceE click interaction
    {
        button1.interactable = false;   //Disabling all of the buttons for the answer reveal and interaction
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
        button5.interactable = false;
        timerIsRunning = false;
        if (GameObject.Find("ChoiceE").GetComponentInChildren<Text>().text == correctAnswer.ToString()) //Checking if it is the right answer
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

    public void Correct() //Correct answer interactions
    {
        UnityEngine.Debug.Log("Correct Choice!");
        StartCoroutine(QuestionWaitTime()); // 0.5 seconds of wait time for the next question
        manager.CorrectChoice((int)timeRemaining);
        randomQ = UnityEngine.Random.Range(1, 4); // Randomly picking another question
        while (randomQ == preQuestion) // Checking the previous question number with the current one so that it doesn't repeat
        {
            randomQ = UnityEngine.Random.Range(1, 4);
        }
        preQuestion = randomQ; // Getting the last question number
    }

    public void Wrong() //Wrong answer interactions
    {
        UnityEngine.Debug.Log("Wrong Choice!");
        StartCoroutine(QuestionWaitTime()); // 0.5 seconds of wait time for the next question
        manager.WrongChoice();
        randomQ = UnityEngine.Random.Range(1, 4);   // Randomly picking another question
        while (randomQ == preQuestion)  // Checking the previous question number with the current one so that it doesn't repeat
        {
            randomQ = UnityEngine.Random.Range(1, 4);
        }
        preQuestion = randomQ;  // Getting the last question number
    }

    public void Empty() //Did not answered interactions
    {
        UnityEngine.Debug.Log("Out of time!");
        manager.EmptyAnswer();
        randomQ = UnityEngine.Random.Range(1, 4);   // Randomly picking another question
        while (randomQ == preQuestion)  // Checking the previous question number with the current one so that it doesn't repeat
        {
            randomQ = UnityEngine.Random.Range(1, 4);
        }
        preQuestion = randomQ;  // Getting the last question number
        if (GameObject.Find("ChoiceA").GetComponentInChildren<Text>().text == correctAnswer.ToString()) // Searching the Answer one by one because no button is clicked
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
        StartCoroutine(QuestionWaitTime()); // 0.5 seconds of wait time for the next question
    }

    IEnumerator QuestionWaitTime()
    {
        yield return new WaitForSeconds((float)0.5); // Will do the commands below after 0.5 secons
        button1.interactable = true; // Reseting the intractability of all of the buttons
        button2.interactable = true;
        button3.interactable = true;
        button4.interactable = true;
        button5.interactable = true;
        button1.GetComponent<Image>().color = Color.black; // Reseting all of the button's colors
        button2.GetComponent<Image>().color = Color.black;
        button3.GetComponent<Image>().color = Color.black;
        button4.GetComponent<Image>().color = Color.black;
        button5.GetComponent<Image>().color = Color.black;
        QuestionPool(manager.player.Gamelevel); // Picking a question according to our Game Level
    }
}
