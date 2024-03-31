using UnityEngine;

namespace State
{
    public class JumpState : MonoBehaviour, IPlayerState
    {
        public void Handle(StatePlayerController player)
        {
            player.currentSpeed = 0;
            Debug.Log("Jump");
        }
    }
}