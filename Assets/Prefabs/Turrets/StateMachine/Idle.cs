

namespace TurretStates.StateMachine
{
    public class Idle : BaseState<TurretStateType, TurretContext>
    {
        public Idle(TurretStateType stateId, TurretContext context) : base(stateId, context)
        {
        }
    }
}