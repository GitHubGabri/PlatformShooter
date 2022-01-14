using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashState : State
{
    protected D_DashState dashData;
    protected bool animationFinished;


    public DashState(Entity entity, FiniteStateMachine stateMachine, string animName, D_DashState dashData) : base(entity, stateMachine, animName)
    {
        this.dashData = dashData;
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("wow dash");
        entity.rb.AddForce(entity.movement * 8, ForceMode2D.Impulse);
    }

    public override void Exit()
    {
        base.Exit();
        entity.rb.RemoveForce(entity.movement * 8, ForceMode2D.Impulse);
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
        Exit();
    }

    public virtual void TriggerAttack()
    {

    }
    public virtual void FinishAttack()
    {
        animationFinished = true;
    }
}
