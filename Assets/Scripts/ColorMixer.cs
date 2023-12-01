using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorMixer : ActionTrigger
{
    public GameObject palette;
    public GameObject paletteCenter;
    
    private static Color activeColor;
    private int holder;

    private Color[] colorTable = {Color.red, Color.yellow, Color.magenta, Color.green, Color.white, Color.cyan, Color.white, Color.white, Color.blue};
    public override void Activate(){
        palette.SetActive(true);
        CharacterMovement.currentStatus = CharacterMovement.controlStatus.readMenu;
    }
    public override void Deactivate(){
        palette.SetActive(false);
        holder = 0;
        CharacterMovement.currentStatus = CharacterMovement.controlStatus.movement;
    }
    public void processInput(int input){
        if(holder == 0){holder = input;}
        else{
            activeColor = colorTable[holder*input-1];
            paletteCenter.GetComponent<Image>().color = activeColor;
            holder = 0;
            Deactivate();
        }
    }
}
