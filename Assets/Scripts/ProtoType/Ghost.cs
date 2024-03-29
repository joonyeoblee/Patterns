using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Monster
{
    public int speed;
    public Ghost(int hp_, int speed_)
    {
        hp = hp_;
        speed = speed_;
    }
    public override Monster Clone()
    {
        return new Ghost(hp, speed);
    }
}
