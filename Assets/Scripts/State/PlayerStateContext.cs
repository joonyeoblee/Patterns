using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class PlayerStateContext
    {
        public IPlayerState currentState { get; set; }

        private readonly StatePlayerController _playerController;


        public PlayerStateContext(StatePlayerController statePlayerController)
        {
            _playerController = statePlayerController;
        }


        public void Trasition()
        {
            currentState.Handle(_playerController);
        }

        public void Trasition(IPlayerState newState)
        {
            currentState = newState;
            currentState.Handle(_playerController);
        }

    }
}
