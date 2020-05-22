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

    int coinsCounter;
    int collectedCoins;
    GameObject time;
    GameObject panel;

    private void Start()
    {
        collectedCoins = 0;
        coinsCounter = GameObject.FindGameObjectsWithTag("Coin").Length;
        collected = GameObject.Find("Collected").GetComponent<Text>();

        displayCollected();

        time = GameObject.Find("Time");
        panel = GameObject.FindGameObjectWithTag("LevelComplete");
        exitLight = GameObject.FindGameObjectWithTag("Finish");

        exitLight.gameObject.SetActive(false);
        panel.SetActive(false);
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
            gameObject.SetActive(false);

            time.SetActive(false);
            collected.gameObject.SetActive(false);
            panel.SetActive(true);

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
