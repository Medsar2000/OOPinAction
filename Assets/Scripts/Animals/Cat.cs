using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cat : Animal
{
    Cat()
    {
        foodType = AnimalType.Carnivorous;
        health = 5;
        speed = 5;
        power = 3;

    }

    // POLYMORPHISM
    public override void walk()
    {
        
        base.walk();
    }

}
