using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingWalls : MonoBehaviour {

    public GameObject hinge;
    // Use this for initialization
    private int[] rotations = {0, 90, 180, 270};
	void Start () {
		for (int i = -4; i < 5; i++)
        {
            for (int j = -4; j < 5; j++)
            {
                if( (i >= -5 && j <= 5 && (i + j)%2 == 0) && (i != 0 || j !=0))
                {
                    int arr = Random.Range(0, 4);
                    GameObject wall = Instantiate(hinge, new Vector3(i, 0, j), Quaternion.identity);
                    wall.transform.Rotate(new Vector3(0, rotations[arr], 0));
                    wall.transform.parent = GameObject.Find("Platform").transform;
                    
                }
            }
        }
	}




}
