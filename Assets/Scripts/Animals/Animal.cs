using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    // ENCAPSULATION
    protected AnimalType foodType;
    protected float health;
    protected float power;
    protected float speed;

    // POLYMORPHISM
    public virtual void walk()
    {
        //transform.position = Vector3.MoveTowards(transform.position,)

    }

    // POLYMORPHISM
    public virtual void growOld()
    { 
        health -= Time.deltaTime;
    }

    // POLYMORPHISM
    public virtual void die()
    {
        if (health < 0)
            Destroy(gameObject);
    }

}

