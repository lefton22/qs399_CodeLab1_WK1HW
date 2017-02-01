using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class try111 : MonoBehaviour {
	
	public float minimum = -1.0F;
	public float maximum =  3.0F;

	float t = 0.0f;

	void Start () 
	{
		
	}
	

	void Update () 
	{
		transform.localScale = new Vector3(Mathf.Lerp(minimum, maximum, t), Mathf.Lerp(minimum, maximum, t), 1);

		t += 0.1f * Time.deltaTime;
	}
}
