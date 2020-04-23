using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlayer : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)	player.transform.parent = transform;   
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)	player.transform.parent = null;
    }
}
