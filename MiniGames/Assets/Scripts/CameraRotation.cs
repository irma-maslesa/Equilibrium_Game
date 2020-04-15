using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField]
    KeyCode LeftRotation;
    [SerializeField]
    KeyCode RightRotation;
    


    // Update is called once per frame
    void Update()
    {
        GameObject[] cams = GameObject.FindGameObjectsWithTag("MainCamera");

        if(Input.GetKeyDown(LeftRotation))
            for(int i = 0; i< cams.Length; i++)
                if(cams[i].GetComponent<Camera>().enabled)
                {
                    cams[i].GetComponent<Camera>().enabled = false;

                    int indeks = i + 1;
                    if (indeks == cams.Length)
                        indeks = 0;

                    cams[indeks].GetComponent<Camera>().enabled = true;

                    KeyCode help = PlayerControler.front;
                    PlayerControler.front = PlayerControler.left;
                    PlayerControler.left = PlayerControler.back;
                    PlayerControler.back = PlayerControler.right;
                    PlayerControler.right = help;
                    break;
                }

        if (Input.GetKeyDown(RightRotation))
            for (int i = 0; i < cams.Length; i++)
                if (cams[i].GetComponent<Camera>().enabled)
                {
                    cams[i].GetComponent<Camera>().enabled = false;

                    int indeks = i - 1;
                    if (indeks == -1)
                        indeks = cams.Length - 1;

                    cams[indeks].GetComponent<Camera>().enabled = true;

                    KeyCode help = PlayerControler.front;
                    PlayerControler.front = PlayerControler.right;
                    PlayerControler.right = PlayerControler.back;
                    PlayerControler.back = PlayerControler.left;
                    PlayerControler.left = help;
                    break;
                }

        
    }
}
