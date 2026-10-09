using System;
using UnityEngine;

public abstract class BaseState<TStateType, TContext> 
where TStateType : struct
where TContext: struct
{
    private TContext context;
    private TStateType stateId;
    public event Action<TStateType> ChangeStateEvent;
    public void InvokeChangeStateEvent(TStateType nextStateId)
    {
        ChangeStateEvent?.Invoke(nextStateId);
    }
    
    public TContext Context => context;
    public TStateType StateId => stateId;
    public BaseState(TStateType stateId, TContext context)
    {
        this.stateId = stateId;
        this.context = context;
    }
    
    public virtual void Enter() {}
    public virtual void Exit() {}
    public virtual void Update(){}
    public virtual void FixedUpdate(){}
    public virtual void OnCollisionEnter2D(Collision2D collision){} 
    public virtual void OnCollisionStay2D(Collision2D collision){}
    public virtual void OnCollisionExit2D(Collision2D collision){}
    public virtual void OnTriggerEnter2D(Collider2D collision){}
    public virtual void OnTriggerStay2D(Collider2D collision){}
    public virtual void OnTriggerExit2D(Collider2D collision){}
}
