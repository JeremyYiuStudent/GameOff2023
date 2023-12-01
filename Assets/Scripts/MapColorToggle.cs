using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapColorToggle : MonoBehaviour
{
    void Start()
    {
        this.gameObject.GetComponent<Renderer>().material.SetFloat("_GrayScale", 0);
        
    }
    public void Coloring(){
        this.gameObject.GetComponent<Renderer>().material.SetFloat("_GrayScale", 1);
    }
}
