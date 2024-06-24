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

	void NumberDisplayChanger(int display) 
	{
		
		

		int displaynumber = FindObjectOfType<TurnKnob>().getComboNumber();
		
		combination[display] = (int)(displaynumber * Mathf.Pow(10, 3 -display));
		

		displayText[display].text = displaynumber.ToString();
	}

	public int GetAnswer() 
	{
		int answer = 0;
		foreach (int N in combination) 
		{
			answer += N;	
		}
		SafeReset();
		return answer;
	}

	private void SafeReset()
	{
		

		GameObject knob = GameObject.FindGameObjectWithTag("knob");
		knob.transform.rotation = new Quaternion();

		slider.value = 0;

		displayText[0].text = "0";
		displayText[1].text = "0";
		displayText[2].text = "0";
		displayText[3].text = "0";


	}

}
