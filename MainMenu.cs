using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void EndTheGame()
    {
        print("bye bye");
        Application.Quit();
    }

    public void ProcedetoGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GoToCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
