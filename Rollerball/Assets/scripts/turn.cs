using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour {

    public GameObject pickup;

    void Start()
    {
        for (int i = -4; i < 5; i++)
        {
            for (int j = -4; j < 5; j++)
            {
                if ((i >= -5 && j <= 5 && (i + j) % 2 == 0) && (i != 0 || j != 0))
                {
                   if(Random.Range(0, 10)%3 == 0 && i != 0 && j != 0)
                    {
                        GameObject pick = Instantiate(pickup, new Vector3(i+.5f, .4f, j+.5f), Quaternion.identity);
                        pick.transform.parent = GameObject.Find("Platform").transform;
                       
                    }

                }
            }
        }
    }
}
