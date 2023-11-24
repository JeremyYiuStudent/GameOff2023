using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueController : ActionTrigger
{
    public Dialogue myDialogue;
    public GameObject dialogueUI;
    public GameObject dialogueText;
    public GameObject speakerText;
    private int index = 0;
    public override void Activate(){
        index = 0;
        dialogueUI.SetActive(true);
        CharacterMovement.currentStatus = CharacterMovement.controlStatus.dialogue;
        loadDialogue();
    }
    public override void Deactivate(){
        dialogueUI.SetActive(false);
        CharacterMovement.currentStatus = CharacterMovement.controlStatus.movement;
    }
    public void Next(){
        index++;
        if(myDialogue.lines.Length == index){Deactivate();}
        else{loadDialogue();}
    }
    private void loadDialogue(){
        dialogueText.GetComponent<TextMeshProUGUI>().text = myDialogue.lines[index].text;
        speakerText.GetComponent<TextMeshProUGUI>().text = myDialogue.lines[index].speaker;
    }
}
