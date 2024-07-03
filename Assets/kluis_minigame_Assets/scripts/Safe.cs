using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Safe : MonoBehaviour
{

	[SerializeField] Slider slider;
	[SerializeField] Text[] displayText;

	int[] combination = {0,0,0,0 };

	// Start is called before the first frame update
	void Start()
    {
        
		
    }

    // Update is called once per frame
    void Update()
    {
		
    }

	//changes the which display is selected for number changes based on the slider value
	public void SlideNumberSelector() 
	{
		

		if (slider.value <= 50)
		{
			NumberDisplayChanger(0);
		}
		else if (slider.value <= 150 && slider.value > 50)
		{
			NumberDisplayChanger(1);

		}
		else if (slider.value <= 250 && slider.value > 150)
		{
			NumberDisplayChanger(2);

		}
		else 
		{
			NumberDisplayChanger(3);
		}

	}
	
	// changes the number on the display to the number you selected
	void NumberDisplayChanger(int display) 
	{
		
		

		int displaynumber = FindObjectOfType<TurnKnob>().getComboNumber();
		
		combination[display] = (int)(displaynumber * Mathf.Pow(10, 3 -display));
		

		displayText[display].text = displaynumber.ToString();
	}

	//gets all the turns the numbers you selected in the answer
	public int GetAnswer() 
	{
		int answer = 0;
		foreach (int N in combination) 
		{
			answer += N;	
		}
		
		return answer;
	}

	// resets the safe for the next question
	public void SafeReset()
	{
		GameObject knob = GameObject.FindGameObjectWithTag("knob");
		knob.transform.rotation = new Quaternion();

		slider.value = 0;

		combination[0] = 0;
		combination[1] = 0;
		combination[2] = 0;
		combination[3] = 0;

		displayText[0].text = "0";
		displayText[1].text = "0";
		displayText[2].text = "0";
		displayText[3].text = "0";


	}

}
