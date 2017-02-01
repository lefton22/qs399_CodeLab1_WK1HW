using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wildMPlanet : MonoBehaviour {

	public float roSpeedwildPlanet;

	GameObject ltrial1;

	public float radius = 1.5f;

	void Start () 
	{
	//	ltrial1 = GameObject.fi ("trial1");

//		ltrial1 = transform.Find("trial").gameObject;
//		ltrial1.transform.localScale = new Vector3 (radius,radius,2f);
//
//
//		Debug.Log ("finding child: " + ltrial1);




//		transform.FindChild ("trial").localRotation = Quaternion.Euler (30f, 30f, 30f);
		//transform.FindChild ("trial").localRotation = new Vector3 (0f, 0f, 30f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate( 0 ,0, roSpeedwildPlanet);

		//transform.FindChild ("trial").localRotation = Quaternion.Euler (0f, 30f, 30f);
	}
}
