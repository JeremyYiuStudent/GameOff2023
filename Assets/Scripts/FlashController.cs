using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashController : MonoBehaviour
{
    private Image img;
    private Coroutine routine;
    // Start is called before the first frame update
    void Start()
    {
        img = this.gameObject.GetComponent<Image>();
    }

    public void Flash(){
        if(routine != null){StopCoroutine(routine);}
        routine = StartCoroutine(Flashing(0.5f, 0.5f));
    }
    public IEnumerator Flashing(float seconds, float max){
        float flashInDuration = seconds/2;
        Color c;
        for(float t = 0; t <= flashInDuration;t += Time.deltaTime){
            c = img.color;
            c.a = Mathf.Lerp(0,max,t/flashInDuration);
            img.color = c;
            yield return null;
        }
        float flashOutDuration = seconds/2;
        for(float t = 0; t <= flashInDuration;t += Time.deltaTime){
            c = img.color;
            c.a = Mathf.Lerp(max,0,t/flashInDuration);
            img.color = c;
            yield return null;
        }
        c = img.color;
        c.a = 0;
        img.color = c;
    }
}
