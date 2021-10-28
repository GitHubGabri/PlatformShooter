using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D_AttackState : ScriptableObject
{
    [Tooltip("Damage the attack will do")]
    public int damage = 5;

    [Tooltip("Rate of attack")]
    public float attackRate = 1000f;

    [Tooltip("What can damage the attack? Sorted in LayerMasks")]
    public LayerMask whatIsDamageable;
}
