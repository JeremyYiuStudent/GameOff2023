using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformer : ActionTrigger
{
    public Sprite transformTo;
    public Color color;
    public override void Activate()
    {
        SpriteRenderer r = gameObject.GetComponent<SpriteRenderer>();
        r.sprite = transformTo;
        r.color = color;
    }
    public override void Deactivate(){}
}
