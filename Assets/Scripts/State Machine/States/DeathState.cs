using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathState : State
{
    public D_DeathState deathData;
    protected bool animationFinished;
    private GameObject explosion;
    public DeathState(Entity entity, FiniteStateMachine stateMachine, string animName, D_DeathState deathData) : base(entity, stateMachine, animName)
    {
        this.deathData = deathData;
    }

    public override void Enter()
    {
        base.Enter();
        entity.atsm.deathState = this;
        animationFinished = false;
        
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if (animationFinished)
        {
            Explosion();
            GameObject.Destroy(entity.gameObject);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
        
    }

    public virtual void Explosion()
    {
        if (deathData.explosionRef != null)
        {
            explosion = (GameObject)Object.Instantiate(deathData.explosionRef);
            explosion.transform.position = new Vector3(entity.character.transform.position.x, entity.character.transform.position.y, entity.character.transform.position.z);
        }
    }

    public virtual void FinishDeath()
    {
        animationFinished = true;
    }
}
