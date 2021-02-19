using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCheckpoint : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject checkpoint;
    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
            Destroy(checkpoint);
        Debug.Log("deathfloor destroyed");
        Destroy(gameObject);
        
    }
}