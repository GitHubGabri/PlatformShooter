using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    protected float startTime;
    public virtual void Enter()
    {
        startTime = Time.time;
    }

    public virtual void Exit()
    {

    }
    public virtual void LogicUpdate()
    {
        
    }
    public virtual void PhysicsUpdate()
    {

    }
}
