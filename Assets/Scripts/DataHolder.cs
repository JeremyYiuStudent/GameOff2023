using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHolder
{
    public static Color activeColor;
    //{PaintShop, Streets, Office, Hotel, Vault, Subway, Skydive}
    public static bool[] quickTravel = {true, true, false, false, false, false, false};

    public static int maxJump = 0;
    public static bool canDash = false;
    public static bool[] toggleColor = {false,false};
}
