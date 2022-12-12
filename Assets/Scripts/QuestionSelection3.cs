using UnityEngine;

public class QuestionSelection3 : MonoBehaviour // Tri Fonsiyonlar
{
    [SerializeField] private Questions questions;
    public void QuestionSelection(int randomQ)
    {
        if (randomQ == 1)
        {
            questions.Question.sprite = Resources.Load<Sprite>("Enemies/teacher");
            questions.correctAnswer = "9";
            questions.choiceA = "6";
            questions.choiceB = "7";
            questions.choiceC = "8";
            questions.choiceD = "9";
            questions.choiceE = "10";
        }
        else if (randomQ == 2)
        {
            questions.Question.sprite = Resources.Load<Sprite>("Enemies/teacher");
            questions.correctAnswer = "sinx";
            questions.choiceA = "cotx";
            questions.choiceB = "secx";
            questions.choiceC = "cosecx";
            questions.choiceD = "sinx";
            questions.choiceE = "cosx";
        }
        else if (randomQ == 3)
        {
            questions.Question.sprite = Resources.Load<Sprite>("Enemies/teacher");
            questions.correctAnswer = "-3/2";
            questions.choiceA = "-2/3";
            questions.choiceB = "-3/2";
            questions.choiceC = "1/3";
            questions.choiceD = "2/5";
            questions.choiceE = "3/7";
        }
    }
}
