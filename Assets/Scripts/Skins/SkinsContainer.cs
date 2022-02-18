using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinsContainer : MonoBehaviour
{
    public static Sprite Selected1;

    public static Sprite Selected2;

    public static int Prueba;
    public static int Prueba2;
    private void Update()
    {
        Debug.Log(Prueba);
        Debug.Log(Prueba2);

        DontDestroyOnLoad(gameObject);
    }

}
