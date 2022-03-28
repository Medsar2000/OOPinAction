using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureFlag : MonoBehaviour
{
    private GameObject lamp;
    private Renderer lampRenderer;
    private float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        lamp = gameObject.transform.Find("Lamp").gameObject;

        //Get the Renderer component from the new cube
        lampRenderer = lamp.GetComponent<Renderer>();

       

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
       
        StartCoroutine(ChangeEngineColour(Color.green, Color.red));
       

    }
    private void OnTriggerExit(Collider other)
    {
      
        StartCoroutine(ChangeEngineColour(Color.red, Color.green));
       
    }

    private IEnumerator ChangeEngineColour(Color startColor, Color endColor)
    {
        float tick = 0f;
        while (lampRenderer.material.color != endColor && tick<2)
        {
            tick += Time.deltaTime * speed;
            Debug.Log(tick);
            lampRenderer.material.color = Color.Lerp(startColor, endColor, tick);
            yield return null;
        }
    }
}


