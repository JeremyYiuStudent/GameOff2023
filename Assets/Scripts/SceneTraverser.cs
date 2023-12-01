using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTraverser : ActionTrigger
{
    public string whereTo;
    public override void Activate()
    {
        SceneManager.LoadScene(whereTo);
        DataHolder.maxJump = 1;
        DataHolder.canDash = true;
    }
    public override void Deactivate(){}
}
