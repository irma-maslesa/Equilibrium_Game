using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameObject completeLevelUI;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Level completed");
        completeLevelUI.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
