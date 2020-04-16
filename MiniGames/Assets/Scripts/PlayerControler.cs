using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    Vector3 velocityVector = new Vector3(0, 0, 0);

    static KeyCode front;
    static KeyCode back;
    static KeyCode right;
    static KeyCode left;

    static public void SetDefaultControls()
    {
        front = KeyCode.UpArrow;
        back = KeyCode.DownArrow;
        right = KeyCode.RightArrow;
        left = KeyCode.LeftArrow;
    }

    static public void LeftRotation()
    {
        KeyCode help = front;
        front = left;
        left = back;
        back = right;
        right = help;
    }

    static public void RightRotation()
    {
        KeyCode help = front;
        front = right;
        right = back;
        back = left;
        left = help;
    }

    void Start()
    {
        SetDefaultControls();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(right))
            GetComponent<Rigidbody>().velocity += new Vector3(velocityVector.x, 0, 0);
        else if (Input.GetKey(left))
            GetComponent<Rigidbody>().velocity -= new Vector3(velocityVector.x, 0, 0);
        else if (Input.GetKey(front))
            GetComponent<Rigidbody>().velocity += new Vector3(0, 0, velocityVector.z);
        else if (Input.GetKey(back))
            GetComponent<Rigidbody>().velocity -= new Vector3(0, 0, velocityVector.z);
    }

}
