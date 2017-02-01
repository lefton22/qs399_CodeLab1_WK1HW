using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_script : MonoBehaviour {

	GameObject lMyPlanet;

		void Start () 
	{
		lMyPlanet = GameObject.Find ("Player");
	}
	

	void Update () 
	{
		transform.position = new Vector3 
			(lMyPlanet.transform.position.x, 
				lMyPlanet.transform.position.x, -1f);
	}
}
