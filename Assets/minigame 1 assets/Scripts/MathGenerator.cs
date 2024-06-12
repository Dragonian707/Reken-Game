using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MathGenerator : MonoBehaviour
{
    int FirstRandomNumber;
    int SecondRandomNumber;
    int CorrectAnswer;
    int[] Answers = new int[4];

    [SerializeField] TMP_Text displayNumber1;
    [SerializeField] TMP_Text displayNumber2;
    [SerializeField] TMP_Text[] answerTexts;  // Text components on the cans

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            CreateRandomNumber();
        }
    }

    public void CreateRandomNumber()
    {
        FirstRandomNumber = Random.Range(1, 201);
        SecondRandomNumber = Random.Range(1, 201);
        CorrectAnswer = FirstRandomNumber + SecondRandomNumber;

        displayNumber1.text = FirstRandomNumber.ToString();
        displayNumber2.text = SecondRandomNumber.ToString();

        GenerateAnswers();
        DisplayAnswers();
    }

    void GenerateAnswers()
    {
        Answers[0] = CorrectAnswer;
        for (int i = 1; i < Answers.Length; i++)
        {
            int wrongAnswer;
            do
            {
                wrongAnswer = Random.Range(2, 401); // To ensure no duplicates and incorrect answers are possible
            } while (System.Array.Exists(Answers, answer => answer == wrongAnswer));
            Answers[i] = wrongAnswer;
        }

        // Shuffle the answers array
        for (int i = 0; i < Answers.Length; i++)
        {
            int randomIndex = Random.Range(0, Answers.Length);
            int temp = Answers[randomIndex];
            Answers[randomIndex] = Answers[i];
            Answers[i] = temp;
        }
    }

    void DisplayAnswers()
    {
        for (int i = 0; i < answerTexts.Length; i++)
        {
            answerTexts[i].text = Answers[i].ToString();
        }
    }
}
