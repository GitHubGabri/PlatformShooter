using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinLoader : MonoBehaviour
{

    public SpriteRenderer Player1;
    public SpriteRenderer Player2;

    private void Start()
    {

        Player1.sprite = SkinsContainer.Selected1;
        Player2.sprite = SkinsContainer.Selected2;

    }
}
