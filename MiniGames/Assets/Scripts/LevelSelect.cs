using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    [SerializeField]
    Button[] buttons;

    private void Update()
    {
        int reachedLevel = PlayerPrefs.GetInt("LevelReached", 1);

        for (int i = 0; i < buttons.Length; i++)
            if (i + 1 > reachedLevel)
                buttons[i].interactable = false;
            else
                buttons[i].interactable = true;
    }

    public void Load(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }

    public void RestartProgress()
    {
        PlayerPrefs.SetInt("LevelReached", 1);
    }


}
