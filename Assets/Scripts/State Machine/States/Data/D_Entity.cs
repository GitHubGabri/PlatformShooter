using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newEntityData", menuName = "Data/Entity Data/Base Data")]
public class D_Entity : ScriptableObject
{
    [Tooltip("What tag will have our target")]
    public string targetTag = "Player";

    [Tooltip("Minimum range where the agent will start to attack the target")]
    public float minAggroRange = 100f;

    [Tooltip("Maximum range where the agent follow the target")]
    public float maxAggroRange = 200f;

    [Tooltip("The range for the entity to do close actions like melee attacks")]
    public float closeRangeActionDistance = 1;

    [Tooltip("Max health the enemy will have")]
    public int maxHealth = 10;

    public enum Factions
    {
        Allied = 1,
        Neutral = 0,
        Enemy = -1
    }

    public Factions faction;
}
