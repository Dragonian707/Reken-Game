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
    // Start is called before the first frame update
    void Start()
    {
        pointsText.text = "0";
        scoreText.text = "";
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3 && !reset)
        {
            ResetPoints();
            imageAnim.SetBool("unhide", false);
            FindObjectOfType<QuestionManager>().NewQuestion();
            reset = true;
        }
    }

    public void AddScore(int score)
    {
        scoreText.text += score.ToString();
        scoreText.text += "\n";
        points += score;
        pointsText.text = points.ToString();
    }

    public void ResetPoints()
    {
        points = 0;
        pointsText.text = "0";
        scoreText.text = "";
    }

    public void SendAnswer()
    {
        bool c = FindObjectOfType<QuestionManager>().CheckAnswer(points);

        if (c)  { correctImage.sprite = correct; }
        else    { correctImage.sprite = incorrect; }

        imageAnim.SetBool("unhide", true);
        reset = false;
        timer = 0;
    }
}

