using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePausedOptions : MonoBehaviour
{
    [SerializeField]
    GameObject GamePanel;
    [SerializeField]
    GameObject GamePaused;

    private void Start()
    {
        Time.timeScale = 0;

        GamePaused.SetActive(true);
        GamePanel.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerControler.SetDefaultControls();

        GamePaused.SetActive(false);
        GamePanel.SetActive(true);
    }

    public void Resume()
    {
        GamePaused.SetActive(false);
        GamePanel.SetActive(true);

        Time.timeScale = 1;
    }

    public void SelectLevel()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
