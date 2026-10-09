using System.Collections.Generic;
using UnityEngine;

namespace PlayerStates.StateMachine
{
    public enum PlayerStateType
    {
        Idle,
        Moving,
        Died
    }
    public readonly struct PlayerContext
    {
        public readonly Player player;
        public PlayerContext(Player player)
        {
            this.player = player;
        }
    }
    public class PlayerStateMachine : BaseStateMachine<PlayerStateType, PlayerContext>
    {
        private PlayerContext CreateContext()
        {
            return new PlayerContext(GetComponent<Player>());
        }
        public override Dictionary<PlayerStateType, BaseState<PlayerStateType, PlayerContext>> CreateStates()
        {
            var context = CreateContext();
            Dictionary<PlayerStateType, BaseState<PlayerStateType, PlayerContext>> states = new();
            var idleState = new Idle(PlayerStateType.Idle, context);
            var movingState = new Moving(PlayerStateType.Moving, context);
            var diedState = new Died(PlayerStateType.Died, context);

            states.Add(PlayerStateType.Idle, idleState);
            states.Add(PlayerStateType.Moving, movingState);
            states.Add(PlayerStateType.Died, diedState);
            return states;
        }
    }

}