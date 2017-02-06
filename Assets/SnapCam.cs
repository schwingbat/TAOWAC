using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapCam : MonoBehaviour {

	/*
		Camera Positions
		1. X: -11		Y: 26    	Size: 10
		2. X: 53  		Y: -1   	Size: 25
		3. X: 121.5  	Y: -13   	Size: 12
		4. X: 185 		Y: -2		Size: 22.5
	*/

	/*
		Lerp the camera to the predefined position.
		Simple API with a function that takes an integer.
	*/

	public void snapCamera (int pos) {
		switch (pos) {
			case 1: 
				transform.position = new Vector3(-11f, 26f, -10f); 
				GetComponent<Camera>().orthographicSize = 10f;
				break;
			case 2: 
				transform.position = new Vector3(53f, -1f, -10f); 
				GetComponent<Camera>().orthographicSize = 25f;
				break;
			case 3: 
				transform.position = new Vector3(121.5f, -13f, -10f); 
				GetComponent<Camera>().orthographicSize = 12f;
				break;
			case 4: 
				transform.position = new Vector3(185f, -2f, -10f); 
				GetComponent<Camera>().orthographicSize = 22.5f;
				break;
		}
	}
}
