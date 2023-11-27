using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    private string[] sceneList = {"Scene1", "Scene2"};
    public void LoadScene(int x){
        SceneManager.LoadScene(sceneList[x]);
    }
}
