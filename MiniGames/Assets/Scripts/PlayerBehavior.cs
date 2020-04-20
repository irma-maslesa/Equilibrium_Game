using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerBehavior : MonoBehaviour
{
    public Text collected;
    GameObject exitLight;

    int coinsCounter;
    int count;

    private void Start()
    {
        count = 0;
        coinsCounter = GameObject.FindGameObjectsWithTag("Coin").Length;
        exitLight = GameObject.FindGameObjectWithTag("Finish");

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
            collected.text = "Collected all, GO FIND EXIT LIGHT!";
            exitLight.gameObject.SetActive(true);
        }
    }

    public bool isAllCollected()
    {
        return count == coinsCounter;
    }
}
