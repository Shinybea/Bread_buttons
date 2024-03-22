using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class AnswerButton : MonoBehaviour
{
    [SerializeField] private QuestionSetup questionSetup;
 
    [SerializeField] public TextMeshProUGUI answerText;


    public void OnClick()
    { 
        Debug.Log("Answers given, answers received.");
        if(questionSetup.questions.Count > 0) 
        {
            questionSetup.GetQuestion();
        }
        else 
        {
            Debug.Log("No More Questions");
            EndGame();
        }
    }
    public void EndGame()
    {
        //What happens when there aren't any more questions?
        Application.Quit();
    }
}
