using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Question_", menuName = "bread/questions")]

public class QuestionDataSO : ScriptableObject
{
    public string questionTitle;
    public string questionText;
    public string answer;
}
