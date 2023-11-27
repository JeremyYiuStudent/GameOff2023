using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public CharacterController2D controller;
    private float horizontalInput;
    private bool jumping = false;
    private ActionTrigger trigger;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal") * 40f;
        if(Input.GetButtonDown("Jump")){
            jumping = true;
        }
        if(Input.GetButtonDown("Interact")){
            trigger.Activate();
        }
    }
    void FixedUpdate(){
        controller.Move(horizontalInput * Time.fixedDeltaTime,false,jumping);
        jumping = false;
    }
    void OnTriggerEnter2D(Collider2D col){
        Debug.Log("Trigger set");
        if(col.gameObject.layer == 3){trigger = col.gameObject.GetComponent<ActionTrigger>();}
    }
    void OnTriggerExit2D(Collider2D col){
        Debug.Log("Trigger unset");
        if(col.gameObject.layer == 3){trigger = null;}
    }
}
