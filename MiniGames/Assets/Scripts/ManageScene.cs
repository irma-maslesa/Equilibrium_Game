using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManageScene : MonoBehaviour
{
    GameObject GamePaused;
    GameObject GamePanel;
    GameObject LevelComplete;

    private void Start()
    {
        Time.timeScale = 1;

        GamePaused = GameObject.FindGameObjectWithTag("GamePaused");
        GamePanel = GameObject.FindGameObjectWithTag("GamePanel");
        LevelComplete = GameObject.FindGameObjectWithTag("LevelComplete");

        GamePanel.SetActive(true);
        LevelComplete.SetActive(false);
        GamePaused.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerControler.SetDefaultControls();
    }

    public void Pause()
    {
        Time.timeScale = 0;
        GamePanel.SetActive(false);
        GamePaused.SetActive(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            PlayerControler.SetDefaultControls();
        }
    }

}
