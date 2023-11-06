using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScaler : MonoBehaviour
{
    private bool colorToneCountDown = true;
    private float greyScale = 1f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(colorToneCountDown && greyScale > 0){
            greyScale-=0.05f;
            updateGreyScale();
            StartCoroutine(colorCountDown(1));
            Debug.Log("Current multiplier is at: " + greyScale);
        }
    }
    IEnumerator colorCountDown(int x){
        colorToneCountDown = false;
        yield return new WaitForSeconds(x);
        colorToneCountDown = true;
    }
    void updateGreyScale(){
        this.gameObject.GetComponent<Renderer>().material.SetFloat("_GrayScale", greyScale);
    }

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Bump");
        greyScale = 1;
    }
}
