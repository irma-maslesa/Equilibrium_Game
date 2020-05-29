using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void PlayAgain()
    {
        PlayerPrefs.SetInt("LevelReached", 1);
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void SelectLevel()
    {
        SceneManager.LoadScene(1);
    }
}
