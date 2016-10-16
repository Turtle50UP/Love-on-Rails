using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NextRoom : MonoBehaviour {

    public Image objectFound;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit");
        objectFound.canvasRenderer.SetAlpha(255);
    }

}
