using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public GameObject red, green, blue, yellow, magenta, cyan;
    private Color currentColor;
    // Start is called before the first frame update
    void Start()
    {
        currentColor = DataHolder.activeColor;
        updateShapes();
    }

    // Update is called once per frame
    void Update()
    {
        if(DataHolder.activeColor != currentColor){
            currentColor = DataHolder.activeColor;
            updateShapes();
        }
    }
    private void updateShapes(){
        red.SetActive(false);
        green.SetActive(false);
        blue.SetActive(false);
        yellow.SetActive(false);
        magenta.SetActive(false);
        cyan.SetActive(false);
        switch(currentColor){
            case Color c when c == Color.red:
                red.SetActive(true);
                break;
            case Color c when c == Color.green:
                green.SetActive(true);
                break;
            case Color c when c == Color.blue:
                blue.SetActive(true);
                break;
            case Color c when c == Color.yellow:
                yellow.SetActive(true);
                break;
            case Color c when c == Color.magenta:
                magenta.SetActive(true);
                break;
            case Color c when c == Color.cyan:
                cyan.SetActive(true);
                break;
        }
    }
}
