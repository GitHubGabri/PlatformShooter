using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newDeathStateData", menuName = "Data/State Data/Death/Death State")]
public class D_DeathState : ScriptableObject
{
    public float despawnTime = 4000f;
    public GameObject explosionRef;
}
