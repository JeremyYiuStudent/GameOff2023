using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Transformer : ActionTrigger
{
    public Sprite transformTo;
    public Color color;
    public GameObject tileMap;
    public GameObject flasher;
    public override void Activate()
    {
        SpriteRenderer r = gameObject.GetComponent<SpriteRenderer>();
        r.sprite = transformTo;
        r.color = color;
        flasher.GetComponent<FlashController>().Flash();
        tileMap.GetComponent<MapColorToggle>().Coloring();
    }
    public override void Deactivate(){}
}
