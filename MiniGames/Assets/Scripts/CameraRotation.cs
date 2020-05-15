using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField]
    KeyCode LeftRotation = KeyCode.A;
    [SerializeField]
    KeyCode RightRotation = KeyCode.D;

    static public void TurnOnDefaultCamera()
    {
        GameObject[] cams = GameObject.FindGameObjectsWithTag("MainCamera");
        for (int i = 1; i < cams.Length; i++)
            cams[i].GetComponent<Camera>().enabled = false;

        cams[0].GetComponent<Camera>().enabled = true;
    }

    void Start()
    {
        TurnOnDefaultCamera();
    }

    // Update is called once per frame
    void Update()
    {

        GameObject[] cams = GameObject.FindGameObjectsWithTag("MainCamera");


        if (Input.GetKeyDown(LeftRotation) || Input.GetKeyDown(RightRotation))
            for (int i = 0; i < cams.Length; i++)
                if (cams[i].GetComponent<Camera>().enabled)
                {
                    int indeks;

                    if (Input.GetKeyDown(LeftRotation))
                    {
                        indeks = i + 1;
                        if (indeks == cams.Length) indeks = 0;

                        PlayerControler.LeftRotation();
                    }
                    else
                    {
                        indeks = i - 1;
                        if (indeks == -1) indeks = cams.Length - 1;

                        PlayerControler.RightRotation();
                    }


                    GameObject.Find($"Cam{i}").GetComponent<Camera>().enabled = false;
                    GameObject.Find($"Cam{indeks}").GetComponent<Camera>().enabled = true;
                    //cams[i].GetComponent<Camera>().enabled = false;
                    //cams[indeks].GetComponent<Camera>().enabled = true;
                    
                    break;
                }



    }
}
