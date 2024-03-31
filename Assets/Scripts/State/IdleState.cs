using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class IdleState : MonoBehaviour, IPlayerState
    {
        public void Handle(StatePlayerController player)
        {
            player.currentSpeed = 0;
            Debug.Log("Idle");
        }
    }
}
