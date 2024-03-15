using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Actor: MonoBehaviour
{
    private Collider Collider;
    private Transform Transform;

    private void Start()
    {
        Collider = GetComponent<Collider>();
        Transform = GetComponent<Transform>();
    }

    public abstract void Jump();

}
