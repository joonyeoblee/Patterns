using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class AttackState : MonoBehaviour, IPlayerState
    {
        public void Handle(StatePlayerController player)
        {
            player.currentSpeed = 0;
            Debug.Log("Attack");
        }
    }
}
