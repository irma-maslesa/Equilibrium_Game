using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePausedOptions : MonoBehaviour
{
    GameObject panel;
    GameObject collected;
    GameObject time;
    GameObject pause;
    GameObject restart;

    private void Start()
    {
        Time.timeScale = 0;

        panel = GameObject.FindGameObjectWithTag("GamePaused");
        collected = GameObject.Find("Collected");
        time = GameObject.Find("Time");

        setOnOff(false);
    }

    public void Restart()
    {
        panel.SetActive(false);
        collected.SetActive(true);
        time.SetActive(true);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerControler.SetDefaultControls();
    }

    public void Resume()
    {
        panel.SetActive(false);
        collected.SetActive(true);
        time.SetActive(true);

        Time.timeScale = 1;
    }

    void setOnOff(bool value)
    {
        collected.SetActive(value);
        time.SetActive(value);
    }
}
