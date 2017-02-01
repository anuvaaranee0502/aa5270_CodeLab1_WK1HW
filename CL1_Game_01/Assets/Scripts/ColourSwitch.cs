using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourSwitch : MonoBehaviour {

	public Material[] materials; //allows input of materials colours in a set sized array
	public Renderer rend; //what we are rendering like the sphere

	private int index = 1; //initialize at 1, otherwise you have to press the ball twice to change colour at first

	// Use this for initialization
	void Start () {

		rend.GetComponent<Renderer> (); //gives functionality for the renderer
		rend.enabled = true; //makes the rendered 3D object visable if enabled 
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		if(materials.Length == 0) //if there are no materials present nothing happens
		{
			return;
		}

		if (Input.GetMouseButtonDown(0)){
			index += 1; //when mouse is pressed down we increment upto the next index location
			if (index == materials.Length + 1) //when it reaches the end of the material it starts over
			{
				index = 1;
			}

			rend.sharedMaterial = materials [index - 1]; //this sets the material colour values inside the index
		}
	}
}
