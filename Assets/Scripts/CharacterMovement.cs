using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements.Experimental;

public class CharacterMovement : MonoBehaviour
{

    public CharacterController2D controller;
    private float horizontalInput;
    private bool jumping = false;
    private bool dashing = false;
    private ActionTrigger trigger;

    public GameObject triggerHint;

    public enum controlStatus { movement, dialogue, readMenu };
    public static controlStatus currentStatus = controlStatus.movement;

    // Update is called once per frame
    void Update()
    {
        switch (currentStatus)
        {
            case controlStatus.movement:
                horizontalInput = Input.GetAxis("Horizontal") * 40f;
                if (Input.GetButtonDown("Jump"))
                {
                    jumping = true;
                }
                if (Input.GetButtonDown("Interact"))
                {
                    trigger.Activate();
                }
                if (Input.GetButtonDown("Palette"))
                {
                    this.gameObject.GetComponent<ColorMixer>().Activate();
                }
                break;
            case controlStatus.dialogue:
                if (Input.GetButtonDown("Interact"))
                {
                    (trigger as DialogueController).Next();
                }
                break;
            case controlStatus.readMenu:
                if (Input.GetButtonDown("Interact"))
                {
                    trigger.Deactivate();
                }
                break;
        }
        if (Input.GetMouseButtonDown(0))
        {
            dashing = true;
        }
    }
    void FixedUpdate()
    {
        if (currentStatus == controlStatus.movement)
        {
            controller.Move(horizontalInput * Time.fixedDeltaTime, false, jumping, dashing);
            jumping = false;
            dashing = false;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Trigger");
        if (col.gameObject.layer == 3) { trigger = col.gameObject.GetComponent<ActionTrigger>(); }
        Debug.Log(trigger);
        if (trigger.displayHint)
        {
            triggerHint.GetComponent<TextMeshProUGUI>().text = trigger.hintMessage;
            triggerHint.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("Untrigger");
        if (col.gameObject.layer == 3) { trigger = null; }
        triggerHint.GetComponent<TextMeshProUGUI>().text = "";
        triggerHint.SetActive(false);
    }
}