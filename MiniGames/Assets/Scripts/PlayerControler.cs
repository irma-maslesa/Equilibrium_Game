using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    Vector3 velocityVector;

    static public KeyCode front = KeyCode.UpArrow;
    static public KeyCode back = KeyCode.DownArrow;
    static public KeyCode right = KeyCode.RightArrow;
    static public KeyCode left = KeyCode.LeftArrow;

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
    void FixedUpdate()
    {
        if (Input.GetKey(right))
            GetComponent<Rigidbody>().velocity += new Vector3(velocityVector.x, 0, 0);
        else if(Input.GetKey(left))
            GetComponent<Rigidbody>().velocity -= new Vector3(velocityVector.x, 0, 0);
        else if (Input.GetKey(front))
            GetComponent<Rigidbody>().velocity += new Vector3(0, 0, velocityVector.z);
        else if (Input.GetKey(back))
            GetComponent<Rigidbody>().velocity -= new Vector3(0, 0, velocityVector.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "NPC")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            MenageControls();
            MenageCamera();
        }
    }
}
