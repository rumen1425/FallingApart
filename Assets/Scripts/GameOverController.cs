using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public void mainmenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void playagain()
    {
        SceneManager.LoadScene("Game");
    }

    public void exit()
    {
        Application.Quit();
    }
}
