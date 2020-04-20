<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlayer : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            player.transform.parent = transform;
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
            player.transform.parent = null;
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlayer : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            player.transform.parent = transform;
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
            player.transform.parent = null;
    }
}
>>>>>>> 046b314975670bc56b6e0d990cea1b233aeeb689
