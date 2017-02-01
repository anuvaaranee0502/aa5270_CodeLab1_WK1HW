using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour {

	float xDirection = 9f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += new Vector3 (xDirection, 0f, 0f) * Time.deltaTime;

		if (transform.position.x > 9f || transform.position.x < -9f ) {

			xDirection *= -1f;
		}
		
	}
}
