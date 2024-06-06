using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    [SerializeField] Text questionText;
    [SerializeField] Text answerText;

    char[] operators = { '+', '-', 'x', '÷' };
    int one = 0;
    int two = 0;
    int op = 0;
    int correctAnswer = 0;

    public int NewQuestion()
    {
        op = Random.Range(0, 4);
        bool questionMade = false;
        Debug.Log(op);
        answerText.text = "???";

        while (!questionMade)
        {
            switch (op)
            {
                case 0:
                    one = Random.Range(1, 101);
                    two = Random.Range(1, 101);
                    Debug.Log(one + " " + two);
                    correctAnswer = one + two;
                    questionMade = true;
                    break;
                case 1:
                    one = Random.Range(1, 101);
                    two = Random.Range(1, 101);
                    Debug.Log(one + " " + two);
                    if (one >= two)
                    {
                        correctAnswer = one - two;
                        questionMade = true;
                    }
                    break;
                case 2:
                    one = Random.Range(0, 11);
                    two = Random.Range(0, 13);
                    Debug.Log(one + " " + two);
                    correctAnswer = one * two;
                    questionMade = true;
                    break;
                case 3:
                    one = Random.Range(1, 120);
                    two = Random.Range(1, 13);
                    float f = (float)one / (float)two;
                    Debug.Log(f);
                    int t = Mathf.RoundToInt(f);
                    if (f == t && t <= 10)
                    {
                        correctAnswer = t;
                        questionMade = true;
                    }
                    break;
            }
        }

        questionText.text = one.ToString();
        questionText.text += " ";
        questionText.text += operators[op];
        questionText.text += " ";
        questionText.text += two.ToString();
        questionText.text += " =";
        return correctAnswer;
    }

    public bool CheckAnswer(int answer)
    {
        answerText.text = answer.ToString();

        return answer == correctAnswer;
    }
}
