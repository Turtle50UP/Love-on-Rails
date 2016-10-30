using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	double camerallim = -2.137;
	double camerarlim = 2.5;
	
	// Update is called once per frame
	void Update () {
		Vector3 position = GameObject.Find("Player(Clone)").transform.position;
		Vector3 curpos = this.transform.position;
		if ((position.x > camerallim) && (position.x < camerarlim))
			curpos.x = position.x;
		this.transform.position = curpos;
	
	}
}
