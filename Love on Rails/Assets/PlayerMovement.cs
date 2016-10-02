using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	float speed=0.3f;
	//This is how fast we want our player to run upon keypress.

	// Use this for initialization
	void Start () {
		//Here we tell Unity all the details about our player.
		//This info may change over the course of the game,
		//but must be present at the beginning.
		GetComponent<Rigidbody2D>().drag = 20;
		GetComponent<Rigidbody2D>().mass = 1;
	}
	
	// Update is called once per frame
	void Update () {
        //Here we tell Unity what do do with our player

        if (Input.GetKey(KeyCode.Escape))
        {
            //This tells Unity that if the player presses escape,
            //the game will shut down
            Application.Quit();
        }

        if (Input.GetKey(KeyCode.D))
        {
            //This if statement is listening for a keypress.
            //If the user presses D, the following will occur:
            GetComponent<Rigidbody2D>().AddForce(new Vector2(speed / Time.fixedDeltaTime, 0));
            //This means that we are adding a force to the player's rigidbody.
            //We want this force to be independent of all forces applied before it,
            //so we make it "new".
            //We want to use a 2D vector because we are operating in 2D.
            //We want to change the player's speed by a factor of the game's internal time.
            //This allows for smooth movement on machines of differing processing capabilities.
            //AKA no lag.
            //D = go right, so we want positive change over the x axis. We don't want to y axis
            //to change at all, so if (x,y), then we keep y at 0
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed / Time.fixedDeltaTime, 0));
            //A = go left, so we want negative change over the x axis. We don't want to y axis
            //to change at all, so if (x,y), then we keep y at 0
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, speed / Time.fixedDeltaTime));
            //W = go up, so we want positive change on the y axis, no change on the x axis.
            //so if (x,y), then we keep x at 0
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -speed / Time.fixedDeltaTime));
            //S = go down, so we want negative change on the y axis, no change on the x axis.
            //so if (x,y), then we keep x at 0
        }
    }
}
