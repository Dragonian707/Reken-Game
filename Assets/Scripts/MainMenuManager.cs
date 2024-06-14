using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] GameObject menuBackground;
    [SerializeField] GameObject gamesBackground;
    [SerializeField] GameObject informationBackground;

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReturnToMenu()
    {
        menuBackground.SetActive(true);
        gamesBackground.SetActive(false);
        informationBackground.SetActive(false);
    }

    public void OpenGamesMenu()
    {
        menuBackground.SetActive(false);
        gamesBackground.SetActive(true);
        informationBackground.SetActive(false);
    }

    public void OpenInformation()
    {
        menuBackground.SetActive(false);
        gamesBackground.SetActive(false);
        informationBackground.SetActive(true);
    }

    public void StartMinigame(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
