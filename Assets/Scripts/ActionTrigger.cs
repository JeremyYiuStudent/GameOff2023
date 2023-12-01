using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActionTrigger : MonoBehaviour
{
    public bool displayHint = true;
    public string hintMessage;
    public abstract void Activate();
    public abstract void Deactivate();
}
