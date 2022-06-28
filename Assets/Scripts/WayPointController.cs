using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointController : MonoBehaviour
{
    public GameObject[] wayPoints;
    int currentWP = 0;
    public float speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, wayPoints[currentWP].transform.position) < 3) 
        currentWP++;
        if (currentWP >= wayPoints.Length)
            currentWP = 0;
        this.transform.LookAt(wayPoints[currentWP].transform);
        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
