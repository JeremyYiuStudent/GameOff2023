using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColorMixer : MonoBehaviour
{
    private TextMeshProUGUI text;
    private bool mixerUp = false;
    
    private int holder;

    private string[] colorTable = {"Red", "Yellow", "Purple", "Green", "", "Cyan", "", "", "Blue"};
    // Start is called before the first frame update
    void Start()
    {
        text = this.gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J)){
            mixerUp = !mixerUp;
        }
    }
    void OnGUI(){
        if(mixerUp){
            if(GUI.Button(new Rect(100,0,100,30), "Red")){
                if(holder == 0){holder = 1;}
                else{
                    text.text = colorTable[holder*1-1];
                    holder = 0; mixerUp = false;
                }
            }
            if(GUI.Button(new Rect(200,0,100,30), "Green")){
                if(holder == 0){holder = 2;}
                else{
                    text.text = colorTable[holder*2-1];
                    holder = 0; mixerUp = false;
                }
            }
            if(GUI.Button(new Rect(300,0,100,30), "Blue")){
                if(holder == 0){holder = 3;}
                else{
                    text.text = colorTable[holder*3-1];
                    holder = 0; mixerUp = false;
                }
            }
        }
    }
}
