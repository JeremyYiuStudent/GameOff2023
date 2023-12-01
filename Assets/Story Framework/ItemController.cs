using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemController : ActionTrigger
{
    public Item myItem;
    public GameObject itemUI;
    public GameObject itemName;
    public GameObject itemDesc;
    public GameObject itemSprite;
    public override void Activate(){
        itemUI.SetActive(true);
        CharacterMovement.currentStatus = CharacterMovement.controlStatus.readMenu;
        loadItem();
    }
    public override void Deactivate(){
        itemUI.SetActive(false);
        CharacterMovement.currentStatus = CharacterMovement.controlStatus.movement;
    }
    private void loadItem(){
        itemName.GetComponent<TextMeshProUGUI>().text = myItem.name;
        itemDesc.GetComponent<TextMeshProUGUI>().text = myItem.description;
        itemSprite.GetComponent<Image>().sprite = myItem.image;
    }
}
