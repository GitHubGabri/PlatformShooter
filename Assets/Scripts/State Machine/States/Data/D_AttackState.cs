using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D_AttackState : ScriptableObject
{
    [Tooltip("Damage the enemy will do in attack")]
    public int damage = 5;

    [Tooltip("Rate of attack from the entity")]
    public float attackRate = 1000f;

    [Tooltip("What can damage the attack? Sorted in LayerMasks")]
    public LayerMask whatIsDamageable;
}
