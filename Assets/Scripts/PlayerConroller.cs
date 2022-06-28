using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    //hareket sa�/sol/�n/arka
    public float speed = 10;
    private float horizontalInput;
    private float verticalInput;

    // player sahne d���na ��kmas�n
    private float xBound = 20;
    private float xBoundDown = 11.21f;
    private float zBound = 8;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //oklarla hareket
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        //Keep the player in bounds(sa� solda s�n�rland�rmak i�in yazd�k)
        if (transform.position.x < xBoundDown)
        {
            transform.position = new Vector3(xBoundDown, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
    }
}
