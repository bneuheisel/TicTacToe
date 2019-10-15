using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void TwoPlayer()
    {
        SceneManager.LoadScene("NoAi");
    }
    public void EasyAI()
    {
        SceneManager.LoadScene("Easy");
    }
    public void HardAI()
    {
        SceneManager.LoadScene("Hard");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
