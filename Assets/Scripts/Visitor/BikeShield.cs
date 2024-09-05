using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Visitor;

public class BikeShield : MonoBehaviour, IBikeElement
{
    public float health = 50.0f; // percentage

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public float Damage(float Damage)
    {
        health -= Damage;
        return health;
    }

    void OnGUI()
    {
        GUI.color = Color.green;
        GUI.Label(new Rect(125, 0, 200, 20), "Shield Health: " + health);
    }
}
