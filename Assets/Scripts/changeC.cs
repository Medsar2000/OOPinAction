using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeC : MonoBehaviour
{
    void Start()
    {
        //Create a new cube primitive to set the color on
        GameObject cube = gameObject.transform.Find("Lamp").gameObject;

        //Get the Renderer component from the new cube
        var cubeRenderer = cube.GetComponent<Renderer>();

        //Call SetColor using the shader property name "_Color" and setting the color to red
        cubeRenderer.material.SetColor("_Color", Color.red);
    }
}
