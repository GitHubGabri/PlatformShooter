using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : State
{
    protected D_AttackState attackData;
    protected Transform attackPosition;
    private Weapon actualWeapon;
    
    //protected int[] attackInfo;
    protected bool animationFinished;
    //protected bool seeTarget;
    public AttackState(Entity entity, FiniteStateMachine stateMachine, string animName, Weapon weapon) : base(entity, stateMachine, animName)
    {

    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
        actualWeapon.Enter();
    }

    public override void Exit()
    {
        base.Exit();
        actualWeapon.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        actualWeapon.LogicUpdate();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
        actualWeapon.PhysicsUpdate();
    }

    public virtual void TriggerAttack()
    {

    }
    public virtual void FinishAttack()
    {
        animationFinished = true;
    }
}
