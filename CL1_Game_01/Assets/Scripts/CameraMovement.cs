using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	private const float Y_AGLE_MIN = 4f;
	private const float Y_ANGLE_MAX = 50f;

	public Transform lookAt;
	public Transform camTransform;

	private Camera cam;

	private float distance = 10f;
	private float currentX = 0f;
	private float currentY = 0f;
	private float sensitivityX = 4f;
	private float sensitivityY = 1f;

	// Use this for initialization
	void Start () {

		camTransform = transform;
		cam = Camera.main;

	}

	void Update() {
		currentX += Input.GetAxis ("Mouse X");
		currentY += Input.GetAxis ("Mouse Y"); 

		currentY = Mathf.Clamp (currentY, Y_AGLE_MIN, Y_ANGLE_MAX);



	}

	void LateUpdate () {

		Vector3 dir = new Vector3 (0, 0, -distance);
		Quaternion rotation = Quaternion.Euler (currentY, currentX, 0);
		camTransform.position = lookAt.position + rotation * dir;
		camTransform.LookAt (lookAt.position);
		
	}
}
