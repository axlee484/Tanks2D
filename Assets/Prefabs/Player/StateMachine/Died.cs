using UnityEngine;

namespace PlayerStates.StateMachine
{
    public class Died : BaseState<PlayerStateType, PlayerContext>
    {
        public Died(PlayerStateType stateId, PlayerContext context) : base(stateId, context)
        {
        }
    }
}