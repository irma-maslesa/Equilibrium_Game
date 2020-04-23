using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void PlayAgain()
    {
        int indexOfStartMenu = 0;
        SceneManager.LoadScene(indexOfStartMenu);

    }
    public void Quit()
    {
        Application.Quit();
    }
}
