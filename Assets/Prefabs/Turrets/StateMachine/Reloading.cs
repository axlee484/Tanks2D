

namespace TurretStates.StateMachine

{
    public class Reloading : BaseState<TurretStateType, TurretContext>
    {
        public Reloading(TurretStateType stateId, TurretContext context) : base(stateId, context)
        {
        }
    }
}