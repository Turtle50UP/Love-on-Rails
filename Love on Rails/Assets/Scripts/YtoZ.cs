using UnityEngine;
using System.Collections;

public class YtoZ : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		Vector3 position = this.transform.position;
		position.z = position.y - 0.5f;
		this.transform.position = position;
	}
}
