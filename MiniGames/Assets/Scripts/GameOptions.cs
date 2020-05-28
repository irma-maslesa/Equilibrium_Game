using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOptions : MonoBehaviour
{
    [SerializeField]
    GameObject GamePaused;
    [SerializeField]
    GameObject GamePanel;

    private void Start()
    {
        GamePanel.SetActive(true);
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
}
