using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : Animal
{
    Horse()
    {
        foodType = AnimalType.Vegetarian;
        health = 5;
        speed = 3;
        power = 3;

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // POLYMORPHISM
        growOld();
        walk();
        die();

        //Debug.Log(health);
    }
}