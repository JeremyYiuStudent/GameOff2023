using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapColorToggle : MonoBehaviour
{
    public int sceneNo;
    void Start()
    {
        if(DataHolder.toggleColor[sceneNo-1] == false){
            this.gameObject.GetComponent<Renderer>().material.SetFloat("_GrayScale", 0);
        }else{
            this.gameObject.GetComponent<Renderer>().material.SetFloat("_GrayScale", 1);
        }
        
    }
    public void Coloring(){
        DataHolder.toggleColor[sceneNo] = true;
        this.gameObject.GetComponent<Renderer>().material.SetFloat("_GrayScale", 1);
    }
}
