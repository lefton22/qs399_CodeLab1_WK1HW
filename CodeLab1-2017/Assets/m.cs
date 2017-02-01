using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m : MonoBehaviour {
	
	public float itscale = 1f;

	void Start () {
		transform.localScale = new Vector3 (itscale,itscale,1f);


	}
	

	void Update () {
		//Debug.Log(gameObject.name);
	}

	void destroy ()
	{
		Destroy (gameObject);
		Debug.Log ("destroy");

	}
}
