
using UnityEngine;
using UnityEngine.AI;


public class MoveToClickPoint : MonoBehaviour
{
    private Transform LinkA;
    private NavMeshAgent Tank;

    void Start()
    {
        Tank = GetComponent<NavMeshAgent>();
        LinkA = GameObject.FindGameObjectWithTag("LinkA").transform; 
                                                                           

    }

    void Update()
    {

        Debug.Log(Tank.remainingDistance);

        if (LinkA != null && Tank.remainingDistance < 2f)
        {
            Tank.destination = LinkA.position;
        }

    }
}