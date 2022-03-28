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

    
    public virtual void walk()
    {
        //transform.position = Vector3.MoveTowards(transform.position,)

    }

}

