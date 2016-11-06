using UnityEngine;
using System.Collections;

public class KillTarg : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		debugOnKey ();
	}

	public void debugOnKey(){
		if (Input.GetKey (KeyCode.Space))
			GameObjUtil.Destroy (gameObject);
	}
}
