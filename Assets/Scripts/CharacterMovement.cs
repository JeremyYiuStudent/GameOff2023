using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public CharacterController2D controller;
    private float horizontalInput;
    private bool jumping = false;
    private ActionTrigger trigger;

    public enum controlStatus {movement, dialogue, readMenu};
    public static controlStatus currentStatus = controlStatus.movement;

    // Update is called once per frame
    void Update()
    {
        switch(currentStatus){
            case controlStatus.movement:
                horizontalInput = Input.GetAxis("Horizontal") * 40f;
                if(Input.GetButtonDown("Jump")){
                    jumping = true;
                }
                if(Input.GetButtonDown("Interact")){
                    Debug.Log("Interacting");
                    trigger.Activate();
                }
                break;
            case controlStatus.dialogue:
                if(Input.GetButtonDown("Interact")){
                    (trigger as DialogueController).Next();
                }
                break;
            case controlStatus.readMenu:
                break;
        }
    }
    void FixedUpdate(){
        controller.Move(horizontalInput * Time.fixedDeltaTime,false,jumping);
        jumping = false;
    }
    void OnTriggerEnter2D(Collider2D col){
        Debug.Log("Trigger");
        if(col.gameObject.layer == 3){trigger = col.gameObject.GetComponent<ActionTrigger>();}
    }
    void OnTriggerExit2D(Collider2D col){
        Debug.Log("Untrigger");
        if(col.gameObject.layer == 3){trigger = null;}
    }
}
