using UnityEngine;
using System.Collections;

public class PSpawner : MonoBehaviour {
	public GameObject[] prefabs;
	float y = -0.2f;
	float x = -3.2f;
	//public bool active = false;
	//public bool exist = false;


	// Use this for initialization
	void Start () {
//		active = true;
		PGen ();
	}
		
	void PGen(){
		Vector3 pos = this.transform.position;
		pos.x = x;
		pos.y = y;
		GameObjUtil.Instantiate(prefabs[Random.Range(0,prefabs.Length)],pos);
	}
}
