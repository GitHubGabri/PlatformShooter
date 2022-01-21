using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabilidadState : State
{
    protected D_HabilidadState habilidadData;
    protected bool animationFinished;

    public HabilidadState(Entity entity, FiniteStateMachine stateMachine, string animName, D_HabilidadState habilidadData) : base(entity, stateMachine, animName)
    {
        this.habilidadData = habilidadData;
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
        //Debug.Log("wow habilidad");
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
