using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class planet_bemet : MonoBehaviour {
	
	public float life;
	public float plusSpeed;
    string name_Meet;
	GameObject meet;
	float scale_meet;

    float minimum ;
    float maximum ;
	float t = 0.0f;
	bool isMeet;




	void Start () {
		//Debug.Log ("radius: " + GetComponent<CircleCollider2D>().radius );
		isMeet = false;
	}
	
	// Update is called once per frame
	void Update () {
		life = life - plusSpeed;
		//Debug.Log ("life: " + life);



		transform.localScale = new Vector3 (life,life,1.0f);
		GetComponent<CircleCollider2D> ().radius = transform.localScale.x/15;

		if (isMeet )
		{
         	t += 0.5f * Time.deltaTime;
//			minimum = transform.localScale.x;
//			maximum = meet.transform.localScale.x + transform.localScale.x;

			transform.localScale = new Vector3(Mathf.Lerp(minimum, maximum, t), Mathf.Lerp(minimum, maximum, t), 1);

			//meet.SendMessage ("destroy");

			//life = maximum;

			if (transform.localScale.x == maximum ) 
			{
				
				isMeet = false;
				Debug.Log ("false!!!");
			}

		}

		if (life <= 0) 
		{
			Debug.Log ("GAME OVER");
			SceneManager.LoadScene ("gameover");
		}
	}


	void OnTriggerEnter2D (Collider2D collider)
	{
		Debug.Log ("collide !");
		name_Meet = collider.name;
		Debug.Log ("name_Meet : " +name_Meet);

		meet = collider.gameObject;   //碰撞到的“那个物体”管他叫什么，可加一个附加判断条件，if+ TAG...
		Debug.Log ("GameObject meet : " + meet);

		scale_meet = meet.transform.localScale.x;
		Debug.Log ("scale_meet : " + scale_meet);


		minimum = transform.localScale.x;
		maximum = meet.transform.localScale.x + transform.localScale.x;

		life = maximum;

		//			life = life + 0.05f;

		Destroy (meet);

		toSclaeMeet ();




	}

	void toSclaeMeet ()
	{

		isMeet = true;
		Debug.Log ("become bigger and bigger until ...isMeet: " + isMeet);

	}
}
