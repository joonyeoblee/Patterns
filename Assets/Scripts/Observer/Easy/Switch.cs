using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public ISwitchable[] clients;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Toggle();
        }
    }

    public void Toggle()
    {
        foreach (ISwitchable client in clients)
        {
            if (client.IsActive)
            {
                client.Deactivate();
            }
            else
            {
                client.Activate();
            }
        }

    }
}
