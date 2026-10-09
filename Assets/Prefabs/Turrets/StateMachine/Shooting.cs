
namespace TurretStates.StateMachine
{
    public class Shooting : BaseState<TurretStateType, TurretContext>
    {
        public Shooting(TurretStateType stateId, TurretContext context) : base(stateId, context)
        {
        }

    }
}