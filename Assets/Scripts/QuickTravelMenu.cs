using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTravelMenu : ActionTrigger
{
    public GameObject map;
    public override void Activate(){
        map.SetActive(true);
        CharacterMovement.currentStatus = CharacterMovement.controlStatus.readMenu;
    }
    public override void Deactivate(){
        map.SetActive(false);
        CharacterMovement.currentStatus = CharacterMovement.controlStatus.movement;
    }
}
