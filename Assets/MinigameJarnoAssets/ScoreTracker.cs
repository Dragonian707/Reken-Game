using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] Text pointsRemainingText;

    int pointsRemaining = 301;
    // Start is called before the first frame update
    void Start()
    {
        pointsRemainingText.text = "301";
        scoreText.text = "";
    }

    public void AddScore(int score)
    {
        scoreText.text += score.ToString();
        scoreText.text += "\n";
        pointsRemaining -= score;
        pointsRemainingText.text = pointsRemaining.ToString();
    }

    public void ShowExplanation()
    {
        Animator anim = FindObjectOfType<Animator>();
        anim.SetBool("exp", !anim.GetBool("exp"));
    }
}
