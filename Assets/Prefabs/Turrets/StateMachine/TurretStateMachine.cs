using System.Collections.Generic;
using UnityEngine;



namespace TurretStates.StateMachine
{
    public enum TurretStateType
    {
        Spawn,
        Idle,
        Firing,
        Reloading
    }
    public readonly struct TurretContext
    {
        public readonly BaseTurret turret;

        public TurretContext(BaseTurret turret)
        {
            this.turret = turret;
        }
    }
    public class TurretStateMachine : BaseStateMachine<TurretStateType, TurretContext>
    {
        private TurretContext CreateContext()
        {
            return new TurretContext(GetComponent<BaseTurret>());
        }

        public override Dictionary<TurretStateType, BaseState<TurretStateType, TurretContext>> CreateStates()
        {
            var context = CreateContext();
            var spawnState = new Spawn(TurretStateType.Spawn, context);
            var idleState = new Idle(TurretStateType.Idle, context);
            var shootingState = new Shooting(TurretStateType.Firing, context);
            var reloadingState = new Reloading(TurretStateType.Reloading, context);

            return new Dictionary<TurretStateType, BaseState<TurretStateType, TurretContext>>
            {
                { TurretStateType.Spawn, spawnState },
                { TurretStateType.Idle, idleState },
                { TurretStateType.Firing, shootingState },
                { TurretStateType.Reloading, reloadingState }
            };
        }
    }
}