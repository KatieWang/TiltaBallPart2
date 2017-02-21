using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turning : MonoBehaviour {

    private float angle;
    private bool rotating;
    private int[] options = { -1 , 1};
    private int dir; 

	// Use this for initialization
	void Start () {
        rotating = false;
	}
	
	void Update () {
        if (Random.Range(0, 600) == 0 && rotating == false)
        {
            dir = options[Random.Range(0, 2)];
            angle = dir * 90; 
            Invoke("actualTurn", 3);
        }
	}

    void actualTurn()
    {
        rotating = true;
    }

    private void FixedUpdate()
    {
        if(rotating)
        {
            if((dir < 0 && angle < 0) || ( dir > 0 && angle > 0) )
            {
                transform.Rotate(0, 90 * dir * Time.deltaTime, 0);
                angle = angle - (90 * dir * Time.deltaTime);
            } else if (angle <  90 * dir* Time.deltaTime || angle > 90 * dir * Time.deltaTime)
            {
                transform.Rotate(0, angle, 0);
                angle = 0; 
            } else if ( angle == 0)
            {
                rotating = false; 
            }
        }
    }
}
