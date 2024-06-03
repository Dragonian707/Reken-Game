using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberSelector : MonoBehaviour
{
    int[] numbers = { 11, 8, 16, 7, 19, 3, 17, 2, 15, 10, 6, 13, 4, 18, 1, 20, 5, 12, 9, 14, 11 };

    public void CheckHit()
    {
        //NEED to work with percentages, otherwise when a different resolution gets used, positions for specific parts are wrong
        Vector2 pos = new Vector2(Input.mousePosition.x - Screen.currentResolution.width / 2, Input.mousePosition.y - Screen.currentResolution.height / 2);
        int devideNumber = Screen.currentResolution.height / 2;
        int points;

        //check the radius within the 'bull' zone------------------------
        if (pos.magnitude < 0.037 * devideNumber)
        {
            points = 50;
            Debug.Log(points);
            return;
        }
        if (pos.magnitude < 0.0926 * devideNumber)
        {
            points = 25;
            Debug.Log(points);
            return;
        }
        //--------------------------------------------------------------

        //gets the correct number---------------------------------------
        int zone = Mathf.RoundToInt(Mathf.Rad2Deg * Mathf.Atan2(pos.y, pos.x) / 18) + 10;
        points = numbers[zone];
        //--------------------------------------------------------------

        //check treble or double hit------------------------------------
        if (pos.magnitude > 0.4815 * devideNumber && pos.magnitude < 0.5556 * devideNumber)
        {
            points *= 3;
        }
        if (pos.magnitude > 0.7593 * devideNumber && pos.magnitude < 0.8148 * devideNumber)
        {
            points *= 2;
        }
        //--------------------------------------------------------------
        FindObjectOfType<ScoreTracker>().AddScore(points);
        Debug.Log(points);
    }
}
