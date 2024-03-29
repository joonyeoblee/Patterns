using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    Spawner spawner = new Spawner();

    void Start()
    {
        spawner.prototype_ = new Ghost(100, 10);
        Monster monster = spawner.Spawn();


        Debug.Log(monster.hp);
        Debug.Log(((Ghost)monster).speed);
    }
}
