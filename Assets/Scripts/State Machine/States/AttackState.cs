using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : State
{
    protected D_AttackState attackData;
    protected Transform attackPosition;
    
    //protected int[] attackInfo;
    protected bool animationFinished;
    //protected bool seeTarget;
    public AttackState(Entity entity, FiniteStateMachine stateMachine, string animName, D_AttackState attackData) : base(entity, stateMachine, animName)
    {
        this.attackData = attackData;
        //this.attackPosition = attackPosition;
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
        //entity.atsm.attackState = this;
        //attackInfo = new int[1] {attackData.damage};
        //animationFinished = false;
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
        Enter();
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
