using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCAttempt : MonoBehaviour
{
    void NavMeshAgentExample()
    {
        var navMeshAgent = GetComponent<NavMeshAgent>();
        var player = GameObject.FindWithTag("Player");
        navMeshAgent.SetDestination(player.transform.position);
        if (navMeshAgent.isStopped)
        {
            // play idle anim
        }
        else
        {
            // set walk animation
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
