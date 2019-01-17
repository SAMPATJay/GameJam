using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy1 : MonoBehaviour
{
    NavMeshAgent agent;
    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        agent.SetDestination(player.position);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pit")
        {
            Destroy(gameObject, 0.1f);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Pit")
        {
            Destroy(gameObject, 0.1f);
        }
    }

}
