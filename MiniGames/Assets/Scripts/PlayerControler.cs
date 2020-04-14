using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    Vector3 velocityVector;

    [SerializeField]
    KeyCode positive;
    [SerializeField]
    KeyCode negative;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(positive))
            GetComponent<Rigidbody>().velocity += velocityVector;

        else if(Input.GetKey(negative))
            GetComponent<Rigidbody>().velocity -= velocityVector;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "NPC")
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
