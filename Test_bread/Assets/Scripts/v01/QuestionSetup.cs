using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class QuestionSetup : MonoBehaviour
{
    [SerializeField] public List<QuestionDataSO> questions;
    public QuestionDataSO currentQuestion1;
    public QuestionDataSO currentQuestion2;

    [SerializeField] public TextMeshProUGUI questionTitle1;
    [SerializeField] public TextMeshProUGUI questionText1;    
    
    [SerializeField] public TextMeshProUGUI questionTitle2;
    [SerializeField] public TextMeshProUGUI questionText2;

    [SerializeField] public AnswerButton answerButton;

   

    private void Awake()
    {
        GetQuestionAssets();
    }
   
    public void GetQuestion()
    {
        SelectNewQuestion();
        SetQuestionValues();
    }

    private void GetQuestionAssets() 
    {
        questions = new List<QuestionDataSO>(Resources.LoadAll<QuestionDataSO>("Questions"));
    }
    private void SelectNewQuestion()
    {
        int randomQuestionIndex = Random.Range(0, questions.Count);         //randomize selection
        currentQuestion1 = questions[randomQuestionIndex];                  //choose question
        Debug.Log(randomQuestionIndex);
        questions.RemoveAt(randomQuestionIndex);                            //remove from list

        randomQuestionIndex = Random.Range(0, questions.Count);             //same for question 2
        currentQuestion2 = questions[randomQuestionIndex];                  
        Debug.Log(randomQuestionIndex);
        questions.RemoveAt(randomQuestionIndex);
    }

    private void SetQuestionValues()
    {
        questionTitle1.text = currentQuestion1.questionTitle;
        questionText1.text = currentQuestion1.questionText;
        questionTitle2.text = currentQuestion2.questionTitle;
        questionText2.text = currentQuestion2.questionText;
    }

    public void ClickQuestion1()
    {
        answerButton.answerText.text = currentQuestion1.answer;
    }
    public void ClickQuestion2()
    {
        answerButton.answerText.text = currentQuestion2.answer;
    }
}
