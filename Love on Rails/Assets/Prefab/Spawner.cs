using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject[] prefabs;
	float amount = 0f;
	float ymin = -0.4f;
	float ymax = -0.1f;
	float xmin = -3f;
	float xmax = 3.5f;
	public int count = 0;
	public bool active = false;
	public bool exist = false;
	public float[] ranges = new float[2] {6f,12f};


	// Use this for initialization
	void Start () {
		active = true;
		multiCivGen ();
	}

	void multiCivGen(){
		amount = Mathf.Round(Random.Range (ranges [0], ranges [1]));
		for (int i = 0; i < amount; i++) {
			civGen ();
			count++;
		}
		active = false;
		exist = true;
	}
		
	void civGen(){
			Vector3 pos = this.transform.position;
			pos.x = Random.Range (xmin, xmax);
			pos.y = Random.Range (ymin, ymax);
			GameObjUtil.Instantiate(prefabs[Random.Range(0,prefabs.Length)],pos);
	}
	// Update is called once per frame
	void Update () {
		debugOnKey ();
		if (active && !exist)
			multiCivGen ();
	}

	public void debugOnKey(){
		if (Input.GetKey (KeyCode.R))
			active = true;
		if (Input.GetKey (KeyCode.Space))
			exist = false;;
	}
}
