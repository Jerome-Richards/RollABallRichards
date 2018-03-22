using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacer : MonoBehaviour {
    public float speed = 5.0f;
    private float zMax = 7.5f;
    private float zmin = -7.5f; //starting position
    private int direction = 1;  //positive to start

	// update is claled once per frame
	void Update () {
        float zNew = transform.position.z + direction * speed * Time.deltaTime;

        if (zNew >= zMax)
        {
            zNew = zMax;
            direction *= -1;
        }
        else if (zNew <= zmin)
        {
            zNew = zmin;
            direction *= -1;
        }

        transform.position = new Vector3(7.5f, 0.75f, zNew);
	}
	
}
