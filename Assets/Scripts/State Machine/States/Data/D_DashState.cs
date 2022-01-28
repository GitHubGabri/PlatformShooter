using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newDashStateData", menuName = "Data/State Data/Dash/Dash State")]


public class D_DashState : ScriptableObject
{
    public float dashTime = 3f;
    public float dashDelay = 5f;
}
