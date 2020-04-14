using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenager : MonoBehaviour
{
    [SerializeField]
    KeyCode restart;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(restart))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
