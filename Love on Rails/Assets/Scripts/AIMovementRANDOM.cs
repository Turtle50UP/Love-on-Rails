using UnityEngine;
using System.Collections;

public class AIMovementRANDOM : MonoBehaviour {

	public float speed=0.0f;
	float factor1 = 0.0f;
	float factor2 = 0.0f;
	float framecount = 0f;
	float movecount = 0f;
	public float llim = 120.0f;
	public float ulim = 180.0f;
	public float smin = 0.1f;
	public float smax = 0.4f;

	//This is how fast we want our player to run upon keypress.
	void updatefm(){
		speed = Random.Range (smin, smax);
		framecount = Mathf.Round(Random.Range(llim,ulim));
		movecount = Mathf.Round(Random.Range(0.0f,framecount));
	}
	// Use this for initialization
	void Start () {
		updatefm();
	}

	// Update is called once per frame
	void Update () {
		if (Time.frameCount % framecount == 0) {
			factor1 = Random.Range (-speed, speed);
			factor2 = Random.Range (-speed, speed);
			updatefm ();
		}
		if (Time.frameCount % framecount <= movecount) 
			GetComponent<Rigidbody2D>().AddForce(new Vector2(factor1 / Time.fixedDeltaTime, factor2 / Time.fixedDeltaTime));
		//Here we tell Unity what do do with our player
	}
}
