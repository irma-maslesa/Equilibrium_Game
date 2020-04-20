<<<<<<< HEAD
﻿using System.Collections;
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
        else if(collision.collider.tag=="END")
        {
            GameObject.FindGameObjectWithTag("LevelComplete").transform.position = new Vector3(372.5f, 210, 0);
            Invoke("LoadNextLevel", 3);
        }
       
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
   


}
=======
﻿using System.Collections;
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
>>>>>>> master
