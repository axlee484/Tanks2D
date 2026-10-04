using System;
using UnityEngine;

public abstract class BaseState<TStateType, TContext> 
where TStateType : struct
where TContext: struct
{
    private TContext context;
    private TStateType stateId;
    public event Action<TStateType> ChangeStateEvent;
    
    public TContext Context => context;
    public TStateType StateId => stateId;
    public BaseState(TStateType stateId, TContext context)
    {
        this.stateId = stateId;
        this.context = context;
    }
    
    public void Enter() {}
    public void Exit() {}
    public void Update(){}
    public void FixedUpdate(){}
    public void OnCollisionEnter2D(Collision2D collision){} 
    public void OnCollisionStay2D(Collision2D collision){}
    public void OnCollisionExit2D(Collision2D collision){}
    public void OnTriggerEnter2D(Collider2D collision){}
    public void OnTriggerStay2D(Collider2D collision){}
    public void OnTriggerExit2D(Collider2D collision){}
}
