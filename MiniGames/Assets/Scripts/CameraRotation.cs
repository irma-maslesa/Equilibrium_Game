using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation: MonoBehaviour
{
    [SerializeField]
    KeyCode LeftRotation = KeyCode.A;
    [SerializeField]
    KeyCode RightRotation = KeyCode.D;

    [SerializeField]
    GameObject target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(LeftRotation))
        {
            transform.RotateAround(target.transform.position, Vector3.up, 90);
            PlayerControler.LeftRotation();
        }
            
        else if (Input.GetKeyDown(RightRotation))
        {
            transform.RotateAround(target.transform.position, Vector3.up, -90);
            PlayerControler.RightRotation();
        }
    }

  
}
