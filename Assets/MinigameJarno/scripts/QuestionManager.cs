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

    //Call this method if you want to generate a new random question
    public int NewQuestion(int dificulty = 1, int operater = 5)
    {
        if (operater >= 5)
        {
            op = Random.Range(0, 4);
        }
        else
        {
            op = operater;
        }

        bool questionMade = false;
        Debug.Log(op);
        answerText.text = "???";

        while (!questionMade)
        {
            switch (op)
            {
                case 0: //addition (+)
                    one = Random.Range(1, 101 * dificulty);
                    two = Random.Range(1, 101 * dificulty);
                    Debug.Log(one + " " + two);
                    correctAnswer = one + two;
                    if (correctAnswer <= 100 * dificulty)
                    {
                        questionMade = true;
                    }
                    break;
                case 1: //subtraction (-)
                    one = Random.Range(1, 101 * dificulty);
                    two = Random.Range(1, 101 * dificulty);
                    Debug.Log(one + " " + two);
                    if (one >= two)
                    {
                        correctAnswer = one - two;
                        questionMade = true;
                    }
                    break;
                case 2: //multiplication (x)
                    one = Random.Range(0, 11 * dificulty);
                    two = Random.Range(0, 13);
                    Debug.Log(one + " " + two);
                    correctAnswer = one * two;
                    questionMade = true;
                    break;
                case 3: //division (/)
                    one = Random.Range(1, 120 * dificulty);
                    two = Random.Range(1, 13);
                    float f = (float)one / (float)two;
                    Debug.Log(f);
                    int t = Mathf.RoundToInt(f);
                    if (f == t && t <= 10 * dificulty)
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

    //Check if the submitted answer is correct and send true or false back;
    public bool CheckAnswer(int answer)
    {
        answerText.text = answer.ToString();

        return answer == correctAnswer;
    }
}
