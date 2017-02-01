using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Directions : MonoBehaviour {

	public float moveSpeed;

	public Rigidbody rb;

	// Use this for initialization
	void Start () {

		moveSpeed = 1f;
		rb = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (moveSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis ("Vertical") * Time.deltaTime);
		if(Input.GetButtonDown("Jump")){
			rb.velocity = new Vector3 (0, 8, 0);
		}
		
	}
}
