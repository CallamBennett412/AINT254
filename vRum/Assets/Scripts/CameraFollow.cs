using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject Car;

    public Vector3 offset;

	// Use this for initialization
	void Start () {

        offset = transform.position - Car.transform.position;
        transform.LookAt(Car.transform);
    }

    void LateUpdate()
    {
        transform.position = Car.transform.position + offset;
        
    }
}
