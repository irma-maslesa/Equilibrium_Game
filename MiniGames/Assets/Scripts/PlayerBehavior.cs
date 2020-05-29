using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField]
    Text collected;

    [SerializeField]
    GameObject LevelComplete;
    [SerializeField]
    GameObject exitLight;

    [SerializeField]
    GameObject GamePanel;

    int coinsCounter;
    int collectedCoins;

    private void Start()
    {
        collectedCoins = 0;
        coinsCounter = GameObject.FindGameObjectsWithTag("Coin").Length;

        exitLight.gameObject.SetActive(false);
        LevelComplete.SetActive(false);

        displayCollected();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "NPC")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            PlayerControler.SetDefaultControls();
        }

        else if (collision.collider.tag == "Finish")
        {
            Time.timeScale = 0;
            gameObject.SetActive(false);

            GamePanel.SetActive(false);
            LevelComplete.SetActive(true);

            float vrijeme = TimeCounter.seconds;

            GameObject.FindGameObjectWithTag("Star1").SetActive(false);

            if(vrijeme < 90) GameObject.FindGameObjectWithTag("Star2").SetActive(false);

            if(vrijeme < 60) GameObject.FindGameObjectWithTag("Star3").SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            collectedCoins++;
            displayCollected();
        }
    }
    private void displayCollected()
    {
        collected.text = $"Collected: {collectedCoins}/{coinsCounter}";

        if (collectedCoins == coinsCounter)
        {
            collected.text = "Collected all, GO FIND EXIT LIGHT!";
            exitLight.SetActive(true);
        }
    }

    public bool isAllCollected()
    {
        return collectedCoins == coinsCounter;
    }
}
