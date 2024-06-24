using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeChecker : MonoBehaviour
{
	bool reset = true;

    // Start is called before the first frame update
    void Start()
    {
		FindObjectOfType<QuestionManager>().NewQuestion(1);
	}

    // Update is called once per frame
    void Update()
    {
		if ( !reset)
		{
			
			FindObjectOfType<QuestionManager>().NewQuestion(1);
			reset = true;
		}
	}

	public void SubmitAnswer() 
	{
		int Answer = FindObjectOfType<Safe>().GetAnswer();
		FindObjectOfType<QuestionManager>().CheckAnswer(Answer);
		reset = false;
		Debug.Log(Answer);
	}
}
