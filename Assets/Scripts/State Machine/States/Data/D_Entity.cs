using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newEntityData", menuName = "Data/Entity Data/Base Data")]
public class D_Entity : ScriptableObject
{
    [Tooltip("Max health the entity will have")]
    public int maxHealth = 10;

    [Tooltip("Default velocity of the entity")]
    public int velocity = 10;
}
