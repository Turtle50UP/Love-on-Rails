using UnityEngine;
using System.Collections;

public class AIMovementRANDOM : MonoBehaviour {

	float speed=0.3f;
	float factor1 = 0.0f;
	float factor2 = 0.0f;
	float framecount = 0f;
	float movecount = 0f;

	//This is how fast we want our player to run upon keypress.
	void updatefm(){
		float llim = 120.0f;
		float ulim = 180.0f;
		framecount = Mathf.Round(Random.Range(llim,ulim));
		movecount = Mathf.Round(Random.Range(0.0f,framecount));
	}
	// Use this for initialization
	void Start () {
		//Here we tell Unity all the details about our player.
		//This info may change over the course of the game,
		//but must be present at the beginning.
		updatefm();
	}

	// Update is called once per frame
	void Update () {
		if (Time.frameCount % framecount == 0) {
			factor1 = Random.Range (-speed, speed);
			factor2 = Random.Range (-speed, speed);
			updatefm ();
		}
		if (Time.frameCount % framecount <= movecount) {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(factor1 / Time.fixedDeltaTime, factor2 / Time.fixedDeltaTime));
		}
		//Here we tell Unity what do do with our player
	}
}
