using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementState : State
{
    public D_MovementState movementData;
    protected bool animationFinished;

    public MovementState(Entity entity, FiniteStateMachine stateMachine, string animName, D_MovementState movementData) : base(entity, stateMachine, animName)
    {
        this.movementData = movementData;
    }

    public override void Enter()
    {
        base.Enter();
        //Debug.Log("Has entrado en Movement State");
        //entity.atsm.movementState = this;
        //animationFinished = false;
        
    }

    public override void Exit()
    {
        //Debug.Log("Sal");
        base.Exit();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
        Mover();
    }
    public override void DoChecks()
    {
        base.DoChecks();
    }
    public virtual void FinishMovement()
    {
        animationFinished = true;
    }
    private void Mover(){
    Vector3 movimiento= entity.movement;
    Vector3 direction = Vector3.zero;
    direction.x= movimiento.x;
    direction.y= movimiento.y;
    float timeSinceLastFrame = Time.deltaTime;
    Vector3 translation = direction * timeSinceLastFrame * entity.entityData.velocity;    
    entity.transform.Translate(translation);
    if (direction.y < 0 && direction.x == 0){
        //CambiarSprite(entity.detras);
    }
    if(direction.x>0){
    //CambiarSprite(entity.derechaizquierda);
    entity.sp.flipX=true;   
    }
    if(direction.x<0){
    //CambiarSprite(entity.derechaizquierda);
    entity.sp.flipX=false;   
    }
    }
    private void CambiarSprite(Sprite newSprite){
       entity.sp.sprite = newSprite; 
    }
}


