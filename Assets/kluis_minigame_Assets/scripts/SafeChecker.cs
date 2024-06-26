using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeChecker : MonoBehaviour
{
	bool reset = true;
	[SerializeField] Image background;
	float timer = 0f;
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
			if (timer > 1f) 
			{
				background.color = new Color(0.631f, 0.804f, 0.945f, 1);
				FindObjectOfType<QuestionManager>().NewQuestion(1);
				FindObjectOfType<Safe>().SafeReset();
				timer = 0f;
				reset = true;

			}
			timer += Time.deltaTime;
		}
	}

	public void SubmitAnswer() 
	{

		int Answer = FindObjectOfType<Safe>().GetAnswer();
		bool correct = FindObjectOfType<QuestionManager>().CheckAnswer(Answer);
		if (correct) 
		{ 
			background.color = Color.green;
		}
		else 
		{ 
			background.color= Color.red;
		}

		reset = false;
		Debug.Log(Answer);
	}
}
