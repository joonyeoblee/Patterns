using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand
{
    void Execute(Actor actor);
}

public class JumpCommand : ICommand
{
    public void Execute(Actor actor)
    {
        //Debug.Log(actor.name + " is jumping");
        actor.Jump();
    }
}

public class FireCommand : ICommand
{
    public void Execute(Actor actor)
    {
        Debug.Log(actor.name + " is firing");
    }
}

public class Swap_weapon : ICommand
{
    public void Execute(Actor actor)
    {
        Debug.Log(actor.name + " is swapping weapons");
    }
}

public class LurchCommand : ICommand
{
    public void Execute(Actor actor)
    {
        Debug.Log(actor.name + " is lurching");
    }
}
