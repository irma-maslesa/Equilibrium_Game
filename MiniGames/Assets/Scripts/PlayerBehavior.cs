using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerBehavior : MonoBehaviour
{
    public Text collected;

    int coinsCounter;
    int count;

    private void Start()
    {
        count = 0;
        coinsCounter = GameObject.FindGameObjectsWithTag("Coin").Length;
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

        if (count == coinsCounter) collected.text = "Collected all, GO TO EXIT!";
    }

    public bool isAllCollected()
    {
        return count == coinsCounter;
    }
}
