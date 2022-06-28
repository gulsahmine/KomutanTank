using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

 public class ChasePlayer : MonoBehaviour
{
    private NavMeshAgent Komutan;
    public GameObject player;
    public float KomutanDistanceRun = 2.0f;

    void Start()
    {
        Komutan = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance < KomutanDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - player.transform.position;
            Vector3 newPos = transform.position - dirToPlayer;

            Komutan.SetDestination(newPos);
        }
    }
}
