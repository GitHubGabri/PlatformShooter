using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : State
{
    protected D_AttackState stateData;
    protected Transform attackPosition;
    
    protected int[] attackInfo;
    protected bool animationFinished;
    protected bool seeTarget;
    public AttackState(Entity entity, FiniteStateMachine stateMachine, string animName, Transform attackPosition, D_AttackState stateData) : base(entity, stateMachine, animName)
    {
        this.stateData = stateData;
        this.attackPosition = attackPosition;
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
        entity.atsm.attackState = this;
        attackInfo = new int[1] {stateData.damage};
        animationFinished = false;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    public virtual void TriggerAttack()
    {

    }
    public virtual void FinishAttack()
    {
        animationFinished = true;
    }
}
