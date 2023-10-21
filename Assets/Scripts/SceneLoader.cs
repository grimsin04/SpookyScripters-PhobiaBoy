using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("MDC Hackathon");
        Debug.Log("Playing");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("StartScreenUI");
        Debug.Log("Back to Main Menu");
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("MDC Hackathon");
        Debug.Log("Back to Main Menu");
    }
}
