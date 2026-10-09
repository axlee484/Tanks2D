using UnityEngine;

namespace TurretStates.StateMachine
{
    public class Spawn : BaseState<TurretStateType, TurretContext>
    {
        public Spawn(TurretStateType stateType, TurretContext context) : base(stateType, context){}
        public override void Enter()
        {
            
        }
    }
}
