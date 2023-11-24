using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom Asset/Item")]
public class Item : ScriptableObject
{
    public Sprite image;
    public string name;
    public string description;
}
