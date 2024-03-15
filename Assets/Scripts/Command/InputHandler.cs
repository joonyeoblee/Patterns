using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Dictionary<KeyCode, ICommand> keyCommands = new Dictionary<KeyCode, ICommand>();

    public Actor actor;
    public void AssignCommand(KeyCode key, ICommand command)
    {
        if (!keyCommands.ContainsKey(key))
        {
            keyCommands[key] = command;
        }
        else
        {
            keyCommands[key] = command;
        }
    }

    public void SetActor(Actor actor)
    {
        this.actor = actor;
    }

    void Update()
    {

        if (actor != null)
        {
            foreach (var keyCommand in keyCommands)
            {
                if (Input.GetKeyDown(keyCommand.Key))
                {
                    keyCommand.Value.Execute(actor);
                }
            }
        }
    }
}
