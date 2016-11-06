using UnityEngine;
using System.Collections;

public class ObjSpawner : MonoBehaviour {
	public GameObject[] prefabs;
	public float yval = 0f;
	public float objamt = 0f;
	public float xmin = 0f;
	public float xmax = 0f;
	public float delx = 0f;

	// Use this for initialization
	void Start () {
		if (objamt > 0)
			delx = (xmax - xmin) / (objamt-1);
		for (int i = 0; i < objamt; i++)
			objGen (delx*i+xmin);
	}

	void objGen(float x){
		Vector3 pos = this.transform.position;
		pos.x = x;
		pos.y = yval;
		GameObjUtil.Instantiate(prefabs[Random.Range(0,prefabs.Length)],pos);
	}
}
