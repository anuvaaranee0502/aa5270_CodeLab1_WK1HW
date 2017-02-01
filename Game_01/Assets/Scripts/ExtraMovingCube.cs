using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraMovingCube : MonoBehaviour {

	public float moveMod;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//transform.Translate(new Vector3(
		//transform.Translate(new Vector3(
			//moveMod * (Mathf.PerlinNoise(Time.timeSinceLevelLoad, 0) - 0.5f) * 2,
			//moveMod * (Mathf.PerlinNoise(0, Time.timeSinceLevelLoad) - 0.5f) * 2,
			//0));


		rb.AddForce (new Vector3 (
			moveMod * (Mathf.PerlinNoise (Time.timeSinceLevelLoad, 0) - 0.5f) * 2,
			moveMod * (Mathf.PerlinNoise (0, Time.timeSinceLevelLoad) - 0.5f) * 2,
			0));
		//Debug.Log ("collision working");
	}
	}

