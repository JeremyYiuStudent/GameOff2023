using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScaler : MonoBehaviour
{
    public float changePerTick = 0.05f;
    public float timePerTick = 1f;
    private bool colorToneCountDown = true;
    private float greyScale = 1f;

    private Vector3 checkPoint = new Vector3(0,0,0);

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(colorToneCountDown && greyScale > 0 && CharacterMovement.currentStatus == CharacterMovement.controlStatus.movement){
            greyScale-=changePerTick;
            if(greyScale <= 0){
                this.gameObject.transform.position = checkPoint;
                greyScale = 1;
            }
            updateGreyScale();
            StartCoroutine(colorCountDown(timePerTick));
        }
    }
    IEnumerator colorCountDown(float x){
        colorToneCountDown = false;
        yield return new WaitForSeconds(x);
        colorToneCountDown = true;
    }
    void updateGreyScale(){
        this.gameObject.GetComponent<Renderer>().material.SetFloat("_GrayScale", greyScale);
    }

    void OnTriggerEnter2D(Collider2D other){
        checkPoint = other.gameObject.transform.position;
        greyScale = 1;
    }
}
