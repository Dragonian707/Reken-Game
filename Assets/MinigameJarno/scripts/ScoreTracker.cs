using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] Text pointsText;

    int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        pointsText.text = "0";
        scoreText.text = "";
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

    public int GetPoints() { return points; }
}
