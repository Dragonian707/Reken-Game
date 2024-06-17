using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Safe : MonoBehaviour
{
	
	


    // Start is called before the first frame update
    void Start()
    {
        
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void SlideNumberSelector() 
	{
		Slider slider = GetComponent<Slider>();

		if (slider.value < 50)
		{
			NumberDisplayChanger(0);
		}
		else if (slider.value < 150 && slider.value > 50)
		{
			NumberDisplayChanger(1);

		}
		else if (slider.value < 250 && slider.value > 150)
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
		switch(display)
		{ 
			case 0:
				break;
			
			case 1:
				break;
			
			case 2:
				break;

			case 3: 
				break;	
		
		}
	}

	void VaultRotation() 
	{
		
	}

}
