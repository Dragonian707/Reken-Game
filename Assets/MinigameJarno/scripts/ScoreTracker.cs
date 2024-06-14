using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] Text pointsText;
    [SerializeField] Image correctImage;
    [SerializeField] Sprite correct;
    [SerializeField] Sprite incorrect;
    [SerializeField] Animator imageAnim;

    float timer = 0;
    bool reset = false;
    int points = 0;
    int amountCorrect = 0;
    int dificulty = 1;

    void Start()
    {
        pointsText.text = "0";
        scoreText.text = "";

        ResetPoints();
        imageAnim.SetBool("unhide", false);
        FindObjectOfType<QuestionManager>().NewQuestion(dificulty);
        reset = true;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        //Generate a new question when the previous one is submitted
        if (timer > 3 && !reset)
        {
            ResetPoints();
            imageAnim.SetBool("unhide", false);
            FindObjectOfType<QuestionManager>().NewQuestion(dificulty);
            reset = true;
        }
    }

    //Add the 'score' amount of points to the total thrown amount
    public void AddScore(int score)
    {
        scoreText.text += score.ToString();
        scoreText.text += "\n";
        points += score;
        pointsText.text = points.ToString();
    }

    //Reset the points that were thrown
    public void ResetPoints()
    {
        points = 0;
        pointsText.text = "0";
        scoreText.text = "";
    }

    //Send the thrown points to check if it's correct and change a displayed sprite accordingly
    public void SendAnswer()
    {
        bool c = FindObjectOfType<QuestionManager>().CheckAnswer(points);

        if (c)  { correctImage.sprite = correct; amountCorrect++; }
        else    { correctImage.sprite = incorrect; }

        //start the animation to reveal if it is correct
        imageAnim.SetBool("unhide", true);
        reset = false;
        timer = 0;

        if (amountCorrect == 10)
        {
            amountCorrect = 0;
            dificulty++;
        }
    }
}

