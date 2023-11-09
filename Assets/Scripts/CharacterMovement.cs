using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public CharacterController2D controller;
    private float horizontalInput;
    private bool jumping = false;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal") * 40f;
        if(Input.GetButtonDown("Jump")){
            jumping = true;
        }
    }
    void FixedUpdate(){
        controller.Move(horizontalInput * Time.fixedDeltaTime,false,jumping);
        jumping = false;
    }
}
