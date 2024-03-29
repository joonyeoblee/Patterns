using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Monster prototype_;

    public Monster Spawn()
    {
        return prototype_.Clone();
    }

}
