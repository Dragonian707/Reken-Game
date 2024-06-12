using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
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

		if (slider.value < 52)
		{
			NumberDisplayChanger(0);
		}
		else if (slider.value > 150)
		{
			NumberDisplayChanger(2);

		}
		else 
		{
			NumberDisplayChanger(1);
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
		
		}
	}

	void VaultRotation() 
	{ 
		
	}

}
