using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : ISwitchable
{
    private bool isActive;

    public override bool IsActive => isActive;

    public override void Activate()
    {
        isActive = true;
        Debug.Log("Door open");
    }

    public override void Deactivate()
    {
        isActive = false;
        Debug.Log("Door close");
    }
}
