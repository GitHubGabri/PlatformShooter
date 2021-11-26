using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationToStatemachine : MonoBehaviour
{
    public AttackState attackState;
    public IdleState idleState;
    public DeathState deathState;
    public MovementState movementState;
    private void TriggerAttack()
    {
        attackState.TriggerAttack();
    }

    private void FinishAttack()
    {
        attackState.FinishAttack();
    }
    private void FinishIdle()
    {
        idleState.FinishIdle();

    }
    private void FinishDeath()
    {
        deathState.FinishDeath();
    }
}
