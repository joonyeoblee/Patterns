using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public InputHandler inputHandler;
    private Player player;

    void Start()
    {
        // Actor�� �����Ͽ� InputHandler�� �Ҵ�
        player = gameObject.AddComponent<Player>();
        inputHandler.SetActor(player);

        inputHandler.AssignCommand(KeyCode.Space, new JumpCommand());
        inputHandler.AssignCommand(KeyCode.Z, new FireCommand());
        inputHandler.AssignCommand(KeyCode.X, new Swap_weapon());
        inputHandler.AssignCommand(KeyCode.C, new LurchCommand());

        
    }
}
