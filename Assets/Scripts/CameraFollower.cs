using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public GameObject target;
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = target.transform.position + Vector3.forward*-10 + Vector3.up*3;
    }
}
