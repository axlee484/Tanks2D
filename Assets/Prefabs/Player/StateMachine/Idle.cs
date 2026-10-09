using UnityEngine;

namespace PlayerStates.StateMachine
{
    public class Idle : BaseState<PlayerStateType, PlayerContext>
    {
        public Idle(PlayerStateType stateId, PlayerContext context) : base(stateId, context)
        {
        }

        public override void Enter()
        {
            base.Enter();
            Debug.Log("Entered Idle State");
        }
    }
}