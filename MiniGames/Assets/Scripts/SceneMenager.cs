using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenager : MonoBehaviour
{
    [SerializeField]
    KeyCode restart;

    private void MenageControls()
    {
        PlayerControler.front = KeyCode.UpArrow;
        PlayerControler.back = KeyCode.DownArrow;
        PlayerControler.right = KeyCode.RightArrow;
        PlayerControler.left = KeyCode.LeftArrow;

    }

    private void MenageCamera()
    {
        GameObject[] cams = GameObject.FindGameObjectsWithTag("MainCamera");
        for (int i = 0; i < cams.Length; i++)
            if (cams[i].GetComponent<Camera>().enabled)
            {
                cams[i].GetComponent<Camera>().enabled = false;
            }


        GameObject.Find("Cam0").GetComponent<Camera>().enabled = true;
    }

        // Update is called once per frame
        void Update()
    {
        if (Input.GetKeyDown(restart))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            MenageControls();
            MenageCamera();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            MenageControls();
            MenageCamera();
        }
    }
}
