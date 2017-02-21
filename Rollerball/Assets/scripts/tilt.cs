using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilt : MonoBehaviour {
    private Rigidbody rb;
    public Vector3 currentRot;
    public float sensitivity;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }   
	 
	// Update is called once per frame
	void Update () {
        currentRot = GetComponent<Transform>().eulerAngles;
        if(Input.GetAxis("Horizontal") > .2 && (currentRot.z >= 351 || currentRot.z <= 9))
        {
            transform.Rotate(0, 0, sensitivity * Time.deltaTime * -Input.GetAxis("Horizontal"));
        }

        if (Input.GetAxis("Horizontal") < -.2 && (currentRot.z <= 8 || currentRot.z >= 350))
        {
            transform.Rotate(0, 0, sensitivity * Time.deltaTime * -Input.GetAxis("Horizontal"));
        }

        if(Input.GetAxis("Vertical") > .2 && (currentRot.x <= 8 || currentRot.x >= 350))
        {
            transform.Rotate(sensitivity * Time.deltaTime * Input.GetAxis("Vertical"), 0, 0);
        }
        if(Input.GetAxis("Vertical") < -.2 && (currentRot.x >= 351 || currentRot.x <= 9))
        {
            transform.Rotate(sensitivity * Time.deltaTime * Input.GetAxis("Vertical"), 0, 0);
        }
	}
}
