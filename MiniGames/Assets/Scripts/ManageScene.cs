using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManageScene : MonoBehaviour
{
    [SerializeField]
    GameObject GamePaused;
    [SerializeField]
    GameObject GamePanel;

    private void Start()
    {
        Time.timeScale = 1;

        GamePanel.SetActive(true);
        GamePaused.SetActive(false);
    }
}
