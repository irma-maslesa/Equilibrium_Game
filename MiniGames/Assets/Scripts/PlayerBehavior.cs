using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField]
    Text collected;
    GameObject exitLight;

    GameObject panel;

    int coinsCounter;
    int count;

    private void Start()
    {
        count = 0;
        coinsCounter = GameObject.FindGameObjectsWithTag("Coin").Length;
        exitLight = GameObject.FindGameObjectWithTag("Finish");
        panel = GameObject.FindGameObjectWithTag("LevelComplete");
        panel.SetActive(false);
        exitLight.gameObject.SetActive(false);
        displayCollected();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "NPC")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            PlayerControler.SetDefaultControls();
            CameraRotation.TurnOnDefaultCamera();
        }

        else if (collision.collider.tag == "END")
        {
            Time.timeScale = 0;
            panel.SetActive(true);
            Invoke("LoadNextLevel", 3);
        }
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            count++;
            displayCollected();
        }

    }

    private void displayCollected()
    {
        collected.text = $"Collected: {count}/{coinsCounter}";

        if (count == coinsCounter)
        {
            exitLight.gameObject.SetActive(true);
            collected.text = "Collected all, GO FIND EXIT LIGHT!";
        }
    }

    public bool isAllCollected()
    {
        return count == coinsCounter;
    }
}
