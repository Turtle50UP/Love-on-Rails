using UnityEngine;
using System.Collections;

public class CameraAspectRatio : MonoBehaviour {


    void Awake()
    {
        GetComponent<Camera>().aspect = 4 / 3;
    }

}
