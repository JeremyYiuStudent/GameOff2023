using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTravelMenu : ActionTrigger
{
    public GameObject map;
    public override void Activate(){
        map.SetActive(true);
    }
}
