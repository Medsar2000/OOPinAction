using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureFlag : MonoBehaviour
{
    private GameObject lamp;
    private Renderer lampRenderer;
    private float speed = 1f;
    private int VegetarianAnimalsCount;
    private int CarnivorousAnimalsCount;
    // Start is called before the first frame update
    void Start()
    {
        lamp = gameObject.transform.Find("Lamp").gameObject;

        //Get the Renderer component from the new cube
        lampRenderer = lamp.GetComponent<Renderer>();

        VegetarianAnimalsCount = 0;
        CarnivorousAnimalsCount = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(VegetarianAnimalsCount - CarnivorousAnimalsCount>0)
            StartCoroutine(ChangeFlagColour(Color.red, Color.green));
        else
            StartCoroutine(ChangeFlagColour(Color.green, Color.red));
       

    }

    private void OnTriggerEnter(Collider other)
    {

        //StartCoroutine(ChangeEngineColour(Color.green, Color.red));
        if (other.gameObject.GetComponent<Animal>().foodType == AnimalType.Vegetarian)
            VegetarianAnimalsCount++;
        else
            CarnivorousAnimalsCount++;
        Debug.Log(VegetarianAnimalsCount - CarnivorousAnimalsCount);


    }
    private void OnTriggerExit(Collider other)
    {

        // StartCoroutine(ChangeEngineColour(Color.red, Color.green));
        if (other.gameObject.GetComponent<Animal>().foodType == AnimalType.Vegetarian)
            VegetarianAnimalsCount--;
        else
            CarnivorousAnimalsCount--;
        Debug.Log(VegetarianAnimalsCount - CarnivorousAnimalsCount);
    }

    // ABSTRACTION
    private IEnumerator ChangeFlagColour(Color startColor, Color endColor)
    {
        float tick = 0f;
        while (lampRenderer.material.color != endColor && tick<2)
        {
            tick += Time.deltaTime * speed;
            lampRenderer.material.color = Color.Lerp(startColor, endColor, tick);
            yield return null;
        }
    }

   

}


