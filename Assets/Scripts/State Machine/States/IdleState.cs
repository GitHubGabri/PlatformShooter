using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    public D_IdleState idleData;
    protected bool animationFinished;

    public IdleState(Entity entity, FiniteStateMachine stateMachine, string animName, D_IdleState idleData) : base(entity, stateMachine, animName)
    {
        this.idleData = idleData;
    }

    public override void Enter()
    {
        base.Enter();
        entity.atsm.idleState = this;
        animationFinished = false;
        
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
    public override void DoChecks()
    {
        base.DoChecks();
    }
    public virtual void FinishIdle()
    {
        animationFinished = true;
    }
}
