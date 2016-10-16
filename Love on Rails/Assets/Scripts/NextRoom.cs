using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NextRoom : MonoBehaviour {

    public Image objectFound;
    public Image dimImage;
    public Text displayText;
    private bool hit = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Next room trigger hit");
        objectFound.canvasRenderer.SetAlpha(255);
        hit = true;
    }

    void Update()
    {
        if (hit)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                StartCoroutine(dim());
                hit = false;
            }
        }
        if(Input.GetKey(KeyCode.L))
        {
            objectFound.canvasRenderer.SetAlpha(255);
            hit = true;
        }
        
        
    }

    IEnumerator dim()
    {
        float mult = 10f;
        while (dimImage.canvasRenderer.GetAlpha() < 255)
        {
            yield return new WaitForSeconds(0.05f);
            dimImage.canvasRenderer.SetAlpha(mult);
            mult += 10f;
        }
        
    }

}
