using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_Player : MonoBehaviour {
	
	public float rotateSpeed_myPlanet;
	Vector3 posPlayer;
	GameObject lPlayer;
	float clockDirection;


	void Start () {
		lPlayer = GameObject.Find ("Player");
		clockDirection = 1;
	}
	
	// Update is called once per frame
	void Update () {
//
//		if (Input.GetKeyDown (KeyCode.Mouse0)) 
//		{
//			Debug.Log ("press mouse 1!");
//			clockDirection = clockDirection * 1f;
//		}

		if (Input.GetKeyDown (KeyCode.Mouse1)) 
		{
			Debug.Log ("press mouse 2!");
			clockDirection = clockDirection * -1f;
		}

		posPlayer = lPlayer.transform.transform.position;
		//Debug.Log (posPlayer);

		transform.position = posPlayer;

		transform.Rotate( 0 ,0, rotateSpeed_myPlanet * clockDirection);
	}
}
