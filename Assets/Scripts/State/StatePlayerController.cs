using UnityEngine;

namespace State
{
    public class StatePlayerController : MonoBehaviour
    {
        public float maxSpeed = 2.0f;
        public float jumpForce = 2.0f;

        public float currentSpeed { get; set; }

        private IPlayerState _IdleState, _AttackState, _jumpState;

        private PlayerStateContext _playerStateContext;

        private void Start()
        {
            _playerStateContext = new PlayerStateContext(this);

            _IdleState = gameObject.AddComponent<IdleState>();
            _AttackState = gameObject.AddComponent<AttackState>();
            _jumpState = gameObject.AddComponent<JumpState>();

            _playerStateContext.Trasition(_IdleState);

        }

        public void IdlePlayer()
        {
            _playerStateContext.Trasition(_IdleState);
        }

        public void AttackPlayer()
        {
            _playerStateContext.Trasition(_AttackState);
        }

        public void JumpPlayer()
        {
            _playerStateContext.Trasition(_jumpState);
        }




    }
}
