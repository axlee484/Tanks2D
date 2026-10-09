using UnityEngine;

namespace PlayerStates.StateMachine
{
    public class Moving : BaseState<PlayerStateType, PlayerContext>
    {
        public Moving(PlayerStateType stateId, PlayerContext context) : base(stateId, context)
        {
        }
    }
}