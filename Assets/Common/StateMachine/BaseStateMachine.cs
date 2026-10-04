using System.Collections.Generic;
using UnityEngine;

public abstract class BaseStateMachine<TStateType, TContext> : MonoBehaviour
where TStateType : struct
where TContext: struct
{
    [SerializeField] private TStateType initialState;
    private BaseState<TStateType, TContext> currentState;
    private Dictionary<TStateType, BaseState<TStateType, TContext>> states = new();
    public abstract Dictionary<TStateType, BaseState<TStateType, TContext>> CreateStates();
    public void Initialize()
    {
        states = CreateStates();
        foreach (var state in states.Values)
        {
            state.ChangeStateEvent += OnChangeState;
        }
        currentState = states[initialState];
        StartStateMachine();
        
    }
    public void StartStateMachine()
    {
        currentState.Enter();
    }
    private void OnChangeState(TStateType nextStateId)
    {
        currentState.Exit();
        currentState = states[nextStateId];
        currentState.Enter();
    }

    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        currentState.OnCollisionEnter2D(collision);
    }
    public virtual void OnCollisionExit2D(Collision2D collision)
    {
        currentState.OnCollisionExit2D(collision);
    }
    public virtual void OnCollisionStay2D(Collision2D collision)
    {
        currentState.OnCollisionStay2D(collision);
    }
    public virtual void OnTriggerEnter2D(Collider2D collider)
    {
        currentState.OnTriggerEnter2D(collider);   
    }
    public virtual void OnTriggerExit2D(Collider2D collider)
    {
        currentState.OnTriggerExit2D(collider);
    }
    public virtual void OnTriggerStay2D(Collider2D collider)
    {
        currentState.OnTriggerStay2D(collider);
    }

}
