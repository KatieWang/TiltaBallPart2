using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    private Rigidbody rb;
    private bool jumping = false;
    public float jump;

    private bool un = false;
    private bool deux = false; 

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Floor"))
        {
            jumping = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Goal") && deux == true)
        {
            rb.useGravity = false;
            rb.AddForce(Vector3.up * 200);

        }
        if (other.gameObject.CompareTag("Respawn"))
        {
            if (un == false && deux == false)
            {
                un = true;
            }
            else if (un == true && deux == false)
            {
                deux = true;
            }
            Destroy(other.gameObject);
        }
    
    }

    private void OnGUI()
    {
        if (un == false)
        {
            GUI.Label(new Rect(0, 0, 200f, 20f), "Pick-ups remaining: 2");
        } else if (un && !deux)
        {
            GUI.Label(new Rect(0,0, 200f, 20f), "Pick-ups remaining: 1");
        } else if ( un && deux)
        {
            GUI.Label(new Rect(0, 0, 200f, 20f), "go to goal!");

        }
    }
    private void FixedUpdate()
    {
        if (Input.GetKey("space") && jumping == false)
        {
            rb.AddForce(Vector3.up * jump);
            jumping = true;
        }
    }
}
