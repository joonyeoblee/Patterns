using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class ClientState : MonoBehaviour
    {
        private StatePlayerController _statePlayerController;
        void Start()
        {
            _statePlayerController = GetComponent<StatePlayerController>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _statePlayerController.JumpPlayer();
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                _statePlayerController.AttackPlayer();
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                _statePlayerController.IdlePlayer();
            }
        }
    }

}