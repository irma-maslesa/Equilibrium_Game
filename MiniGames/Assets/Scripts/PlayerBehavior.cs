using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehavior : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "NPC")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            PlayerControler.SetDefaultControls();
            CameraRotation.TurnOnDefaultCamera();
        }
    }
}
