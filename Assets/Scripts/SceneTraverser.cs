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
    }
    public override void Deactivate(){}
}
