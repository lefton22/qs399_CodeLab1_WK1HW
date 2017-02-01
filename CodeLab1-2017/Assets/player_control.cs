using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour {

	public float speed_followCurse =0.001f;
	float timeDeltaTime;

	float speed_myPlanet;

	void Start () 
	{
		speed_myPlanet = 0.07f;
	}

	void Update () 
	{
		//speed_myPlanet = speed_myPlanet + 0.05f;
////////move

		Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		pz.z = 0;

		transform.Translate (pz * speed_followCurse);	

		//Debug.Log ("where's mouse: " +pz);

//		if (Input.GetKey(KeyCode.Mouse0)) 
//		{
//			//Debug.Log ("clicked mouse0");
//			//transform.position = Vector3.MoveTowards(transform.position, pz, speed);
//			//a = a+ pz.x; 
//			//transform.LookAt(pz);
//			transform.Translate (Vector3.up);	
//		}


////////rotate
		//transform.rotation = new Vector3( 0, 0, speed_myPlanet);
		//transform.Rotate( 0 ,0, speed_myPlanet);
	}
		
}
