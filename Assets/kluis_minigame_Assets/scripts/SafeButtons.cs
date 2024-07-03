using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SafeButtons : MonoBehaviour
{
	public GameObject explanation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	//sends you back to the menu
	public void BackToMenu()
	{
		SceneManager.LoadScene(0);
	}

	//toggle the exlaination of the minigame
	public void ToggleExplaination() 
	{
		if (!explanation.activeSelf) 
		{
			explanation.SetActive(true);
		
		}
		else 
		{ 
			explanation.SetActive(false);
		}
	
	}
}
