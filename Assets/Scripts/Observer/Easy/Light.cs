using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : ISwitchable
{
    private bool isActive;
    public override bool IsActive => isActive;

    public override void Activate()
    {
        isActive = true;
        Debug.Log("Light on");
    }

    public override void Deactivate()
    {
        isActive = false;
        Debug.Log("Light off");
    }
}
